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
    public partial class LoginWindow : Form
    {
        public static bool anon;
        public static string loginName;

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void username_field_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            

            if (username_field.Text == "" || password_field.Text == "")
                MessageBox.Show("Fields cannot be empty for login!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (username_field.Text == "vlad" && password_field.Text == "admin")
            {
                loginName = "vlad";

                anon = false;
                OrderList ol = new OrderList();
                this.Hide();
                ol.FormClosed += Ol_FormClosed;
                ol.Show();
            }
        }

        private void Ol_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void signup_button_Click(object sender, EventArgs e)
        {
            SignUpWindow suw = new SignUpWindow();

            this.Hide();
            suw.FormClosed += Suw_FormClosed;
            suw.Show();
        }

        private void Suw_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void LoginWindow_Load(object sender, EventArgs e)
        {

        }

        private void anon_button_Click(object sender, EventArgs e)
        {
            loginName = "Anonymous";
            anon = true;
            OrderList ol = new OrderList();
            this.Hide();
            ol.FormClosed += Ol_FormClosed;
            ol.Show();
        }

        private void LoginWindow_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void LoginWindow_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void LoginWindow_Load_1(object sender, EventArgs e)
        {

        }
    }
}
