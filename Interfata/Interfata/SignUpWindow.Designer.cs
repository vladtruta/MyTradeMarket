namespace Interfata
{
    partial class SignUpWindow
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
            this.passwd_box = new System.Windows.Forms.TextBox();
            this.passwdrepeat_box = new System.Windows.Forms.TextBox();
            this.username_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.passwd_match_error = new System.Windows.Forms.Label();
            this.field_empty_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passwd_box
            // 
            this.passwd_box.Location = new System.Drawing.Point(124, 88);
            this.passwd_box.Name = "passwd_box";
            this.passwd_box.PasswordChar = '*';
            this.passwd_box.Size = new System.Drawing.Size(130, 20);
            this.passwd_box.TabIndex = 1;
            // 
            // passwdrepeat_box
            // 
            this.passwdrepeat_box.Location = new System.Drawing.Point(124, 130);
            this.passwdrepeat_box.Name = "passwdrepeat_box";
            this.passwdrepeat_box.PasswordChar = '*';
            this.passwdrepeat_box.Size = new System.Drawing.Size(130, 20);
            this.passwdrepeat_box.TabIndex = 2;
            // 
            // username_box
            // 
            this.username_box.Location = new System.Drawing.Point(124, 47);
            this.username_box.Name = "username_box";
            this.username_box.Size = new System.Drawing.Size(130, 20);
            this.username_box.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Repeat Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(149, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "Sign Up";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // passwd_match_error
            // 
            this.passwd_match_error.AutoSize = true;
            this.passwd_match_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwd_match_error.ForeColor = System.Drawing.Color.Red;
            this.passwd_match_error.Location = new System.Drawing.Point(12, 166);
            this.passwd_match_error.Name = "passwd_match_error";
            this.passwd_match_error.Size = new System.Drawing.Size(41, 13);
            this.passwd_match_error.TabIndex = 12;
            this.passwd_match_error.Text = "label4";
            // 
            // field_empty_error
            // 
            this.field_empty_error.AutoSize = true;
            this.field_empty_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.field_empty_error.ForeColor = System.Drawing.Color.Red;
            this.field_empty_error.Location = new System.Drawing.Point(12, 9);
            this.field_empty_error.Name = "field_empty_error";
            this.field_empty_error.Size = new System.Drawing.Size(41, 13);
            this.field_empty_error.TabIndex = 13;
            this.field_empty_error.Text = "label5";
            this.field_empty_error.Click += new System.EventHandler(this.field_empty_error_Click);
            // 
            // SignUpWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 244);
            this.Controls.Add(this.field_empty_error);
            this.Controls.Add(this.passwd_match_error);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.username_box);
            this.Controls.Add(this.passwdrepeat_box);
            this.Controls.Add(this.passwd_box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SignUpWindow";
            this.Text = "SignUpWindow";
            this.Load += new System.EventHandler(this.SignUpWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox passwd_box;
        private System.Windows.Forms.TextBox passwdrepeat_box;
        private System.Windows.Forms.TextBox username_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label passwd_match_error;
        private System.Windows.Forms.Label field_empty_error;
    }
}