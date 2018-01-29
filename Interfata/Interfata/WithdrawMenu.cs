using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfata
{
    public partial class WithdrawMenu : Form
    {
        OrderList orderList;

        public WithdrawMenu(OrderList ol)
        {
            orderList = ol;
            this.ControlBox = false;
            InitializeComponent();
        }

        private void WithdrawMenu_Load(object sender, EventArgs e)
        {
            if (orderList.CurrentBalance < 0)
                currentBalanceLabel.Text = "No Internet";
            else
                currentBalanceLabel.Text = orderList.CurrentBalance.ToString();
        }

        private void withdraw_button_Click(object sender, EventArgs e)
        {
           decimal amount = amountToWithdraw.Value;
           decimal currentBalance = orderList.CurrentBalance;
 
            if (walletIDBox.Text.Length < 26)
                MessageBox.Show("Wallet ID invalid. Check your entry again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (amount > currentBalance)
                MessageBox.Show("Not enough money!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (amount < 2)
                MessageBox.Show("Value cannot be less than 2!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                currentBalance -= amount;
                currentBalanceLabel.Text = currentBalance.ToString();
                amountToWithdraw.Value = 0;
                MessageBox.Show("Withdrawal has completed successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            amountToWithdraw.Value = 0;
        }

        private void all_button_Click(object sender, EventArgs e)
        {
            decimal currentBalance = Convert.ToDecimal(currentBalanceLabel.Text);
            amountToWithdraw.Value = currentBalance;
        }

        private void amountToWithdraw_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void amountToWithdraw_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void currentBalanceLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
