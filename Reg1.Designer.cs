
namespace Vehicle_Parking_System
{
    partial class Reg1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reg1));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_type = new System.Windows.Forms.Label();
            this.txt_result = new System.Windows.Forms.RichTextBox();
            this.btn_print = new MetroFramework.Controls.MetroButton();
            this.btn_Generate = new MetroFramework.Controls.MetroButton();
            this.txt_hours = new System.Windows.Forms.TextBox();
            this.label_vno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_regslotno = new System.Windows.Forms.TextBox();
            this.lablel09 = new System.Windows.Forms.Label();
            this.txt_regdate = new System.Windows.Forms.TextBox();
            this.txt_regdep = new System.Windows.Forms.TextBox();
            this.txt_regarrived = new System.Windows.Forms.TextBox();
            this.reg_tot = new System.Windows.Forms.TextBox();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_payments = new MetroFramework.Controls.MetroButton();
            this.btn_cal = new MetroFramework.Controls.MetroButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Vnumber = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Vehicle_Parking_System.Properties.Resources._1_0x0_790x520_0x520_bay_parking_guide__1___2_;
            this.panel1.Controls.Add(this.label_type);
            this.panel1.Controls.Add(this.txt_result);
            this.panel1.Controls.Add(this.btn_print);
            this.panel1.Controls.Add(this.btn_Generate);
            this.panel1.Controls.Add(this.txt_hours);
            this.panel1.Controls.Add(this.label_vno);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_regslotno);
            this.panel1.Controls.Add(this.lablel09);
            this.panel1.Controls.Add(this.txt_regdate);
            this.panel1.Controls.Add(this.txt_regdep);
            this.panel1.Controls.Add(this.txt_regarrived);
            this.panel1.Controls.Add(this.reg_tot);
            this.panel1.Controls.Add(this.cmb_type);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btn_payments);
            this.panel1.Controls.Add(this.btn_cal);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_Vnumber);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-1, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1363, 903);
            this.panel1.TabIndex = 1;
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_type.Location = new System.Drawing.Point(397, 279);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(0, 24);
            this.label_type.TabIndex = 30;
            // 
            // txt_result
            // 
            this.txt_result.BackColor = System.Drawing.Color.Purple;
            this.txt_result.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_result.Location = new System.Drawing.Point(701, 45);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(639, 786);
            this.txt_result.TabIndex = 29;
            this.txt_result.Text = "";
            this.txt_result.TextChanged += new System.EventHandler(this.txt_result_TextChanged_1);
            // 
            // btn_print
            // 
            this.btn_print.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_print.ForeColor = System.Drawing.Color.Purple;
            this.btn_print.Location = new System.Drawing.Point(432, 837);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(141, 54);
            this.btn_print.TabIndex = 27;
            this.btn_print.Text = "Print";
            this.btn_print.UseCustomBackColor = true;
            this.btn_print.UseCustomForeColor = true;
            this.btn_print.UseSelectable = true;
            this.btn_print.UseStyleColors = true;
            this.btn_print.UseWaitCursor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_Generate
            // 
            this.btn_Generate.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_Generate.ForeColor = System.Drawing.Color.Purple;
            this.btn_Generate.Location = new System.Drawing.Point(233, 837);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(141, 54);
            this.btn_Generate.TabIndex = 26;
            this.btn_Generate.Text = "Generate";
            this.btn_Generate.UseCustomBackColor = true;
            this.btn_Generate.UseCustomForeColor = true;
            this.btn_Generate.UseSelectable = true;
            this.btn_Generate.UseStyleColors = true;
            this.btn_Generate.UseWaitCursor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // txt_hours
            // 
            this.txt_hours.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hours.ForeColor = System.Drawing.Color.Purple;
            this.txt_hours.Location = new System.Drawing.Point(397, 570);
            this.txt_hours.Name = "txt_hours";
            this.txt_hours.Size = new System.Drawing.Size(263, 30);
            this.txt_hours.TabIndex = 25;
            this.txt_hours.TextChanged += new System.EventHandler(this.txt_hours_TextChanged);
            // 
            // label_vno
            // 
            this.label_vno.AutoSize = true;
            this.label_vno.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_vno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_vno.Location = new System.Drawing.Point(397, 196);
            this.label_vno.Name = "label_vno";
            this.label_vno.Size = new System.Drawing.Size(0, 24);
            this.label_vno.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(289, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration";
            // 
            // txt_regslotno
            // 
            this.txt_regslotno.AcceptsReturn = true;
            this.txt_regslotno.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_regslotno.Location = new System.Drawing.Point(397, 305);
            this.txt_regslotno.Name = "txt_regslotno";
            this.txt_regslotno.Size = new System.Drawing.Size(263, 30);
            this.txt_regslotno.TabIndex = 23;
            // 
            // lablel09
            // 
            this.lablel09.AutoSize = true;
            this.lablel09.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablel09.ForeColor = System.Drawing.Color.Purple;
            this.lablel09.Location = new System.Drawing.Point(97, 305);
            this.lablel09.Name = "lablel09";
            this.lablel09.Size = new System.Drawing.Size(87, 27);
            this.lablel09.TabIndex = 22;
            this.lablel09.Text = "Slot No";
            // 
            // txt_regdate
            // 
            this.txt_regdate.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_regdate.Location = new System.Drawing.Point(397, 365);
            this.txt_regdate.Name = "txt_regdate";
            this.txt_regdate.Size = new System.Drawing.Size(263, 30);
            this.txt_regdate.TabIndex = 21;
            this.txt_regdate.TextChanged += new System.EventHandler(this.txt_regdate_TextChanged);
            // 
            // txt_regdep
            // 
            this.txt_regdep.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_regdep.Location = new System.Drawing.Point(397, 507);
            this.txt_regdep.Name = "txt_regdep";
            this.txt_regdep.Size = new System.Drawing.Size(263, 30);
            this.txt_regdep.TabIndex = 20;
            // 
            // txt_regarrived
            // 
            this.txt_regarrived.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_regarrived.Location = new System.Drawing.Point(397, 429);
            this.txt_regarrived.Name = "txt_regarrived";
            this.txt_regarrived.Size = new System.Drawing.Size(263, 30);
            this.txt_regarrived.TabIndex = 19;
            // 
            // reg_tot
            // 
            this.reg_tot.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_tot.Location = new System.Drawing.Point(397, 640);
            this.reg_tot.Name = "reg_tot";
            this.reg_tot.Size = new System.Drawing.Size(263, 43);
            this.reg_tot.TabIndex = 18;
            // 
            // cmb_type
            // 
            this.cmb_type.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Items.AddRange(new object[] {
            "Car",
            "Van",
            "Lorry",
            "Bus",
            "Motor Bike"});
            this.cmb_type.Location = new System.Drawing.Point(397, 241);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(263, 35);
            this.cmb_type.TabIndex = 17;
            this.cmb_type.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Purple;
            this.label8.Location = new System.Drawing.Point(97, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 27);
            this.label8.TabIndex = 16;
            this.label8.Text = "Vehicle Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Purple;
            this.label7.Location = new System.Drawing.Point(97, 572);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 27);
            this.label7.TabIndex = 14;
            this.label7.Text = "Hours";
            // 
            // btn_payments
            // 
            this.btn_payments.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_payments.ForeColor = System.Drawing.Color.Purple;
            this.btn_payments.Location = new System.Drawing.Point(620, 837);
            this.btn_payments.Name = "btn_payments";
            this.btn_payments.Size = new System.Drawing.Size(151, 54);
            this.btn_payments.TabIndex = 13;
            this.btn_payments.Text = "Payment Methds";
            this.btn_payments.UseCustomBackColor = true;
            this.btn_payments.UseCustomForeColor = true;
            this.btn_payments.UseSelectable = true;
            this.btn_payments.UseStyleColors = true;
            this.btn_payments.UseWaitCursor = true;
            this.btn_payments.Click += new System.EventHandler(this.btn_payments_Click);
            // 
            // btn_cal
            // 
            this.btn_cal.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_cal.ForeColor = System.Drawing.Color.Purple;
            this.btn_cal.Location = new System.Drawing.Point(32, 837);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(141, 54);
            this.btn_cal.TabIndex = 12;
            this.btn_cal.Text = "Calculate";
            this.btn_cal.UseCustomBackColor = true;
            this.btn_cal.UseCustomForeColor = true;
            this.btn_cal.UseSelectable = true;
            this.btn_cal.UseStyleColors = true;
            this.btn_cal.UseWaitCursor = true;
            this.btn_cal.Click += new System.EventHandler(this.btn_cal_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(97, 651);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 27);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fee";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(97, 507);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "Depature Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(97, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Arrived Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(97, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date";
            // 
            // txt_Vnumber
            // 
            // 
            // 
            // 
            this.txt_Vnumber.CustomButton.Image = null;
            this.txt_Vnumber.CustomButton.Location = new System.Drawing.Point(241, 1);
            this.txt_Vnumber.CustomButton.Name = "";
            this.txt_Vnumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Vnumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Vnumber.CustomButton.TabIndex = 1;
            this.txt_Vnumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Vnumber.CustomButton.UseSelectable = true;
            this.txt_Vnumber.CustomButton.Visible = false;
            this.txt_Vnumber.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_Vnumber.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txt_Vnumber.Lines = new string[0];
            this.txt_Vnumber.Location = new System.Drawing.Point(397, 166);
            this.txt_Vnumber.MaxLength = 32767;
            this.txt_Vnumber.Name = "txt_Vnumber";
            this.txt_Vnumber.PasswordChar = '\0';
            this.txt_Vnumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Vnumber.SelectedText = "";
            this.txt_Vnumber.SelectionLength = 0;
            this.txt_Vnumber.SelectionStart = 0;
            this.txt_Vnumber.Size = new System.Drawing.Size(263, 23);
            this.txt_Vnumber.TabIndex = 3;
            this.txt_Vnumber.UseSelectable = true;
            this.txt_Vnumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Vnumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Vnumber.Click += new System.EventHandler(this.txt_Vnumber_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(97, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vehicle Number";
            // 
            // Reg1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 932);
            this.Controls.Add(this.panel1);
            this.Name = "Reg1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton btn_payments;
        private MetroFramework.Controls.MetroButton btn_cal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox txt_Vnumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox reg_tot;
        private System.Windows.Forms.TextBox txt_regdep;
        private System.Windows.Forms.TextBox txt_regarrived;
        private System.Windows.Forms.TextBox txt_hours;
        private System.Windows.Forms.Label label_vno;
        private System.Windows.Forms.TextBox txt_regslotno;
        private System.Windows.Forms.Label lablel09;
        private System.Windows.Forms.TextBox txt_regdate;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.RichTextBox txt_result;
        private MetroFramework.Controls.MetroButton btn_print;
        private MetroFramework.Controls.MetroButton btn_Generate;
        private System.Windows.Forms.Label label_type;
    }
}