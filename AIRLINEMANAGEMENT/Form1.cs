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

namespace AIRLINEMANAGEMENT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HD6PS8A\SQLEXPRESS;Initial Catalog=AIRLINE;Integrated Security=True");
        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username, user_password;
            username = txtname.Text;
            user_password = this.txtpass.Text;
            try
            {
                String querry = "select username,role from Loginn where username ='" + txtname.Text + "' AND password = '" + txtpass.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                if (dtable.Rows.Count > 0)
                {
                    username = txtname.Text;
                    user_password = this.txtpass.Text;
                    MenuForm MF = new MenuForm();
                    MF.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid username and password!", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtname.Clear();
                    txtpass.Clear();

                    txtname.Focus();
                }
            }
            catch
            {
                MessageBox.Show("EROR");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtpass.Clear();

            txtname.Focus();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application?", "AIRLINE MANAGEMENT SYSTEM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
