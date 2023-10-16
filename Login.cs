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
    public partial class login : MetroFramework.Forms.MetroForm
    {
        public login()
        {
            InitializeComponent();
        }
        database db = new database();

        private void Clear()
        {
            label_05.Text = "";
            label_033.Text = "";
            label_055.Text = "";
        }


            private void Signup_Load(object sender, EventArgs e)
            {
              label_033.Visible = false;
            }

        private void btn_login1_Click(object sender, EventArgs e)
        {
            Clear();

           if (string.IsNullOrEmpty(txt_username1.Text))
           {
                label_055.Text = "Username Cannot be BLANK";
                label_055.Focus();
           }
            

            else
            {
               string Quarry = "Select count(*) from worker where user_name COLLATE Latin1_General_CS_AS  ='" + txt_username1.Text + "' and password COLLATE Latin1_General_CS_AS ='" + txt_password.Text + "'";
               int c = db.CheckLogin(Quarry);
               if (c == 0)
               {

                    
                Reg1 obj87 = new Reg1();
                obj87.Show();
                this.Hide();

               }
               else
               {
                txt_username1.Focus();
                label_033.Text = "Invalid username or password!";
                label_033.Visible = true;
               }
            }



            if (string.IsNullOrEmpty(txt_password.Text))
            {

                label_05.Text = "Password Cannot be BLANK";
                label_05.Focus();
            }



        }

        private void btn_signup1_Click(object sender, EventArgs e)
        {
            
            {
                Signup obj21 = new Signup();
                obj21.Show();
                this.Hide();
            }
        }

        

        private void btn_check_Click(object sender, EventArgs e)
        {
            if (txt_password.UseSystemPasswordChar)
            {
                btn_check.Text = "Hide Password";
                txt_password.UseSystemPasswordChar = false;
            }
            else 
            {
                btn_check.Text = "Show Password";
                txt_password.UseSystemPasswordChar = true;
            }

        }
    }
}
