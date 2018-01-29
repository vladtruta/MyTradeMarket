namespace Interfata
{
    partial class LoginWindow
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
            this.username_field = new System.Windows.Forms.TextBox();
            this.password_field = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.signup_button = new System.Windows.Forms.Button();
            this.login_button = new System.Windows.Forms.Button();
            this.anon_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username_field
            // 
            this.username_field.Location = new System.Drawing.Point(106, 29);
            this.username_field.Name = "username_field";
            this.username_field.Size = new System.Drawing.Size(146, 20);
            this.username_field.TabIndex = 0;
            this.username_field.TextChanged += new System.EventHandler(this.username_field_TextChanged);
            // 
            // password_field
            // 
            this.password_field.Location = new System.Drawing.Point(106, 75);
            this.password_field.Name = "password_field";
            this.password_field.PasswordChar = '*';
            this.password_field.Size = new System.Drawing.Size(146, 20);
            this.password_field.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // signup_button
            // 
            this.signup_button.Location = new System.Drawing.Point(13, 127);
            this.signup_button.Name = "signup_button";
            this.signup_button.Size = new System.Drawing.Size(75, 35);
            this.signup_button.TabIndex = 4;
            this.signup_button.Text = "Sign Up";
            this.signup_button.UseVisualStyleBackColor = true;
            this.signup_button.Click += new System.EventHandler(this.signup_button_Click);
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(106, 127);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(75, 35);
            this.login_button.TabIndex = 2;
            this.login_button.Text = "Log In";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // anon_button
            // 
            this.anon_button.ForeColor = System.Drawing.Color.Red;
            this.anon_button.Location = new System.Drawing.Point(208, 127);
            this.anon_button.Name = "anon_button";
            this.anon_button.Size = new System.Drawing.Size(75, 35);
            this.anon_button.TabIndex = 3;
            this.anon_button.Text = "Anonymous";
            this.anon_button.UseVisualStyleBackColor = true;
            this.anon_button.Click += new System.EventHandler(this.anon_button_Click);
            // 
            // LoginWindow
            // 
            this.AcceptButton = this.login_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 183);
            this.Controls.Add(this.anon_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.signup_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_field);
            this.Controls.Add(this.username_field);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginWindow";
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.LoginWindow_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginWindow_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginWindow_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_field;
        private System.Windows.Forms.TextBox password_field;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button signup_button;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button anon_button;
    }
}

