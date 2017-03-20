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
            tbOutput.Text = Encryption(tbInput.Text.Trim());
        }

        private void btnResolve_Click(object sender, EventArgs e)
        {
            tbOutput.Text = "";
            //byte[] palindata = Encoding.Default.GetBytes(tbInput.Text);//将要加密的字符串转换为字节数组
            //byte[] encryptdata = md5.ComputeHash(palindata);//将字符串加密后也转换为字符数组
            //tbOutput.Text = Convert.ToBase64String(encryptdata);//将加密后的字节数组转换为加密字符串
            tbOutput.Text = Decrypt(tbInput.Text.Trim());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbInput.Text = "";
            tbOutput.Text = "";
            tbKey.Text = "";
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
    }
}