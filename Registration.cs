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
    public partial class Registration : MetroFramework.Forms.MetroForm
    {
        public static string sid;
        public Registration()
        {
            InitializeComponent();
            txt_datereg.Text = DateTime.Now.ToShortDateString();
            txt_timearrived.Text = DateTime.Now.ToShortTimeString();
        }


        private void clear()
        {

            label01.Text = "";
            slot_error.Text = "";


        }
        database db = new database();
        private void btn_reg_Click(object sender, EventArgs e)

        {
            
            clear();

            if (string.IsNullOrEmpty(txt_vnumber.Text))
            {
                label01.Text = "Vehicle Number cannot be BLANK";
                label01.Focus();
            }
            else if (!Regex.IsMatch(txt_vnumber.Text, "^(?>[a-zA-Z]{1,3}|(?!0*-)[0-9]{1,3})-[0-9]{4}(?<!0{4})"))
            {
                label01.Text = "Please Enter Valin Vehicle Number";
                label01.Focus();

            }
            
            else
            {
                try
                {
                    string query1 = "update slots Set status = 'Unavailable' where sid = '" + sid + "'";
                    int b = db.save_update_delete(query1);

                    if (b == 1)
                    {


                    }

                }
                catch (Exception)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please Check Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                string query = "insert into vehicle (vehicle_num,start_time) values('"+txt_vnumber.Text+"','"+ txt_timearrived.Text + "')";
                int i = db.save_update_delete(query);
                string Query = "Select max (vehicle_id) from vehicle";
                DataTable dt = db.getData(Query);
                string Query1 = "insert into vehicle_slots values('"+ Convert.ToInt32(dt.Rows[0][0])+ "','" +txt_slotno.Text + "')";
                
                
                int a = db.save_update_delete(Query1);
                if (i == 1 & a==1)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Data save Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     MetroFramework.MetroMessageBox.Show(this, "Welcome to Quick Park", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     this.Hide();
                     new login().Show();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
               

            }

            if (string.IsNullOrEmpty(txt_slotno.Text))
            {
                slot_error.Text = "Slot Number Cannot Be BLANK";
                slot_error.Focus();
            }

        } 

        private void txt_vnumber_Click(object sender, EventArgs e)
        {
            

        }

        private void btn_regback_Click(object sender, EventArgs e)
        {
            Welcome obj54 = new Welcome();
            obj54.Show();
            this.Hide();
        }

        private void reg_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {
            txt_slotno.Text = sid;
            Adddetails();
        }
        private void Adddetails()
        {


        }

        private void txt_datereg_TextChanged(object sender, EventArgs e)
        {

        }
    }    
}