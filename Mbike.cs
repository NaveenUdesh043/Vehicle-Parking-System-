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
    public partial class Mbike : MetroFramework.Forms.MetroForm
    {
        public Mbike()
        {
            InitializeComponent();
        }

        database db = new database();

        private void Clear()
        {
            label06.Text = "";
        }

        private void btn_mbike2_Click(object sender, EventArgs e)
        {
           
            Clear();

            if (string.IsNullOrEmpty(cmb_mbike.Text))
            {
                label06.Text = "Please Select a Slot";
                label06.Focus();
            }
            else
            {
                Registration.sid = cmb_mbike.SelectedItem.ToString();

                MetroFramework.MetroMessageBox.Show(this, "Data save Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Registration obj10 = new Registration();
                        obj10.Show();
                        this.Hide();
            }

        }
            
                
    

        private void btn_mbike1_Click(object sender, EventArgs e)
        {
            Welcome obj15 = new Welcome();
            obj15.Show(); 
            this.Hide();
            
        }

        private void Mbike_Load(object sender, EventArgs e)
        {
            Adddetails();
        }
        private void Adddetails()
        {
            string Query = "Select sid from slots where status = 'Available' and sid like 'E%'";
            DataTable dt = Data.getData(Query);
            if (dt.Rows.Count > 0)
            {
                for (int c = 0; c < (dt.Rows.Count); c++)
                {
                    cmb_mbike.Items.Add(dt.Rows[c][0].ToString());
                }
            }
        }
        database Data = new database();
    }
}
