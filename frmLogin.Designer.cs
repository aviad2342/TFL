namespace HW5
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbAccount = new System.Windows.Forms.Label();
            this.lbRegister = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Aharoni", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblUser.ForeColor = System.Drawing.Color.LightGray;
            this.lblUser.Location = new System.Drawing.Point(111, 165);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(88, 20);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "User ID:";
            // 
            // txtUserId
            // 
            this.txtUserId.BackColor = System.Drawing.Color.Silver;
            this.txtUserId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserId.Location = new System.Drawing.Point(239, 165);
            this.txtUserId.MaxLength = 9;
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(126, 23);
            this.txtUserId.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Silver;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(239, 203);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(126, 23);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Font = new System.Drawing.Font("Aharoni", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPass.ForeColor = System.Drawing.Color.LightGray;
            this.lblPass.Location = new System.Drawing.Point(111, 203);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(113, 20);
            this.lblPass.TabIndex = 2;
            this.lblPass.Text = "Password:";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Aharoni", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnLogin.Location = new System.Drawing.Point(115, 293);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(97, 32);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Aharoni", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnReset.Location = new System.Drawing.Point(292, 293);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(86, 32);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(161, 251);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::HW5.Properties.Resources.login_page;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(94, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 60);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lbAccount
            // 
            this.lbAccount.AutoSize = true;
            this.lbAccount.BackColor = System.Drawing.Color.Transparent;
            this.lbAccount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbAccount.Location = new System.Drawing.Point(55, 370);
            this.lbAccount.Name = "lbAccount";
            this.lbAccount.Size = new System.Drawing.Size(157, 15);
            this.lbAccount.TabIndex = 8;
            this.lbAccount.Text = "Dont have an account ?";
            // 
            // lbRegister
            // 
            this.lbRegister.AutoSize = true;
            this.lbRegister.BackColor = System.Drawing.Color.Transparent;
            this.lbRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbRegister.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegister.ForeColor = System.Drawing.Color.Magenta;
            this.lbRegister.Location = new System.Drawing.Point(211, 370);
            this.lbRegister.Name = "lbRegister";
            this.lbRegister.Size = new System.Drawing.Size(102, 15);
            this.lbRegister.TabIndex = 9;
            this.lbRegister.Text = "Register here !";
            this.lbRegister.Click += new System.EventHandler(this.lbRegister_Click);
            this.lbRegister.MouseEnter += new System.EventHandler(this.lbRegister_MouseEnter);
            this.lbRegister.MouseLeave += new System.EventHandler(this.lbRegister_MouseLeave);
            this.lbRegister.MouseHover += new System.EventHandler(this.lbRegister_MouseHover);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::HW5.Properties.Resources.Login_Backgrounddd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(495, 395);
            this.Controls.Add(this.lbRegister);
            this.Controls.Add(this.lbAccount);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.lblUser);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbAccount;
        private System.Windows.Forms.Label lbRegister;
    }
}