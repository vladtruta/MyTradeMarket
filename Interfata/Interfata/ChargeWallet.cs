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
    public partial class ChargeWallet : Form
    {
        OrderList orderList;

        public ChargeWallet(OrderList ol)
        {
            orderList = ol;
            this.ControlBox = false;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChargeWallet_Load(object sender, EventArgs e)
        {
            if (orderList.CurrentBalance < 0)
            {
                currentBalanceLabel.Text = "No Internet";
                walletIDBox.Text = "No Internet";
            }
            else
            {
                currentBalanceLabel.Text = orderList.CurrentBalance.ToString();
                walletIDBox.Text = OrderList.walletID;
            }
        }

        private void currentBalanceLabel_Click(object sender, EventArgs e)
        {

        }

        private void walletIDBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(walletIDBox.Text);
        }
    }
}
