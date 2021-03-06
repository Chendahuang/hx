
namespace hx
{
    partial class fmRegister
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
            this.label1 = new System.Windows.Forms.Label();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.edtPassword2 = new Sunny.UI.UITextBox();
            this.btnRegister = new Sunny.UI.UISymbolButton();
            this.btnCancel = new Sunny.UI.UISymbolButton();
            this.edtPassword = new Sunny.UI.UITextBox();
            this.edtUser = new Sunny.UI.UITextBox();
            this.uiLine1 = new Sunny.UI.UILine();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(35, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 39);
            this.label1.TabIndex = 13;
            this.label1.Text = "航星文章视频管理系统";
            // 
            // uiPanel1
            // 
            this.uiPanel1.BackColor = System.Drawing.Color.White;
            this.uiPanel1.Controls.Add(this.edtPassword2);
            this.uiPanel1.Controls.Add(this.btnRegister);
            this.uiPanel1.Controls.Add(this.btnCancel);
            this.uiPanel1.Controls.Add(this.edtPassword);
            this.uiPanel1.Controls.Add(this.edtUser);
            this.uiPanel1.Controls.Add(this.uiLine1);
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(424, 128);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(207, 235);
            this.uiPanel1.TabIndex = 14;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edtPassword2
            // 
            this.edtPassword2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtPassword2.EnterAsTab = true;
            this.edtPassword2.FillColor = System.Drawing.Color.White;
            this.edtPassword2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.edtPassword2.Location = new System.Drawing.Point(12, 141);
            this.edtPassword2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edtPassword2.Maximum = 2147483647D;
            this.edtPassword2.Minimum = -2147483648D;
            this.edtPassword2.MinimumSize = new System.Drawing.Size(1, 1);
            this.edtPassword2.Name = "edtPassword2";
            this.edtPassword2.Padding = new System.Windows.Forms.Padding(5);
            this.edtPassword2.PasswordChar = '*';
            this.edtPassword2.Size = new System.Drawing.Size(182, 29);
            this.edtPassword2.Symbol = 61475;
            this.edtPassword2.SymbolSize = 22;
            this.edtPassword2.TabIndex = 2;
            this.edtPassword2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.edtPassword2.Watermark = "请确认密码";
            // 
            // btnRegister
            // 
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FillColor = System.Drawing.Color.ForestGreen;
            this.btnRegister.FillHoverColor = System.Drawing.Color.Green;
            this.btnRegister.FillPressColor = System.Drawing.Color.Green;
            this.btnRegister.FillSelectedColor = System.Drawing.Color.Green;
            this.btnRegister.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnRegister.Location = new System.Drawing.Point(13, 186);
            this.btnRegister.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btnRegister.RectColor = System.Drawing.Color.ForestGreen;
            this.btnRegister.RectHoverColor = System.Drawing.Color.ForestGreen;
            this.btnRegister.RectPressColor = System.Drawing.Color.ForestGreen;
            this.btnRegister.RectSelectedColor = System.Drawing.Color.DarkGreen;
            this.btnRegister.Size = new System.Drawing.Size(86, 29);
            this.btnRegister.Style = Sunny.UI.UIStyle.Custom;
            this.btnRegister.StyleCustomMode = true;
            this.btnRegister.Symbol = 62108;
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "注册";
            this.btnRegister.TipsColor = System.Drawing.Color.ForestGreen;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCancel.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.btnCancel.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btnCancel.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnCancel.Location = new System.Drawing.Point(110, 187);
            this.btnCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btnCancel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCancel.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.btnCancel.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btnCancel.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btnCancel.Size = new System.Drawing.Size(86, 29);
            this.btnCancel.Style = Sunny.UI.UIStyle.Red;
            this.btnCancel.StyleCustomMode = true;
            this.btnCancel.Symbol = 61453;
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // edtPassword
            // 
            this.edtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtPassword.EnterAsTab = true;
            this.edtPassword.FillColor = System.Drawing.Color.White;
            this.edtPassword.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.edtPassword.Location = new System.Drawing.Point(12, 104);
            this.edtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edtPassword.Maximum = 2147483647D;
            this.edtPassword.Minimum = -2147483648D;
            this.edtPassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.edtPassword.Name = "edtPassword";
            this.edtPassword.Padding = new System.Windows.Forms.Padding(5);
            this.edtPassword.PasswordChar = '*';
            this.edtPassword.Size = new System.Drawing.Size(182, 29);
            this.edtPassword.Symbol = 61475;
            this.edtPassword.SymbolSize = 22;
            this.edtPassword.TabIndex = 1;
            this.edtPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.edtPassword.Watermark = "请输入密码";
            // 
            // edtUser
            // 
            this.edtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtUser.EnterAsTab = true;
            this.edtUser.FillColor = System.Drawing.Color.White;
            this.edtUser.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.edtUser.Location = new System.Drawing.Point(12, 66);
            this.edtUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edtUser.Maximum = 2147483647D;
            this.edtUser.Minimum = -2147483648D;
            this.edtUser.MinimumSize = new System.Drawing.Size(1, 1);
            this.edtUser.Name = "edtUser";
            this.edtUser.Padding = new System.Windows.Forms.Padding(5);
            this.edtUser.Size = new System.Drawing.Size(182, 29);
            this.edtUser.Symbol = 61447;
            this.edtUser.SymbolSize = 22;
            this.edtUser.TabIndex = 3;
            this.edtUser.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.edtUser.Watermark = "请输入账号";
            // 
            // uiLine1
            // 
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine1.Location = new System.Drawing.Point(20, 33);
            this.uiLine1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(164, 16);
            this.uiLine1.TabIndex = 2;
            this.uiLine1.Text = "用户注册";
            // 
            // fmRegister
            // 
            this.AllowShowTitle = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::hx.Properties.Resources.Login2;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.label1);
            this.Name = "fmRegister";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.ShowRadius = false;
            this.ShowShadow = true;
            this.ShowTitle = false;
            this.Text = "Form_Register";
            this.uiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label label1;
        public Sunny.UI.UIPanel uiPanel1;
        public Sunny.UI.UITextBox edtPassword2;
        public Sunny.UI.UISymbolButton btnRegister;
        public Sunny.UI.UISymbolButton btnCancel;
        public Sunny.UI.UITextBox edtPassword;
        public Sunny.UI.UITextBox edtUser;
        public Sunny.UI.UILine uiLine1;
    }
}