namespace Interfata
{
    partial class CreareAnunt
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
            this.titleBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.wordsLeft = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.walletIDBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.post_button = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureURL = new System.Windows.Forms.TextBox();
            this.reset_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.setImageButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleBox
            // 
            this.titleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBox.ForeColor = System.Drawing.Color.Blue;
            this.titleBox.Location = new System.Drawing.Point(77, 39);
            this.titleBox.MaxLength = 50;
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(447, 29);
            this.titleBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description:";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionBox.Location = new System.Drawing.Point(12, 99);
            this.descriptionBox.MaxLength = 500;
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(417, 201);
            this.descriptionBox.TabIndex = 1;
            this.descriptionBox.TextChanged += new System.EventHandler(this.descriptionBox_TextChanged);
            // 
            // wordsLeft
            // 
            this.wordsLeft.AutoSize = true;
            this.wordsLeft.Location = new System.Drawing.Point(394, 303);
            this.wordsLeft.Name = "wordsLeft";
            this.wordsLeft.Size = new System.Drawing.Size(35, 13);
            this.wordsLeft.TabIndex = 4;
            this.wordsLeft.Text = "label3";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Gray;
            this.pictureBox.Location = new System.Drawing.Point(446, 99);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(202, 202);
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // walletIDBox
            // 
            this.walletIDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.walletIDBox.Location = new System.Drawing.Point(88, 350);
            this.walletIDBox.MaxLength = 35;
            this.walletIDBox.Name = "walletIDBox";
            this.walletIDBox.Size = new System.Drawing.Size(313, 22);
            this.walletIDBox.TabIndex = 4;
            this.walletIDBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Wallet ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(9, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Warning: Incorrect ID will lead to loss of money!";
            // 
            // post_button
            // 
            this.post_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.post_button.Location = new System.Drawing.Point(466, 399);
            this.post_button.Name = "post_button";
            this.post_button.Size = new System.Drawing.Size(197, 59);
            this.post_button.TabIndex = 6;
            this.post_button.Text = "Post";
            this.post_button.UseVisualStyleBackColor = true;
            this.post_button.Click += new System.EventHandler(this.post_button_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 423);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 35);
            this.button4.TabIndex = 7;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(17, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "All fields are required!";
            // 
            // priceBox
            // 
            this.priceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceBox.ForeColor = System.Drawing.Color.Green;
            this.priceBox.Location = new System.Drawing.Point(71, 309);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(232, 26);
            this.priceBox.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Price:";
            // 
            // pictureURL
            // 
            this.pictureURL.Location = new System.Drawing.Point(446, 334);
            this.pictureURL.Name = "pictureURL";
            this.pictureURL.Size = new System.Drawing.Size(217, 20);
            this.pictureURL.TabIndex = 20;
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(446, 360);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(52, 24);
            this.reset_button.TabIndex = 3;
            this.reset_button.Text = "Reset";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Picture URL";
            // 
            // setImageButton
            // 
            this.setImageButton.Location = new System.Drawing.Point(595, 360);
            this.setImageButton.Name = "setImageButton";
            this.setImageButton.Size = new System.Drawing.Size(68, 24);
            this.setImageButton.TabIndex = 22;
            this.setImageButton.Text = "Set Image";
            this.setImageButton.UseVisualStyleBackColor = true;
            this.setImageButton.Click += new System.EventHandler(this.setImageButton_Click);
            // 
            // CreareAnunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 465);
            this.Controls.Add(this.setImageButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureURL);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.post_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.walletIDBox);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.wordsLeft);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "CreareAnunt";
            this.Text = "Create New Order";
            this.Load += new System.EventHandler(this.CreareAnunt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label wordsLeft;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox walletIDBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button post_button;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox pictureURL;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button setImageButton;
    }
}