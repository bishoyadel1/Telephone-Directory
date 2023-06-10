using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telephone1
{
    public partial class UserSearch : Form
    {
        public UserSearch()
        {
            InitializeComponent();
        }
       GeneralClass gen = new GeneralClass();   
       
        private void UserSearch_Load(object sender, EventArgs e)
        {
            gen.LoadTable("Users",dgv);
        }
    }
}
