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
    public partial class EditorForm : Form
    {
        static string conString = @"Data Source=DESKTOP-82S0U2V;Initial Catalog=LoginForm;Persist Security Info=True;User ID=sa;Password=murad123";
        SqlConnection con = new SqlConnection(conString);
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();
        public EditorForm()
        {
            InitializeComponent();
            listViewCustomer.FullRowSelect = true;
        }

        private void populateLV(string id, string name, string lastName, string email, string city, string phone)
        {
            String[] row = { id, name, lastName,email,city,phone };

            listViewCustomer.Items.Add(new ListViewItem(row));
        }

        private void add(string name, string lastName, string email, string city, string phone)
        {
            String sql = "INSERT INTO [Customer](first_name,last_name,email,city,phone) VALUES(@NAME,@LASTNAME,@EMAIL,@CITY,@PHONE)";
            cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@NAME", name);
            cmd.Parameters.AddWithValue("@LASTNAME", lastName);
            cmd.Parameters.AddWithValue("@EMAIL", email);
            cmd.Parameters.AddWithValue("@CITY", city);
            cmd.Parameters.AddWithValue("@PHONE", phone);
            try
            {
                con.Open();

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Inserted");
                }

                con.Close();

                retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void EditorForm_Load(object sender, EventArgs e)
        {

            listViewCustomer.Visible = false;
            btnClear.Visible = false;
            btnDelete.Visible = false;
            btnRead.Visible = false;
            btnUpdate.Visible = false;

            textBox1.Text = FormLogin.passingText;
            string sql = "select * from [User] where Email ='" + textBox1.Text + "' ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string name = myreader.GetString(3);
                    bool create = myreader.GetBoolean(5);
                    bool read = myreader.GetBoolean(6);
                    bool update = myreader.GetBoolean(7);
                    bool delete = myreader.GetBoolean(8);

                    labelEditorName.Text = "Welcome, " + name;

                    if (create == true)
                    {
                        btnClear.Visible = true;
                    }
                    if (update == true)
                    {
                        btnUpdate.Visible = true;
                    }
                    if (read == true)
                    {
                        btnRead.Visible = true;
                    }
                    if (delete == true)
                    {
                        btnDelete.Visible = true;
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void retrieve()
        {
            listViewCustomer.Items.Clear();

            //SQL STMT
            string sql = "SELECT * FROM [Customer]";
            cmd = new SqlCommand(sql, con);

            try
            {
                con.Open();

                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    populateLV(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString());
                }

                con.Close();


                //CLEAR DT
                dt.Rows.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        //UPDATE
        private void update(int id, string name, string lastName, string email, string city, string phone)
        {

            string sql = "UPDATE [Customer] SET first_name='" + name + "',last_name='" + lastName + "', email='" + email + "',city='" + city + "',phone='" + phone + "' WHERE customer_id=" + id + "";
            cmd = new SqlCommand(sql, con);

            try
            {
                con.Open();

                adapter = new SqlDataAdapter(cmd);
                adapter.UpdateCommand = con.CreateCommand();
                adapter.UpdateCommand.CommandText = sql;

                if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    txtFName.Text = "";
                    txtLName.Text = "";
                    txtEmail.Text = "";
                    txtCity.Text = "";
                    txtPhone.Text = "";

                    MessageBox.Show("Successfully Updated");
                }

                con.Close();

                //REFRESH
                retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

        }

        //DELETE
        private void delete(int id)
        {
            String sql = "DELETE FROM [Customer] WHERE customer_id=" + id + "";
            cmd = new SqlCommand(sql, con);

            try
            {
                con.Open();

                adapter = new SqlDataAdapter(cmd);
                adapter.DeleteCommand = con.CreateCommand();
                adapter.DeleteCommand.CommandText = sql;
                if (MessageBox.Show("Sure?", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        txtFName.Text = "";
                        txtLName.Text = "";
                        txtEmail.Text = "";
                        txtCity.Text = "";
                        txtPhone.Text = "";
                        MessageBox.Show("Successfully deleted");
                    }
                }

                con.Close();

                //REFRESH
                retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

        }

        private void listViewCustomer_MouseClick(object sender, MouseEventArgs e)
        {
            txtFName.Text = listViewCustomer.SelectedItems[0].SubItems[1].Text;
            txtLName.Text = listViewCustomer.SelectedItems[0].SubItems[2].Text;
            txtEmail.Text = listViewCustomer.SelectedItems[0].SubItems[3].Text;
            txtCity.Text = listViewCustomer.SelectedItems[0].SubItems[4].Text;
            txtPhone.Text = listViewCustomer.SelectedItems[0].SubItems[5].Text;

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            add(txtFName.Text, txtLName.Text, txtEmail.Text, txtCity.Text, txtPhone.Text);
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            retrieve();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(listViewCustomer.SelectedItems[0].SubItems[0].Text);
            string name = txtFName.Text;
            string lastName = txtLName.Text;
            string email = txtEmail.Text;
            string city = txtCity.Text;
            string phone = txtPhone.Text;


            update(id, name, lastName, email, city, phone);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(listViewCustomer.SelectedItems[0].SubItems[0].Text);
            delete(id);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listViewCustomer.Items.Clear();
            txtFName.Text = "";
            txtLName.Text = "";
            txtEmail.Text = "";
            txtCity.Text = "";
            txtPhone.Text = "";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin ff = new FormLogin();
            ff.Show();
        }

       

        private void btnRead_Click(object sender, EventArgs e)
        {
            listViewCustomer.Visible = true;
        }
    }
}
