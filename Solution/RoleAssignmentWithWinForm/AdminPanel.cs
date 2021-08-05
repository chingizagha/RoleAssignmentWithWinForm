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

namespace RoleAssignmentWithWinForm
{
    public partial class AdminPanel : Form
    {

        public AdminPanel()
        {
            InitializeComponent();
            
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin ff = new FormLogin();
            ff.Show();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-82S0U2V;Initial Catalog=LoginForm;Persist Security Info=True;User ID=sa;Password=murad123");
            textBox3.Text = FormLogin.passingText;
            string sql = "select * from [User] where Email ='"+textBox3.Text+"' ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string name = myreader.GetString(3);
                    string password = myreader.GetString(2);
                    string email = myreader.GetString(1);
                    textBox1.Text = name;
                    textBox3.Text = password;
                    textBox2.Text = email;
                }
            }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            labelAdminName.Text = "Welcome, " + textBox1.Text;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEditor ff = new AddEditor();
            this.Hide();
            ff.Show();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-82S0U2V;Initial Catalog=LoginForm;Persist Security Info=True;User ID=sa;Password=murad123");
            SqlCommand sqlCommand = new SqlCommand("UPDATE [User] SET Username =@Username, Password=@Password WHERE ID ='"+ 1 +"'", con);
            sqlCommand.Parameters.AddWithValue("@Username", textBox1.Text);
            sqlCommand.Parameters.AddWithValue("@Password", textBox3.Text);
            try
            {
                con.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Changed");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
