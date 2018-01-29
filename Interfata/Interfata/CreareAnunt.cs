using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Net;

namespace Interfata
{
    public partial class CreareAnunt : Form
    {
        public CreareAnunt()
        {
            this.ControlBox = false;
            InitializeComponent();
        }

        private void CreareAnunt_Load(object sender, EventArgs e)
        {
            wordsLeft.Text = "500";
        }

        private void descriptionBox_TextChanged(object sender, EventArgs e)
        {
            wordsLeft.Text = (500 - descriptionBox.Text.Length).ToString();
        }

        private void post_button_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null || titleBox.Text == "" || descriptionBox.Text == "" || walletIDBox.Text == "" )
                MessageBox.Show("There are empty fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (walletIDBox.Text.Length < 26)
                MessageBox.Show("Wallet ID invalid! Check your entry again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MessageBox.Show("Order has been placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                JObject o = JObject.FromObject(new
                {
                    channel = new
                    {
                        title = titleBox.Text,
                        description = descriptionBox.Text,
                        price = priceBox.Text,
                        seller = LoginWindow.loginName,
                        pictureURL = pictureURL.Text,
                        sellerRep = OrderList.rep.ToString()
                    }
                });

                string jsonInString = o.ToString();
                MessageBox.Show(jsonInString);
                byte[] jsonInByte = Encoding.Unicode.GetBytes(jsonInString);
                WebRequest web = WebRequest.Create("http://localhost:51891/api/products/add" + jsonInString);
                HttpWebResponse response = (HttpWebResponse)web.GetResponse();
            }
        }

        private void browse_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = "Open Image";
            dlg.Filter = "Bitmap (*.bmp)|*.bmp|JPEG (*.jpg)|*.jpg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = new Bitmap(dlg.FileName);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }

            dlg.Dispose();
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
            pictureURL.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OrderList ol = new OrderList();

            this.Hide();
            ol.FormClosed += Ol_FormClosed;
        }

        private void Ol_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void setImageButton_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox.Load(pictureURL.Text);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
