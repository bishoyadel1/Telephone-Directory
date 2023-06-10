using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Telephone1
{
    internal class Users
    {
        public void ClearForm (Form1 User)
        {
            User.UserID.Text = "000000000";
            User.UserName.Text = "";
            User.UserGender.SelectedIndex = 0;
            User.UserPassword.Text = "";
            User.AddUser.Checked = false;
            User.AddCustomer.Checked = false;
            User.AddCustomerDetail.Checked = false;
            User.SearchCustomer.Checked = false;
            User.SearchCustomerDetail.Checked = false;
        }
        public int GetID (String ColName, String TableName)
        {
            DataTable dt = new DataTable();


            SqlDataAdapter da = new SqlDataAdapter();
            dt.Clear();
            da = new SqlDataAdapter("select ISNULL(Max("+ ColName + "), 0 ) as MaxId from " + TableName + " ", GeneralClass.sqlConnection);
            da.Fill(dt);
            int NewID=0;

            if (Convert.ToInt32( dt.Rows[0][0])== NewID)
                return NewID;
            else
            {
                NewID = Convert.ToInt32(dt.Rows[0][0]) + 1;
                return NewID;
            }
        }

        public void SaveOrUpdate(Form1 frm)
        {
            DataTable dt = new DataTable();


            SqlDataAdapter da = new SqlDataAdapter();
            dt.Clear();
            da = new SqlDataAdapter("select * from Users where UserID = "+frm.UserID.Text+"" , GeneralClass.sqlConnection);
            da.Fill(dt);
            if (dt.Rows.Count>0)
            {
                
                dt.Rows[0]["UserID"] = frm.UserID.Text;
                dt.Rows[0]["UserName"] = frm.UserName.Text;
                dt.Rows[0]["UserFullName"] = frm.UserName.Text;
                dt.Rows[0]["UserGender"] = frm.UserGender.Text;
                dt.Rows[0]["UserName"] = frm.UserName.Text;
                dt.Rows[0]["UserPassword"] = frm.UserPassword.Text;
                dt.Rows[0]["UserDate"] = DateTime.Now.Date;
                dt.Rows[0]["AddUser"] = frm.AddUser.Checked;
                dt.Rows[0]["SearchUser"] = frm.SearchUser.Checked;
                dt.Rows[0]["AddCustomer"] = frm.AddCustomer.Checked;
                dt.Rows[0]["SearchCustomer"] = frm.SearchCustomer.Checked;
                dt.Rows[0]["AddCustomerDetail"] = frm.AddCustomerDetail.Checked;
                dt.Rows[0]["SearchCustomerDetail"] = frm.SearchCustomerDetail.Checked;
            
                SqlCommandBuilder save = new SqlCommandBuilder(da);
                da.Update(dt);
                dt.AcceptChanges();
                MessageBox.Show("Update successful");
            }
            else
            {
                dt.Rows.Add();
                int index = dt.Rows.Count-1;
              
                dt.Rows[index]["UserID"] = frm.UserID.Text;
                dt.Rows[index]["UserName"] = frm.UserName.Text;
                dt.Rows[index]["UserFullName"] = frm.UserName.Text;
                dt.Rows[index]["UserGender"] = frm.UserGender.Text;
                dt.Rows[index]["UserName"] = frm.UserName.Text;
                dt.Rows[index]["UserPassword"] = frm.UserPassword.Text;
                dt.Rows[index]["UserDate"] = DateTime.Now.Date;
                dt.Rows[index]["AddUser"] = frm.AddUser.Checked;
                dt.Rows[index]["SearchUser"] = frm.SearchUser.Checked;
                dt.Rows[index]["AddCustomer"] = frm.AddCustomer.Checked;
                dt.Rows[index]["SearchCustomer"] = frm.SearchCustomer.Checked;
                dt.Rows[index]["AddCustomerDetail"] = frm.AddCustomerDetail.Checked;
                dt.Rows[index]["SearchCustomerDetail"] = frm.SearchCustomerDetail.Checked;
               
                SqlCommandBuilder save = new SqlCommandBuilder(da);
                da.Update(dt);
                dt.AcceptChanges();
                MessageBox.Show("Save successful");



            }
        }
    }
}
