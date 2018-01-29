using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interfata.PanelDataNamespace;

namespace Interfata
{
    public partial class Individual_Order : Form
    {
        int s, m;
        PanelData toFillWith;

        public Individual_Order(PanelData pnlData)
        {
            this.ControlBox = false;
            toFillWith = pnlData;
            InitializeComponent();
        }

        private void Individual_Order_Load(object sender, EventArgs e)
        {
            
            titleText.Text = toFillWith.title;
            descriptionText.Text = toFillWith.description;
            priceText.Text = toFillWith.price.ToString();
            sellerName.Text = toFillWith.seller;
            repAmount.Text = toFillWith.rep.ToString();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            OrderList ol = new OrderList();

            this.Hide();
            ol.FormClosed += Ol_FormClosed;
        }

        private void Ol_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void etaTimeSeconds_Click(object sender, EventArgs e)
        {

        }

        private void placeOrder_Click(object sender, EventArgs e)
        {
            //TRB LUAT DIN DB SI WALLETID 
            //MessageBox.Show(toFillWith.sellerID);
            Bitcoin_App_TradeMarket_PoliHack.WebAPI.MakeTransaction(OrderList.walletID, toFillWith.sellerID, toFillWith.price);
        }
    }
}
