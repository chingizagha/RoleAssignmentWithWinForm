using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace RoleAssignmentWithWinForm
{
    public partial class FormLogin : Form
    {
        public static string passingText;
        public FormLogin()
        {
            InitializeComponent();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-82S0U2V;Initial Catalog=LoginForm;Persist Security Info=True;User ID=sa;Password=murad123");
            SqlCommand cmd = new SqlCommand("SELECT * FROM [User] WHERE Email='" + txtBoxEmail.Text + "' AND Password='" + txtBoxPassword.Text + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string cmbItemValue = comboBoxType.SelectedItem.ToString();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    if (dt.Rows[i]["UserType"].ToString() == cmbItemValue) 
                    {

                        MessageBox.Show("You are login as " + dt.Rows[i][3]);
                        if (comboBoxType.SelectedIndex == 0)
                        {
                            passingText = txtBoxEmail.Text;
                            AdminPanel f = new AdminPanel();
                            f.Show();
                            this.Hide();
                        }
                        else
                        {
                            passingText = txtBoxEmail.Text;
                            EditorForm fr = new EditorForm();
                            this.Hide();
                            fr.Show();
                        }
                    }

                }

            }
            else
            {
                MessageBox.Show("Error");
            }
            

        }   
    }
}
