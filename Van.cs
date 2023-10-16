using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Vehicle_Parking_System
{
    public partial class Van : MetroFramework.Forms.MetroForm
    {
        public Van()
        {
            InitializeComponent();
        }

        database db = new database();

        private void Clear()
        {
            label03.Text = "";
        }


        private void btn_van2_Click(object sender, EventArgs e)
        {
          
            Clear();

            if (string.IsNullOrEmpty(cmb_van.Text))
            {
                label03.Text = "Please Select a Slot";
                label03.Focus();
            }
            else
            {
                 Registration.sid = cmb_van.SelectedItem.ToString();

                MetroFramework.MetroMessageBox.Show(this, "Data save Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Registration obj7 = new Registration();
                        obj7.Show();
                this.Hide();       
            }
            
            
            

            
        }

        private void btn_van1_Click(object sender, EventArgs e)
        {
            Welcome obj12 = new Welcome();
            obj12.Show();
            this.Hide();
            
        }

        private void Van_Load(object sender, EventArgs e)
        {
            Adddetails();
        }

        private void Adddetails()
        {
            string Query = "Select sid from slots where status = 'Available' and sid like 'B%'";
            DataTable dt = Data.getData(Query);
            if (dt.Rows.Count > 0)
            {
                for (int c = 0; c < (dt.Rows.Count); c++)
                {
                    cmb_van.Items.Add(dt.Rows[c][0].ToString());
                }
            }
        }
        database Data = new database();


    }
}
