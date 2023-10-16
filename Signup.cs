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
    public partial class Signup : MetroFramework.Forms.MetroForm
    {
        public Signup()
        {
            InitializeComponent();
        }
        database db = new database();
        private void clear()
        {
            label_008.Text = "";
            label_007.Text = "";
            label_0011.Text = "";

        }


        private void btn_Signup1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_username.Text))
            {
                label_007.Text = "Username cannot be BLANK";
                label_007.Focus();


            }



            else if (!Regex.IsMatch(txt_pass.Text, @"^(?=.*)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$"))
            {
                label_008.Text = "Enter Valid Password      Eg: Naveen!043";

                label_008.Focus();
            }
            else if (txt_pass.Text != txt_compass.Text)
            {
                MessageBox.Show(this, "Passwords does not match, Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txt_pass.Clear();
                txt_compass.Clear();
                txt_pass.Focus();

            }
            else if (string.IsNullOrEmpty(txt_pass.Text))
            {
                label_0011.Text = "Password Cannot be Blank";
                label_0011.Focus();


            }
            else
            {
                try
                {
                    //string Query = "Select max (wid)from worker";
                    //lathaDataTable dt = db.getData(Query);
                    string query = "insert into worker values('"+ txt_username.Text + "','" + txt_compass.Text + "')";

                    int i = db.save_update_delete(query);
                    if (i == 1)
                    {

                        MessageBox.Show(this, "Successfully Registered", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Reg1 obj94 = new Reg1();
                        obj94.Show();
                        this.Hide();

                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           

            

        }

        private void btn_back2_Click(object sender, EventArgs e)
        {
           
                login obj24 = new login();
                obj24.Show();
                this.Hide();
            
        }

        
        private void txt_compass_Click(object sender, EventArgs e)
        {
            
           
        }


       
        private void btn_pass_Click(object sender, EventArgs e)
        {
            if (txt_pass.UseSystemPasswordChar)
            {
                btn_pass.Text = "Hide Password";
                txt_pass.UseSystemPasswordChar = false;
            }
            else
            {
                btn_pass.Text = "Show Password";
                txt_pass.UseSystemPasswordChar = true;
            }
        }

        private void btn_compass_Click(object sender, EventArgs e)
        {
            if (txt_compass.UseSystemPasswordChar)
            {
                btn_compass.Text = "Hide Password";
                txt_compass.UseSystemPasswordChar = false;
            }
            else
            {   btn_compass.Text = "Show Password";
                txt_compass.UseSystemPasswordChar = true;
            }
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_pass_MouseClick(object sender, MouseEventArgs e)
        {
            clear();
        }
    }
}
