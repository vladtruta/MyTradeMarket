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
    public partial class SignUpWindow : Form
    {
        public SignUpWindow()
        {
            this.ControlBox = false;
            InitializeComponent();
        }

        private void field_empty_error_Click(object sender, EventArgs e)
        {

        }

        private void SignUpWindow_Load(object sender, EventArgs e)
        {
            passwd_match_error.Text = "";
            field_empty_error.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginWindow lw = new LoginWindow();
            this.Hide();
            lw.FormClosed += Lw_FormClosed;
            lw.Show();
        }

        private void Lw_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            passwd_match_error.Text = "";
            field_empty_error.Text = "";
            if (username_box.Text == "" || passwd_box.Text == "" || passwdrepeat_box.Text == "")
                field_empty_error.Text = "Some fields are empty!";
            if (passwdrepeat_box.Text != passwd_box.Text)
            {
                passwd_match_error.Text = "Passwords do not match!";
                passwdrepeat_box.Clear();
                passwd_box.Clear();
            }
            else //ii bun
            {
                MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
