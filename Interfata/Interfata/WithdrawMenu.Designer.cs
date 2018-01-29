namespace Interfata
{
    partial class WithdrawMenu
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
            this.currentBalanceLabel = new System.Windows.Forms.Label();
            this.amountToWithdraw = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.withdraw_button = new System.Windows.Forms.Button();
            this.all_button = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            this.walletIDBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.amountToWithdraw)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Balance:";
            // 
            // currentBalanceLabel
            // 
            this.currentBalanceLabel.AutoSize = true;
            this.currentBalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentBalanceLabel.ForeColor = System.Drawing.Color.Green;
            this.currentBalanceLabel.Location = new System.Drawing.Point(137, 13);
            this.currentBalanceLabel.Name = "currentBalanceLabel";
            this.currentBalanceLabel.Size = new System.Drawing.Size(94, 18);
            this.currentBalanceLabel.TabIndex = 1;
            this.currentBalanceLabel.Text = "9.95030001";
            this.currentBalanceLabel.Click += new System.EventHandler(this.currentBalanceLabel_Click);
            // 
            // amountToWithdraw
            // 
            this.amountToWithdraw.DecimalPlaces = 8;
            this.amountToWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountToWithdraw.Increment = new decimal(new int[] {
            1,
            0,
            0,
            524288});
            this.amountToWithdraw.Location = new System.Drawing.Point(140, 67);
            this.amountToWithdraw.Maximum = new decimal(new int[] {
            1569325057,
            23283064,
            0,
            524288});
            this.amountToWithdraw.Name = "amountToWithdraw";
            this.amountToWithdraw.Size = new System.Drawing.Size(189, 24);
            this.amountToWithdraw.TabIndex = 0;
            this.amountToWithdraw.ValueChanged += new System.EventHandler(this.amountToWithdraw_ValueChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Amount to Withdraw:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // withdraw_button
            // 
            this.withdraw_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdraw_button.Location = new System.Drawing.Point(231, 207);
            this.withdraw_button.Name = "withdraw_button";
            this.withdraw_button.Size = new System.Drawing.Size(98, 50);
            this.withdraw_button.TabIndex = 4;
            this.withdraw_button.Text = "Withdraw";
            this.withdraw_button.UseVisualStyleBackColor = true;
            this.withdraw_button.Click += new System.EventHandler(this.withdraw_button_Click);
            // 
            // all_button
            // 
            this.all_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.all_button.Location = new System.Drawing.Point(254, 97);
            this.all_button.Name = "all_button";
            this.all_button.Size = new System.Drawing.Size(75, 23);
            this.all_button.TabIndex = 1;
            this.all_button.Text = "All";
            this.all_button.UseVisualStyleBackColor = true;
            this.all_button.Click += new System.EventHandler(this.all_button_Click);
            // 
            // reset_button
            // 
            this.reset_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_button.Location = new System.Drawing.Point(140, 97);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(75, 23);
            this.reset_button.TabIndex = 2;
            this.reset_button.Text = "Reset";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // walletIDBox
            // 
            this.walletIDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.walletIDBox.Location = new System.Drawing.Point(16, 179);
            this.walletIDBox.MaxLength = 35;
            this.walletIDBox.Name = "walletIDBox";
            this.walletIDBox.Size = new System.Drawing.Size(313, 22);
            this.walletIDBox.TabIndex = 3;
            this.walletIDBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Wallet ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(13, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Warning: Incorrect ID will lead to loss of money!";
            // 
            // WithdrawMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 263);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.walletIDBox);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.all_button);
            this.Controls.Add(this.withdraw_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.amountToWithdraw);
            this.Controls.Add(this.currentBalanceLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "WithdrawMenu";
            this.Text = "Close";
            this.Load += new System.EventHandler(this.WithdrawMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.amountToWithdraw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentBalanceLabel;
        private System.Windows.Forms.NumericUpDown amountToWithdraw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button withdraw_button;
        private System.Windows.Forms.Button all_button;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.TextBox walletIDBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}