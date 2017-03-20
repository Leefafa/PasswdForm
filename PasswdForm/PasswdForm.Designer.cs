namespace PasswdForm
{
    partial class PasswdForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswdForm));
            this.panel = new DevExpress.XtraEditors.PanelControl();
            this.lbKey = new DevExpress.XtraEditors.LabelControl();
            this.tbKey = new DevExpress.XtraEditors.TextEdit();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnResolve = new DevExpress.XtraEditors.SimpleButton();
            this.btnGenerate = new DevExpress.XtraEditors.SimpleButton();
            this.tbInput = new DevExpress.XtraEditors.TextEdit();
            this.lbOutput = new DevExpress.XtraEditors.LabelControl();
            this.lbInput = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbKey.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInput.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panel.Appearance.Options.UseBackColor = true;
            this.panel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panel.Controls.Add(this.lbKey);
            this.panel.Controls.Add(this.tbKey);
            this.panel.Controls.Add(this.tbOutput);
            this.panel.Controls.Add(this.btnClear);
            this.panel.Controls.Add(this.btnResolve);
            this.panel.Controls.Add(this.btnGenerate);
            this.panel.Controls.Add(this.tbInput);
            this.panel.Controls.Add(this.lbOutput);
            this.panel.Controls.Add(this.lbInput);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(546, 287);
            this.panel.TabIndex = 0;
            // 
            // lbKey
            // 
            this.lbKey.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKey.Appearance.ForeColor = System.Drawing.Color.Yellow;
            this.lbKey.Location = new System.Drawing.Point(205, 45);
            this.lbKey.Name = "lbKey";
            this.lbKey.Size = new System.Drawing.Size(25, 19);
            this.lbKey.TabIndex = 9;
            this.lbKey.Text = "Key";
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(254, 44);
            this.tbKey.Name = "tbKey";
            this.tbKey.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.tbKey.Size = new System.Drawing.Size(100, 20);
            this.tbKey.TabIndex = 8;
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(137, 141);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(341, 22);
            this.tbOutput.TabIndex = 7;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(403, 217);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "清除";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnResolve
            // 
            this.btnResolve.Location = new System.Drawing.Point(266, 217);
            this.btnResolve.Name = "btnResolve";
            this.btnResolve.Size = new System.Drawing.Size(75, 23);
            this.btnResolve.TabIndex = 5;
            this.btnResolve.Text = "解密";
            this.btnResolve.Click += new System.EventHandler(this.btnResolve_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(137, 217);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "生成";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(137, 82);
            this.tbInput.Name = "tbInput";
            this.tbInput.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.tbInput.Size = new System.Drawing.Size(341, 20);
            this.tbInput.TabIndex = 2;
            // 
            // lbOutput
            // 
            this.lbOutput.Appearance.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOutput.Appearance.ForeColor = System.Drawing.Color.White;
            this.lbOutput.Location = new System.Drawing.Point(68, 141);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(38, 19);
            this.lbOutput.TabIndex = 1;
            this.lbOutput.Text = "生成";
            // 
            // lbInput
            // 
            this.lbInput.Appearance.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbInput.Appearance.ForeColor = System.Drawing.Color.MintCream;
            this.lbInput.Location = new System.Drawing.Point(68, 81);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(38, 19);
            this.lbInput.TabIndex = 0;
            this.lbInput.Text = "输入";
            // 
            // PasswdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::PasswdForm.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(546, 287);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PasswdForm";
            this.Text = "fafa-加密解密";
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbKey.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInput.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panel;
        private DevExpress.XtraEditors.TextEdit tbInput;
        private DevExpress.XtraEditors.LabelControl lbOutput;
        private DevExpress.XtraEditors.LabelControl lbInput;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnResolve;
        private DevExpress.XtraEditors.SimpleButton btnGenerate;
        private System.Windows.Forms.TextBox tbOutput;
        private DevExpress.XtraEditors.TextEdit tbKey;
        private DevExpress.XtraEditors.LabelControl lbKey;
    }
}