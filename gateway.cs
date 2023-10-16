using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle_Parking_System
{
    public partial class gateway : Form
    {
        public gateway()
        {
            InitializeComponent();
        }
        

        private void btn_send_Click(object sender, EventArgs e)
        {
            try
            {
                SerialPort sp = new SerialPort();
                sp.PortName = txt_port.Text;
                sp.Open();
                sp.WriteLine("AT" + Environment.NewLine);
                Thread.Sleep(100);
                sp.WriteLine("AT+CMGF=1" + Environment.NewLine);
                Thread.Sleep(100);
                sp.WriteLine("AT+CMGS=\"GSM\"" + Environment.NewLine);
                Thread.Sleep(100);
                sp.WriteLine("AT+CMGS=\"" + txt_tp.Text + "\"" + Environment.NewLine);
                Thread.Sleep(100);
                sp.WriteLine(txt_message.Text + Environment.NewLine);
                Thread.Sleep(100);
                sp.Write(new byte[] { 26 }, 0, 1);
                Thread.Sleep(100);
                var response = sp.ReadExisting();
                if (response.Contains("ERROR"))
                    MessageBox.Show("Send Failed !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("SMS Sent !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                     Welcome obj83 = new Welcome();
                     obj83.Show();
              
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
