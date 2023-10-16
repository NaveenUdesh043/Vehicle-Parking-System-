using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle_Parking_System
{
    public partial class Welcome : MetroFramework.Forms.MetroForm
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Car obj1 = new Car();
            obj1.Show();
            this.Hide();
            
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Van obj2 = new Van();
            obj2.Show();
            this.Hide();
           
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Lorry obj3 = new Lorry();
            obj3.Show();
            this.Hide();
            
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Bus obj4 = new Bus();
            obj4.Show();
            this.Hide();
            
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            Mbike obj5 = new Mbike();
            obj5.Show();
            this.Hide();
            
        }

      
    }
}
