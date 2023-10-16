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
using System.IO;



namespace Vehicle_Parking_System
{
    public partial class Car : MetroFramework.Forms.MetroForm
    {
        public Car()
        {
            InitializeComponent();

        }
        database db = new database();
        

        private void clear()
        {

            lable_car.Text = "";


        }



        private void btn_car2_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrEmpty(cmb_car.Text))
            {
                lable_car.Text = "Please Select a Slot";
                lable_car.Focus();
            }
            
            else
            {
                Registration.sid = cmb_car.SelectedItem.ToString();

                MessageBox.Show(this, "Data save Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 Registration obj6 = new Registration();
                obj6.Show();
                this.Hide();

            }
           
        }

        private void btn_car1_Click(object sender, EventArgs e)
        {
            

            Welcome obj11 = new Welcome();
            obj11.Show();
            this.Hide();




        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Car_Load(object sender, EventArgs e)
        {
            Adddetails();
           
        }
        private void Adddetails()
        {
            string Query = "Select sid from slots where status = 'Available' and sid like 'A%'";
            
            DataTable dt = Data.getData(Query);
            if (dt.Rows.Count > 0) 
            {
                for (int c = 0; c < (dt.Rows.Count); c++)
                {
                    cmb_car.Items.Add(dt.Rows[c][0].ToString());
                }
            }
        }
        database Data  = new database();

        private void cmb_car_MouseClick(object sender, MouseEventArgs e)
        {
            clear();
        }
    }


}


        
    

