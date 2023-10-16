using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Vehicle_Parking_System
{
    public partial class Bus : MetroFramework.Forms.MetroForm
    {
        public Bus()
        {
            InitializeComponent();
        }
        
        database db = new database();

        private void Clear()
        {
            label05.Text = "";
        }

        private void btn_bus2_Click(object sender, EventArgs e)
        {
          
            Clear ();
            if (string.IsNullOrEmpty(cmb_bus.Text))
            {
                label05.Text = "Please Select a Slot";
                label05.Focus();
            }
            else
            {
                Registration.sid = cmb_bus.SelectedItem.ToString();

                MetroFramework.MetroMessageBox.Show(this, "Data save Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         Registration obj9 = new Registration();
                         obj9.Show();
                        this.Hide();

            }
              
        }

        private void btn_bus1_Click(object sender, EventArgs e)
        {
            Welcome obj14 = new Welcome();
            obj14.Show();
            this.Hide();

        }

        private void Bus_Load(object sender, EventArgs e)
        {
            Adddetails();
        }
        private void Adddetails()
        {
            string Query = "Select sid from slots where status = 'Available' and sid like 'D%'";
            DataTable dt = Data.getData(Query);
            if (dt.Rows.Count > 0)
            {
                for (int c = 0; c < (dt.Rows.Count); c++)
                {
                    cmb_bus.Items.Add(dt.Rows[c][0].ToString());
                }
            }
        }
        database Data = new database();

    }
}
