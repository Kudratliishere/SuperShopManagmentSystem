﻿namespace SuperShopDesktop.Login.SignIn
{
    partial class SigninOperator
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.glbl_forgotPassword = new Guna.UI.WinForms.GunaLabel();
            this.glbl_errorMessage = new Guna.UI.WinForms.GunaLabel();
            this.gchb_showpass = new Guna.UI.WinForms.GunaCheckBox();
            this.gbtn_signin = new Guna.UI.WinForms.GunaButton();
            this.gtb_password = new Guna.UI.WinForms.GunaTextBox();
            this.glbl_password = new Guna.UI.WinForms.GunaLabel();
            this.gtb_email = new Guna.UI.WinForms.GunaTextBox();
            this.glbl_email = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // glbl_forgotPassword
            // 
            this.glbl_forgotPassword.AutoSize = true;
            this.glbl_forgotPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.glbl_forgotPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.glbl_forgotPassword.Location = new System.Drawing.Point(112, 339);
            this.glbl_forgotPassword.Name = "glbl_forgotPassword";
            this.glbl_forgotPassword.Size = new System.Drawing.Size(100, 15);
            this.glbl_forgotPassword.TabIndex = 15;
            this.glbl_forgotPassword.Text = "Forgot Password?";
            this.glbl_forgotPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // glbl_errorMessage
            // 
            this.glbl_errorMessage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.glbl_errorMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.glbl_errorMessage.Location = new System.Drawing.Point(82, 286);
            this.glbl_errorMessage.Name = "glbl_errorMessage";
            this.glbl_errorMessage.Size = new System.Drawing.Size(161, 53);
            this.glbl_errorMessage.TabIndex = 14;
            this.glbl_errorMessage.Text = "Everything is okey";
            this.glbl_errorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.glbl_errorMessage.Visible = false;
            // 
            // gchb_showpass
            // 
            this.gchb_showpass.BaseColor = System.Drawing.Color.White;
            this.gchb_showpass.CheckedOffColor = System.Drawing.Color.Gray;
            this.gchb_showpass.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gchb_showpass.FillColor = System.Drawing.Color.White;
            this.gchb_showpass.Location = new System.Drawing.Point(185, 215);
            this.gchb_showpass.Name = "gchb_showpass";
            this.gchb_showpass.Radius = 3;
            this.gchb_showpass.Size = new System.Drawing.Size(58, 20);
            this.gchb_showpass.TabIndex = 13;
            this.gchb_showpass.Text = "Show";
            this.gchb_showpass.CheckedChanged += new System.EventHandler(this.gchb_showpass_CheckedChanged);
            // 
            // gbtn_signin
            // 
            this.gbtn_signin.AnimationHoverSpeed = 0.07F;
            this.gbtn_signin.AnimationSpeed = 0.03F;
            this.gbtn_signin.BackColor = System.Drawing.Color.Transparent;
            this.gbtn_signin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gbtn_signin.BorderColor = System.Drawing.Color.Black;
            this.gbtn_signin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtn_signin.FocusedColor = System.Drawing.Color.Empty;
            this.gbtn_signin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbtn_signin.ForeColor = System.Drawing.Color.White;
            this.gbtn_signin.Image = null;
            this.gbtn_signin.ImageSize = new System.Drawing.Size(20, 20);
            this.gbtn_signin.Location = new System.Drawing.Point(83, 241);
            this.gbtn_signin.Name = "gbtn_signin";
            this.gbtn_signin.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gbtn_signin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtn_signin.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtn_signin.OnHoverImage = null;
            this.gbtn_signin.OnPressedColor = System.Drawing.Color.Black;
            this.gbtn_signin.Radius = 10;
            this.gbtn_signin.Size = new System.Drawing.Size(160, 42);
            this.gbtn_signin.TabIndex = 12;
            this.gbtn_signin.Text = "Sign in";
            this.gbtn_signin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbtn_signin.Click += new System.EventHandler(this.gbtn_signin_Click);
            // 
            // gtb_password
            // 
            this.gtb_password.BackColor = System.Drawing.Color.Transparent;
            this.gtb_password.BaseColor = System.Drawing.Color.White;
            this.gtb_password.BorderColor = System.Drawing.Color.Silver;
            this.gtb_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtb_password.FocusedBaseColor = System.Drawing.Color.White;
            this.gtb_password.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gtb_password.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gtb_password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtb_password.Location = new System.Drawing.Point(83, 179);
            this.gtb_password.Name = "gtb_password";
            this.gtb_password.PasswordChar = '●';
            this.gtb_password.Radius = 10;
            this.gtb_password.SelectedText = "";
            this.gtb_password.Size = new System.Drawing.Size(160, 30);
            this.gtb_password.TabIndex = 11;
            this.gtb_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gtb_password_KeyDown);
            // 
            // glbl_password
            // 
            this.glbl_password.AutoSize = true;
            this.glbl_password.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.glbl_password.Location = new System.Drawing.Point(126, 147);
            this.glbl_password.Name = "glbl_password";
            this.glbl_password.Size = new System.Drawing.Size(71, 20);
            this.glbl_password.TabIndex = 10;
            this.glbl_password.Text = "Password";
            // 
            // gtb_email
            // 
            this.gtb_email.BackColor = System.Drawing.Color.Transparent;
            this.gtb_email.BaseColor = System.Drawing.Color.White;
            this.gtb_email.BorderColor = System.Drawing.Color.Silver;
            this.gtb_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtb_email.FocusedBaseColor = System.Drawing.Color.White;
            this.gtb_email.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gtb_email.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gtb_email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtb_email.Location = new System.Drawing.Point(83, 103);
            this.gtb_email.Name = "gtb_email";
            this.gtb_email.PasswordChar = '\0';
            this.gtb_email.Radius = 10;
            this.gtb_email.SelectedText = "";
            this.gtb_email.Size = new System.Drawing.Size(160, 30);
            this.gtb_email.TabIndex = 9;
            this.gtb_email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gtb_email_KeyDown);
            // 
            // glbl_email
            // 
            this.glbl_email.AutoSize = true;
            this.glbl_email.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.glbl_email.Location = new System.Drawing.Point(138, 70);
            this.glbl_email.Name = "glbl_email";
            this.glbl_email.Size = new System.Drawing.Size(46, 20);
            this.glbl_email.TabIndex = 8;
            this.glbl_email.Text = "Email";
            // 
            // SigninOperator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.glbl_forgotPassword);
            this.Controls.Add(this.glbl_errorMessage);
            this.Controls.Add(this.gchb_showpass);
            this.Controls.Add(this.gbtn_signin);
            this.Controls.Add(this.gtb_password);
            this.Controls.Add(this.glbl_password);
            this.Controls.Add(this.gtb_email);
            this.Controls.Add(this.glbl_email);
            this.Name = "SigninOperator";
            this.Size = new System.Drawing.Size(346, 417);
            this.Load += new System.EventHandler(this.SigninOperator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel glbl_forgotPassword;
        private Guna.UI.WinForms.GunaLabel glbl_errorMessage;
        private Guna.UI.WinForms.GunaCheckBox gchb_showpass;
        private Guna.UI.WinForms.GunaButton gbtn_signin;
        private Guna.UI.WinForms.GunaTextBox gtb_password;
        private Guna.UI.WinForms.GunaLabel glbl_password;
        private Guna.UI.WinForms.GunaTextBox gtb_email;
        private Guna.UI.WinForms.GunaLabel glbl_email;
    }
}
