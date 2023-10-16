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
    public partial class Payment : MetroFramework.Forms.MetroForm
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void btn_finish_Click(object sender, EventArgs e)
        {


            gateway obj81 = new gateway();
            obj81.Show();
            this.Hide();

        }

        private void btn_cash_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Please pay to the Counter");
        }

        private void btn_card_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Pay using your bank card at the counter");
        }
    }
}
