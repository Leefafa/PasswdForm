using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Security.Cryptography;
using System.IO;

namespace PasswdForm
{
    public partial class PasswdForm : DevExpress.XtraEditors.XtraForm
    {
        MD5 md5 = new MD5CryptoServiceProvider();
        public PasswdForm()
        {
            InitializeComponent();
            tbInput.Text = "";
            tbOutput.Text = "";
            tbKey.Text = "";
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //byte[] palindata = Encoding.Default.GetBytes(tbInput.Text);//将要加密的字符串转换为字节数组
            //byte[] encryptdata = md5.ComputeHash(palindata);//将字符串加密后也转换为字符数组
            //tbOutput.Text = Convert.ToBase64String(encryptdata);//将加密后的字节数组转换为加密字符串
            //tbOutput.Text = Encryption(tbInput.Text.Trim());
            tbOutput.Text = Encode(tbInput.Text.Trim());
        }

        private void btnResolve_Click(object sender, EventArgs e)
        {
            tbOutput.Text = "";
            //byte[] palindata = Encoding.Default.GetBytes(tbInput.Text);//将要加密的字符串转换为字节数组
            //byte[] encryptdata = md5.ComputeHash(palindata);//将字符串加密后也转换为字符数组
            //tbOutput.Text = Convert.ToBase64String(encryptdata);//将加密后的字节数组转换为加密字符串
            //tbOutput.Text = Decrypt(tbInput.Text.Trim());
            tbOutput.Text = Decode(tbInput.Text.Trim());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbInput.Text = "";
            tbOutput.Text = "";
            tbKey.Text = "";
            tbIV.Text = "";
        }

        //加密
        private string Encryption(string express)
        {
            try
            {
                CspParameters param = new CspParameters();
                param.KeyContainerName = tbKey.Text.Trim();//密匙容器的名称，保持加密解密一致才能解密成功
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(param))
                {
                    byte[] plaindata = Encoding.Default.GetBytes(express);//将要加密的字符串转换为字节数组
                    byte[] encryptdata = rsa.Encrypt(plaindata, false);//将加密后的字节数据转换为新的加密字节数组
                    return Convert.ToBase64String(encryptdata);//将加密后的字节数组转换为字符串
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("加密失败！" + ex.Message);
                return "";
            }
        }
        //解密
        private string Decrypt(string ciphertext)
        {
            try
            {
                CspParameters param = new CspParameters();
                param.KeyContainerName = tbKey.Text.Trim();
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(param))
                {
                    byte[] encryptdata = Convert.FromBase64String(ciphertext);
                    byte[] decryptdata = rsa.Decrypt(encryptdata, false);
                    return Encoding.Default.GetString(decryptdata);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("解密失败" + ex.Message);
                return "";
            }
        }

        /// <summary>
        /// 可逆加密解密
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public string Encode(string data)
        {
            try
            {
                byte[] byKey = ASCIIEncoding.ASCII.GetBytes(tbKey.Text.Trim());
                byte[] byIV = ASCIIEncoding.ASCII.GetBytes(tbIV.Text.Trim());
                DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
                int i = cryptoProvider.KeySize;
                MemoryStream ms = new MemoryStream();
                CryptoStream cst = new CryptoStream(ms, cryptoProvider.CreateEncryptor(byKey, byIV), CryptoStreamMode.Write);
                StreamWriter sw = new StreamWriter(cst);
                sw.Write(data);
                sw.Flush();
                cst.FlushFinalBlock();
                sw.Flush();
                return Convert.ToBase64String(ms.GetBuffer(), 0, (int)ms.Length);
            }
            catch (Exception ex)
            {
               MessageBox.Show("解密失败" + ex.Message);
               return "";
            }
        }
        public string Decode(string data)
        {
            try
            {
                byte[] byKey = ASCIIEncoding.ASCII.GetBytes(tbKey.Text.Trim());
                byte[] byIV = ASCIIEncoding.ASCII.GetBytes(tbIV.Text.Trim());
                byte[] byEnc;
                try
                {
                    byEnc = Convert.FromBase64String(data);
                }
                catch (Exception)
                {
                    return null;
                }
                DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
                MemoryStream ms = new MemoryStream(byEnc);
                CryptoStream cst = new CryptoStream(ms, cryptoProvider.CreateDecryptor(byKey, byIV), CryptoStreamMode.Read);
                StreamReader sr = new StreamReader(cst);
                return sr.ReadToEnd();
            }
            catch (Exception ex)
            {
               MessageBox.Show("解密失败" + ex.Message);
               return "";
            }
        }

    }
}