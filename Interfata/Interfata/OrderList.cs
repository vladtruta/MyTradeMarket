using Interfata.PanelDataNamespace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfata
{
    public partial class OrderList : Form
    {
        private decimal currentBalance;
        private decimal pendingBalance;
        List<PanelData> pnlData = new List<PanelData>();
        List<string> tags = new List<string>();
        public static string walletID = "9sVnYyG1z5Z146bsYo4npFeJTo66L96YiB";
        public static int rep; //REPUTATIA

        public OrderList()
        {
            this.ControlBox = false;
            InitializeComponent();
        }

        public string processProducts(string url)
        {
            try
            {
                string rt;

                WebRequest request = WebRequest.Create(url);

                WebResponse response = request.GetResponse();

                Stream dataStream = response.GetResponseStream();

                StreamReader reader = new StreamReader(dataStream);

                rt = reader.ReadToEnd();
                
                reader.Close();
                response.Close();

                return rt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }

        private void fillOrders(int inc, int sf)
        {
            string firstPart = "http://localhost:51891/api/products/";
            int i;

            for (i = inc; i <= sf; i++)
            {
                string rt;
                rt = processProducts(firstPart + i.ToString());
                processJSON(i, rt);
                if (rt.Contains("NOT AVAILABLE"))
                    hideNonAvail(i);

            }
        }

        private void processJSON(int i, string rt)
        {
            try
            {
                PanelData tempPanel = new PanelData();
                int poz = 1;

                string[] temp = rt.Split(',');
                foreach (string index in temp)
                {
                    string[] item = index.Split(':');
                    item[1] = item[1].Replace("\"", string.Empty).Trim();

                    switch (poz)
                    {
                        case 2:
                            tempPanel.title = item[1];
                            break;
                        case 3:
                            tempPanel.price = Convert.ToDecimal(item[1]);
                            break;
                        case 4:
                            tempPanel.description = item[1];
                            break;
                        case 6:
                            tempPanel.sellerID = item[1];
                            break;
                        case 8:
                            tempPanel.seller = item[1];
                            break;
                        case 10:
                            tempPanel.pictureURL = item[1];
                            break;
                    }
                    poz++;
                }
                if (tempPanel.title != null && tempPanel.description != null)
                {
                    pnlData.Add(tempPanel);
                    adaugaLaPoz(i, tempPanel);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void hideNonAvail(int i)
        {
            Panel pnl = this.Controls.Find("panel" + i.ToString(), true).FirstOrDefault() as Panel;

            pnl.Visible = false;
        }

        private void getRep()
        {
            this.Text = "User: " + LoginWindow.loginName + " (Rep: " + rep.ToString() + ")";
        }

        public void refreshInterface()
        {
            //GET REPUTATIE TODO
            getRep();
            fillOrders(1, 10); //comenzile
            for (int i = 1; i <= 10; i++)
                adaugaLaPoz(i, pnlData[i - 1]);

            getBalance(walletID); //banii
            getPendingBalance(walletID);

            //tagurile
            for (int i = 0; i < 10; i++)
            {
                string[] sArray = pnlData[i].title.Split(' ');
                foreach (string s in sArray)
                    if (!tags.Contains(s))
                        tags.Add(s);
            }
            //foreach (string s in tags)
              //  searchBoxText.Text += s + " ";

        }

        private void searchByTag(object sender, EventArgs e) //TODO
        {
            if (searchBoxText.Text == "")
                MessageBox.Show("Search entries cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int i, j; //TEMPORAR (va cauta in DB)
                string[] searchBoxEntries = searchBoxText.Text.Split(' ');

                for (i = 0; i < 10; i++)
                {
                    //for (j = 0; j < searchBoxEntries.Length; j++)
                       // if (searchBoxEntries[j] == pnlData[i].title)

                }
            }
        }

        private void OrderList_Load(object sender, EventArgs e)
        {
            if (LoginWindow.anon)
            {
                signOutToolStripMenuItem1.Visible = false;
                signInToolStripMenuItem1.Visible = true;
            }
            else
            {
                signOutToolStripMenuItem1.Visible = true;
                signInToolStripMenuItem1.Visible = false;
            }
            refreshInterface();
           
        }

        private void adaugaLaPoz(int poz, PanelData data)
        {
            int i;
            int titlePos = 6 + (7 * (poz - 1));
            int descPos = 9 + (7 * (poz - 1));
            int repPos = 3 + (7 * (poz - 1));
            int sellerPos = 7 + (7 * (poz - 1));
            int pricePos = 4 + (7 * (poz - 1));


            Label titleLabel = this.Controls.Find("label" + titlePos, true).FirstOrDefault() as Label;
            Label descLabel = this.Controls.Find("label" + descPos, true).FirstOrDefault() as Label;
            Label repLabel = this.Controls.Find("label" + repPos, true).FirstOrDefault() as Label;
            Label sellerLabel = this.Controls.Find("label" + sellerPos, true).FirstOrDefault() as Label;
            Label priceLabel = this.Controls.Find("label" + pricePos, true).FirstOrDefault() as Label;

            titleLabel.Text = data.title;
            descLabel.Text = data.description;
            repLabel.Text = data.rep.ToString();
            sellerLabel.Text = data.seller;
            priceLabel.Text = data.price.ToString();
        }

        private void click_anunt(object sender, EventArgs e)
        {
            int index;
            Control cntrl = (Control)sender;

            index = Int32.Parse(cntrl.Parent.Name.Substring(5));
            Individual_Order ind = new Individual_Order(pnlData[index - 1]);
            ind.Show();
        }

        private void withdrawToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            WithdrawMenu wm = new WithdrawMenu(this);
            wm.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChargeWallet cw = new ChargeWallet(this);
            cw.Show();
        }

        private void exitMenu_click(object sender, EventArgs e)
        {
            if (currentBalance > 0)
            {
                WithdrawMenu wm = new WithdrawMenu(this);

                MessageBox.Show("You must withdraw before closing!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                wm.Show();
            }
            else
            {
                this.Close();
            }
        }

        private void signOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (currentBalance > 0)
            {
                WithdrawMenu wm = new WithdrawMenu(this);
                MessageBox.Show("You must withdraw before closing!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                wm.Show();
            }
            else
            {
                LoginWindow lw = new LoginWindow();

                this.Hide();
                lw.FormClosed += Lw_FormClosed;

                lw.Show();
            }
        }

        private void Lw_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void createOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreareAnunt ca = new CreareAnunt();

            ca.Show();
        }

        private void refreshButton_click(object sender, EventArgs e)
        {
            refreshInterface();
        }

        private void prevButton_click(object sender, EventArgs e)
        {
            refreshInterface();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            refreshInterface();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            refreshInterface();
        }

        private void getBalance(string walletID)
        {
            ///api/v2/get_address_balance/?api_key=API KEY&addresses=ADDRESS1,ADDRESS2,...
            string apiKey = "9d77-f4fb-76fe-7ca3";
            string pin = "veresmort";
            string firstPart = "https://block.io/api/v2/";
            string request = firstPart + "get_address_balance/?api_key=" + apiKey + "&addresses=" + walletID;

            try
            {
                WebRequest web = WebRequest.Create(request);
                HttpWebResponse response = (HttpWebResponse)web.GetResponse();
                Stream writen = response.GetResponseStream();
                StreamReader reader = new StreamReader(writen);

                string toBeRead;
                while ((toBeRead = reader.ReadLine()) != null)
                {
                    if (toBeRead.Contains("available_balance"))
                    {
                        string[] getLine = toBeRead.Split('"');
                        try
                        {
                            string balance = getLine[3];
                            balance.Trim();
                            currentBalance = Convert.ToDecimal(balance);
                        }
                        catch
                        {
                            MessageBox.Show("Unable to get wallet money!");
                        }
                    }
                }
                currentBalanceStrip.Text = currentBalance.ToString();
            }
            catch(Exception e)
            {
                pendingBalanceStrip.Text = "No Internet";
                MessageBox.Show(e.Message + "\nPlease connect to the Internet!");
                currentBalance = -1;
            }
        }

        private void getPendingBalance(string walletID)
        {
            ///api/v2/get_address_balance/?api_key=API KEY&addresses=ADDRESS1,ADDRESS2,...
            string apiKey = "9d77-f4fb-76fe-7ca3";
            //string pin = "veresmort";
            string firstPart = "https://block.io/api/v2/";
            string request = firstPart + "get_address_balance/?api_key=" + apiKey + "&addresses=" + walletID;

            try
            {
                WebRequest web = WebRequest.Create(request);
                HttpWebResponse response = (HttpWebResponse)web.GetResponse();
                Stream writen = response.GetResponseStream();
                StreamReader reader = new StreamReader(writen);

                string toBeRead;
                while ((toBeRead = reader.ReadLine()) != null)
                {
                    if (toBeRead.Contains("pending_received_balance"))
                    {
                        string[] getLine = toBeRead.Split('"');
                        try
                        {
                            string balance = getLine[3];
                            balance.Trim();
                            pendingBalance = Convert.ToDecimal(balance);
                        }
                        catch
                        {
                            MessageBox.Show("Unable to get wallet money!");
                        }
                    }
                }
                pendingBalanceStrip.Text = pendingBalance.ToString();
            }
            catch (Exception e)
            {
                pendingBalanceStrip.Text = "No Internet";
                MessageBox.Show(e.Message + "\nPlease connect to the Internet!");
                currentBalance = -1;
            }
        }

        private void populateAnunturi()
        {

        }

        public decimal CurrentBalance
        {
            get { return currentBalance; }
            set { currentBalance = value; }
        }

        public decimal PendingBalance
        {
            get { return currentBalance; }
            set { currentBalance = value; }
        }

        private void signInToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoginWindow lw = new LoginWindow();

            this.Hide();
            lw.FormClosed += Lw_FormClosed1;
            lw.Show();
        }

        private void Lw_FormClosed1(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void searchBoxText_Click(object sender, EventArgs e)
        {

        }

        private void currentBalanceStrip_Click(object sender, EventArgs e)
        {

        }
    }
}