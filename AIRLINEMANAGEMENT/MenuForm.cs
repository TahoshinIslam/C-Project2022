using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIRLINEMANAGEMENT
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnfligts_Click(object sender, EventArgs e)
        {
            FlightForm FF = new FlightForm();
             
            FF.Show();
            this.Hide();
        }

        private void btnpassengers_Click(object sender, EventArgs e)
        {
            PassengerForm PF = new PassengerForm();
            PF.Show();
            this.Hide();
        }

        private void btntickets_Click(object sender, EventArgs e)
        {
            TicketForm TF = new TicketForm();
            TF.Show();
            this.Hide();
        }

        private void btncancellation_Click(object sender, EventArgs e)
        {
            CancellationForm CF = new CancellationForm();
            CF.Show();
            this.Hide();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Logout Application?", "SPEED AIRLINE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 login = new Form1();
                this.Show();
                login.ShowDialog();
            }
        }
    }
}
