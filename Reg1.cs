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
    public partial class Reg1 : MetroFramework.Forms.MetroForm
    {
        public Reg1()
        {
            InitializeComponent();
            txt_regdate.Text = DateTime.Now.ToShortDateString();
            txt_regdep.Text = DateTime.Now.ToShortTimeString();
        }
        private void clear()
        {

            label_vno.Text = "";
            label_type.Text = "";


        }
        database db = new database();

        private void btn_cal_Click(object sender, EventArgs e)
        {
            clear();

            if (string.IsNullOrEmpty(txt_Vnumber.Text))
            {
                label_vno.Text = "Vehicle number cannot be BLANK";
                label_vno.Focus();
            }
            else if(string.IsNullOrEmpty(cmb_type.Text))
            {
               label_type.Text = "Please Select Vehicle Type";
               label_type.Focus();
            }
            string Query = "Select sno,start_time from vehicle,vehicle_slots where vehicle.vehicle_id = vehicle_slots.vid and vehicle_num ='"+ txt_Vnumber.Text+ "' order by vehicle_id DESC";
            DataTable dt = db.getData(Query);
            txt_regslotno.Text = dt.Rows[0][0].ToString();
            txt_regarrived.Text = dt.Rows[0][1].ToString();
            (txt_hours.Text) = ((Convert.ToDateTime(txt_regdep.Text).Hour - Convert.ToDateTime(txt_regarrived.Text).Hour).ToString());
     
            double carprice, vanprice, lorryprice, busprice, bikeprice, hours;
            hours = Convert.ToDouble(txt_hours.Text); 
            if (cmb_type.SelectedIndex == 0)
            {
                if (hours <= 3.50)
                {
                    carprice = 100;
                    reg_tot.Text = carprice.ToString();
                    reg_tot.Text = carprice.ToString("Rs. ");


                }
                else if (hours > 3.50)
                {
                    carprice = 100 + (hours * 20);
                   reg_tot.Text = carprice.ToString();
                    reg_tot.Text = carprice.ToString("Rs. ");
                }
            }
            if (cmb_type.SelectedIndex == 1)
            {
                if (hours <= 3.50)
                {
                    vanprice = 100;
                    reg_tot.Text = vanprice.ToString();
                    reg_tot.Text = vanprice.ToString("Rs. ");
                }
                else if (hours > 3.50)
                {
                    vanprice = 100 + (hours * 20);
                    reg_tot.Text = vanprice.ToString();
                    reg_tot.Text = vanprice.ToString("Rs. ");
                }
            }
            if (cmb_type.SelectedIndex == 2)
            {
                if (hours <= 3.50)
                {
                    lorryprice = 150;
                   reg_tot.Text = lorryprice.ToString();
                    reg_tot.Text = lorryprice.ToString("Rs. ");
                }
                else if (hours > 3.50)
                {
                    lorryprice = 150 + (hours * 30);
                    reg_tot.Text = lorryprice.ToString();
                    reg_tot.Text = lorryprice.ToString("Rs. ");
                }
            }
            if (cmb_type.SelectedIndex == 3)
            {
                if (hours <= 3.50)
                {
                    busprice = 120;
                    reg_tot.Text = busprice.ToString();
                    reg_tot.Text = busprice.ToString("Rs.");
                    
                }
                else if (hours > 3.50)
                {
                    busprice = 120 + (hours * 30);
                    reg_tot.Text = busprice.ToString();
                    reg_tot.Text = busprice.ToString("Rs.");
                }
            }
            if (cmb_type.SelectedIndex == 4)
            {
                if (hours <= 3.50)
                {
                    bikeprice = 60;
                    reg_tot.Text = bikeprice.ToString();
                    reg_tot.Text = bikeprice.ToString("Rs.");
                }
                else if (hours > 3.50)
                {
                    bikeprice = 60 + (hours * 20);
                    reg_tot.Text = bikeprice.ToString();
                    reg_tot.Text = bikeprice.ToString("Rs.");
                }
            }
            


        }

        private void btn_payments_Click(object sender, EventArgs e)
        {

            Payment obj50 = new Payment();
            obj50.Show();
            this.Hide();

            txt_Vnumber.Text = "";
            txt_regslotno.Text = "";
            txt_regdate.Text = "";
            txt_regarrived.Text = "";
            txt_regdep.Text = "";
            txt_hours.Text = "";
            reg_tot.Text = "";
            
            try
            {
                string query = "update slots Set status = 'Available' where sid = '" + Registration.sid + "'";
                int i = db.save_update_delete(query);

                if (i == 1)
                {
                    MessageBox.Show(this, "Data save Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Data Cannot Save "+txt_regslotno.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please Check Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            txt_result.Clear();
            txt_result.Text += "**************************************************\n";
            txt_result.Text += "****           Payment Receipt             ****\n";
            txt_result.Text += "**************************************************\n";
            txt_result.Text += " Vehcle Number : "+ txt_Vnumber.Text +"\n\n";
            txt_result.Text += " Vehcle Type : " + cmb_type.Text + "\n\n";
            txt_result.Text += " Slot Number : " + txt_regslotno.Text + "\n\n";
            txt_result.Text += " Date : " + DateTime.Now.ToShortDateString(); 
            txt_result.Text += "\n\n Arrived Time : " + txt_regarrived.Text + "\n\n";
            txt_result.Text += " Depature Time : " + txt_regdep.Text + "\n\n";
            txt_result.Text += " Hours : " + txt_hours.Text + "\n\n";
            txt_result.Text += " Fee : " + reg_tot.Text + "\n\n";

            txt_result.Text += "\n                            Signature";




        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txt_result.Text, new Font("Microdoft Sans Serif", 18, FontStyle.Bold), Brushes.Black, new Point(10, 10));

        }

        private void txt_Vnumber_Click(object sender, EventArgs e)
        {
           
        }

        private void txt_result_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_hours_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_regdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_result_TextChanged_1(object sender, EventArgs e)
        {

        }
    }

}
