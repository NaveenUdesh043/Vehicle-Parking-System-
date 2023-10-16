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
    public partial class Lorry : MetroFramework.Forms.MetroForm
    {
        public Lorry()
        {
            InitializeComponent();
        }

        database db = new database();

        private void Clear()
        {
            label04.Text = "";
        }

        private void Lorry_Load(object sender, EventArgs e)
        {
            Adddetails();
        }
        private void Adddetails()
        {
            string Query = "Select sid from slots where status = 'Available' and sid like 'C%'";
            DataTable dt = Data.getData(Query);
            if (dt.Rows.Count > 0)
            {
                for (int c = 0; c < (dt.Rows.Count); c++)
                {
                    cmb_lorry.Items.Add(dt.Rows[c][0].ToString());
                }
            }
        }
        database Data = new database();

        private void btn_lorry2_Click(object sender, EventArgs e)
        {
            

            Clear();

            if (string.IsNullOrEmpty(cmb_lorry.Text))
            {
                label04.Text = "Please Select a Slot";
                label04.Focus();
            }
            else
            {
                Registration.sid = cmb_lorry.SelectedItem.ToString();
                MetroFramework.MetroMessageBox.Show(this, "Data save Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     Registration obj8 = new Registration();
                   obj8.Show();
                    this.Hide();
            }
            
            
        }

        private void btn_lorry1_Click(object sender, EventArgs e)
        {
            Welcome obj13 = new Welcome();
            obj13.Show();
            this.Hide();
            
        }
    }
}
