namespace LoginIn
{
    partial class frmlogin
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
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLogintext = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.llblForgotpass = new System.Windows.Forms.LinkLabel();
            this.llblSignup = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(240, 202);
            this.txtLogin.Multiline = true;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(269, 42);
            this.txtLogin.TabIndex = 0;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(240, 281);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(269, 42);
            this.txtPass.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(236, 179);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(64, 20);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "User ID";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(240, 258);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(78, 20);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LoginIn.Properties.Resources.twitter;
            this.pictureBox1.Location = new System.Drawing.Point(312, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 121);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblLogintext
            // 
            this.lblLogintext.AutoSize = true;
            this.lblLogintext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogintext.Location = new System.Drawing.Point(319, 157);
            this.lblLogintext.Name = "lblLogintext";
            this.lblLogintext.Size = new System.Drawing.Size(123, 20);
            this.lblLogintext.TabIndex = 5;
            this.lblLogintext.Text = "Log In to Twitter";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Location = new System.Drawing.Point(240, 330);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(269, 43);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // llblForgotpass
            // 
            this.llblForgotpass.AutoSize = true;
            this.llblForgotpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblForgotpass.Location = new System.Drawing.Point(240, 380);
            this.llblForgotpass.Name = "llblForgotpass";
            this.llblForgotpass.Size = new System.Drawing.Size(108, 16);
            this.llblForgotpass.TabIndex = 7;
            this.llblForgotpass.TabStop = true;
            this.llblForgotpass.Text = "Forgot password";
            // 
            // llblSignup
            // 
            this.llblSignup.AutoSize = true;
            this.llblSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblSignup.Location = new System.Drawing.Point(394, 380);
            this.llblSignup.Name = "llblSignup";
            this.llblSignup.Size = new System.Drawing.Size(115, 16);
            this.llblSignup.TabIndex = 8;
            this.llblSignup.TabStop = true;
            this.llblSignup.Text = "Sign Up for Twitter";
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.llblSignup);
            this.Controls.Add(this.llblForgotpass);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblLogintext);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtLogin);
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Twitter Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLogintext;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel llblForgotpass;
        private System.Windows.Forms.LinkLabel llblSignup;
    }
}

