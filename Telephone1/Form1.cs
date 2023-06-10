using Microsoft.Data.SqlClient;
using System.Data;

namespace Telephone1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        Users User = new Users();
        private void Form1_Load(object sender, EventArgs e)
        {
            User.ClearForm(this);
            UserID.Text = User.GetID("UserID", "Users").ToString();
        }
  

        private void btn_new_Click(object sender, EventArgs e)
        {

            User.ClearForm(this);
        }

        private void UserID_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            User.SaveOrUpdate(this);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_showpass.Checked==true)
            {
                UserPassword.UseSystemPasswordChar = false;
            }
            else
                UserPassword.UseSystemPasswordChar = true;
        }
    }
}