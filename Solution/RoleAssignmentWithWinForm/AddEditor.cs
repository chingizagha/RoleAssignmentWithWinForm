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
    public partial class AddEditor : Form
    {
        public AddEditor()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-82S0U2V;Initial Catalog=LoginForm;Persist Security Info=True;User ID=sa;Password=murad123");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[User]
           ([Username]
           ,[Email]
           ,[Password]
           ,[UserType]
           ,[Create]
           ,[Read]
           ,[Update]
           ,[Delete])
     VALUES
           ('" + txtEditorName.Text + "', '" + txtEditorEmail.Text + "', '" + txtEditorPassword.Text + "', '" + comboBoxType.SelectedItem.ToString() + "', '" + checkBoxCreate.Checked + "', '" + checkBoxRead.Checked + "', '" + checkBoxUpdate.Checked + "', '" + checkBoxDelete.Checked + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Register Successfully");
            this.Close();
            AdminPanel ff = new AdminPanel();
            ff.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminPanel ff = new AdminPanel();
            ff.Show();
        }
    }
}
