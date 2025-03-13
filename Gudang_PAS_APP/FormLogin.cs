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

namespace Gudang_PAS_APP
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=SATYA\MSSQLSERVER01;Initial Catalog=shed;Integrated Security=True");


        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           string username, password;

            username = txtUsername.Text;
            password = txtPassword.Text;

            try
            {

                string querry = "SELECT * FROM Users WHERE username = '"+txtUsername.Text+"' AND password = '"+txtPassword.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                DataTable Dtable  = new DataTable();

                sda.Fill (Dtable);

                if(Dtable.Rows.Count > 0)
                {
                    username = txtUsername.Text;
                    password = txtPassword.Text;

                    // page 
                    FormGudang form2 = new FormGudang();
                    form2.Show();

                    this.Hide();
                }

                else
                {
                    MessageBox.Show("invalid Login details", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Clear();
                    txtPassword.Clear();

                    txtUsername.Focus();
                }
            }

            catch
            {
                MessageBox.Show("Error");
            }

            finally
            {
                conn.Close();
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
