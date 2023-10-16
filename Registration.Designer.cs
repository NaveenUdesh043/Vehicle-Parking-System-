
namespace Vehicle_Parking_System
{
    partial class Registration
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
            this.label1 = new System.Windows.Forms.Label();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_vnumber = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.Arrival_label = new MetroFramework.Controls.MetroLabel();
            this.btn_reg = new MetroFramework.Controls.MetroButton();
            this.label01 = new System.Windows.Forms.Label();
            this.Date_label = new MetroFramework.Controls.MetroLabel();
            this.Time_label = new MetroFramework.Controls.MetroLabel();
            this.reg_panel = new System.Windows.Forms.Panel();
            this.slot_error = new System.Windows.Forms.Label();
            this.label_slots = new System.Windows.Forms.Label();
            this.txt_timearrived = new System.Windows.Forms.TextBox();
            this.txt_datereg = new System.Windows.Forms.TextBox();
            this.btn_regback = new MetroFramework.Controls.MetroButton();
            this.txt_slotno = new MetroFramework.Controls.MetroTextBox();
            this.Slot_label = new MetroFramework.Controls.MetroLabel();
            this.reg_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(364, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.Purple;
            this.metroLabel1.Location = new System.Drawing.Point(139, 307);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(153, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Vehicle Number";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            this.metroLabel1.UseWaitCursor = true;
            this.metroLabel1.WrapToLine = true;
            // 
            // txt_vnumber
            // 
            // 
            // 
            // 
            this.txt_vnumber.CustomButton.Image = null;
            this.txt_vnumber.CustomButton.Location = new System.Drawing.Point(249, 1);
            this.txt_vnumber.CustomButton.Name = "";
            this.txt_vnumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_vnumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_vnumber.CustomButton.TabIndex = 1;
            this.txt_vnumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_vnumber.CustomButton.UseSelectable = true;
            this.txt_vnumber.CustomButton.Visible = false;
            this.txt_vnumber.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_vnumber.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txt_vnumber.Lines = new string[0];
            this.txt_vnumber.Location = new System.Drawing.Point(511, 307);
            this.txt_vnumber.MaxLength = 32767;
            this.txt_vnumber.Name = "txt_vnumber";
            this.txt_vnumber.PasswordChar = '\0';
            this.txt_vnumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_vnumber.SelectedText = "";
            this.txt_vnumber.SelectionLength = 0;
            this.txt_vnumber.SelectionStart = 0;
            this.txt_vnumber.Size = new System.Drawing.Size(271, 23);
            this.txt_vnumber.TabIndex = 2;
            this.txt_vnumber.UseSelectable = true;
            this.txt_vnumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_vnumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_vnumber.Click += new System.EventHandler(this.txt_vnumber_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.Color.Purple;
            this.metroLabel2.Location = new System.Drawing.Point(140, 373);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(53, 25);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Date";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            this.metroLabel2.UseStyleColors = true;
            this.metroLabel2.UseWaitCursor = true;
            this.metroLabel2.WrapToLine = true;
            // 
            // Arrival_label
            // 
            this.Arrival_label.AutoSize = true;
            this.Arrival_label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Arrival_label.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Arrival_label.ForeColor = System.Drawing.Color.Purple;
            this.Arrival_label.Location = new System.Drawing.Point(139, 502);
            this.Arrival_label.Name = "Arrival_label";
            this.Arrival_label.Size = new System.Drawing.Size(119, 25);
            this.Arrival_label.TabIndex = 4;
            this.Arrival_label.Text = "Arrival Time";
            this.Arrival_label.UseCustomBackColor = true;
            this.Arrival_label.UseCustomForeColor = true;
            this.Arrival_label.UseStyleColors = true;
            this.Arrival_label.UseWaitCursor = true;
            this.Arrival_label.WrapToLine = true;
            // 
            // btn_reg
            // 
            this.btn_reg.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_reg.ForeColor = System.Drawing.Color.Purple;
            this.btn_reg.Location = new System.Drawing.Point(551, 692);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(99, 56);
            this.btn_reg.TabIndex = 7;
            this.btn_reg.Text = "Done";
            this.btn_reg.UseCustomBackColor = true;
            this.btn_reg.UseCustomForeColor = true;
            this.btn_reg.UseSelectable = true;
            this.btn_reg.UseStyleColors = true;
            this.btn_reg.UseWaitCursor = true;
            this.btn_reg.Click += new System.EventHandler(this.btn_reg_Click);
            // 
            // label01
            // 
            this.label01.AutoSize = true;
            this.label01.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label01.ForeColor = System.Drawing.Color.Red;
            this.label01.Location = new System.Drawing.Point(514, 337);
            this.label01.Name = "label01";
            this.label01.Size = new System.Drawing.Size(0, 20);
            this.label01.TabIndex = 8;
            // 
            // Date_label
            // 
            this.Date_label.AutoSize = true;
            this.Date_label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Date_label.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Date_label.Location = new System.Drawing.Point(518, 410);
            this.Date_label.Name = "Date_label";
            this.Date_label.Size = new System.Drawing.Size(0, 0);
            this.Date_label.TabIndex = 9;
            this.Date_label.UseCustomBackColor = true;
            this.Date_label.UseCustomForeColor = true;
            this.Date_label.UseStyleColors = true;
            this.Date_label.UseWaitCursor = true;
            this.Date_label.WrapToLine = true;
            // 
            // Time_label
            // 
            this.Time_label.AutoSize = true;
            this.Time_label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Time_label.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Time_label.Location = new System.Drawing.Point(514, 502);
            this.Time_label.Name = "Time_label";
            this.Time_label.Size = new System.Drawing.Size(0, 0);
            this.Time_label.TabIndex = 10;
            this.Time_label.UseCustomBackColor = true;
            this.Time_label.UseCustomForeColor = true;
            this.Time_label.UseStyleColors = true;
            this.Time_label.UseWaitCursor = true;
            this.Time_label.WrapToLine = true;
            // 
            // reg_panel
            // 
            this.reg_panel.BackgroundImage = global::Vehicle_Parking_System.Properties.Resources._1_0x0_790x520_0x520_bay_parking_guide__1___1_;
            this.reg_panel.Controls.Add(this.slot_error);
            this.reg_panel.Controls.Add(this.label_slots);
            this.reg_panel.Controls.Add(this.txt_timearrived);
            this.reg_panel.Controls.Add(this.txt_datereg);
            this.reg_panel.Controls.Add(this.btn_regback);
            this.reg_panel.Controls.Add(this.txt_slotno);
            this.reg_panel.Controls.Add(this.Slot_label);
            this.reg_panel.Controls.Add(this.btn_reg);
            this.reg_panel.Controls.Add(this.metroLabel2);
            this.reg_panel.Controls.Add(this.label1);
            this.reg_panel.Location = new System.Drawing.Point(-1, 37);
            this.reg_panel.Name = "reg_panel";
            this.reg_panel.Size = new System.Drawing.Size(989, 811);
            this.reg_panel.TabIndex = 11;
            this.reg_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.reg_panel_Paint);
            // 
            // slot_error
            // 
            this.slot_error.AutoSize = true;
            this.slot_error.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slot_error.ForeColor = System.Drawing.Color.Red;
            this.slot_error.Location = new System.Drawing.Point(509, 616);
            this.slot_error.Name = "slot_error";
            this.slot_error.Size = new System.Drawing.Size(0, 24);
            this.slot_error.TabIndex = 14;
            // 
            // label_slots
            // 
            this.label_slots.AutoSize = true;
            this.label_slots.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_slots.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_slots.Location = new System.Drawing.Point(515, 616);
            this.label_slots.Name = "label_slots";
            this.label_slots.Size = new System.Drawing.Size(0, 24);
            this.label_slots.TabIndex = 13;
            // 
            // txt_timearrived
            // 
            this.txt_timearrived.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timearrived.Location = new System.Drawing.Point(512, 465);
            this.txt_timearrived.Name = "txt_timearrived";
            this.txt_timearrived.Size = new System.Drawing.Size(271, 30);
            this.txt_timearrived.TabIndex = 12;
            // 
            // txt_datereg
            // 
            this.txt_datereg.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_datereg.Location = new System.Drawing.Point(512, 375);
            this.txt_datereg.Name = "txt_datereg";
            this.txt_datereg.Size = new System.Drawing.Size(271, 30);
            this.txt_datereg.TabIndex = 11;
            this.txt_datereg.TextChanged += new System.EventHandler(this.txt_datereg_TextChanged);
            // 
            // btn_regback
            // 
            this.btn_regback.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_regback.ForeColor = System.Drawing.Color.Purple;
            this.btn_regback.Location = new System.Drawing.Point(246, 692);
            this.btn_regback.Name = "btn_regback";
            this.btn_regback.Size = new System.Drawing.Size(99, 56);
            this.btn_regback.TabIndex = 10;
            this.btn_regback.Text = "<< Back";
            this.btn_regback.UseCustomBackColor = true;
            this.btn_regback.UseCustomForeColor = true;
            this.btn_regback.UseSelectable = true;
            this.btn_regback.UseStyleColors = true;
            this.btn_regback.UseWaitCursor = true;
            this.btn_regback.Click += new System.EventHandler(this.btn_regback_Click);
            // 
            // txt_slotno
            // 
            // 
            // 
            // 
            this.txt_slotno.CustomButton.Image = null;
            this.txt_slotno.CustomButton.Location = new System.Drawing.Point(249, 1);
            this.txt_slotno.CustomButton.Name = "";
            this.txt_slotno.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_slotno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_slotno.CustomButton.TabIndex = 1;
            this.txt_slotno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_slotno.CustomButton.UseSelectable = true;
            this.txt_slotno.CustomButton.Visible = false;
            this.txt_slotno.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_slotno.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txt_slotno.Lines = new string[0];
            this.txt_slotno.Location = new System.Drawing.Point(512, 571);
            this.txt_slotno.MaxLength = 32767;
            this.txt_slotno.Name = "txt_slotno";
            this.txt_slotno.PasswordChar = '\0';
            this.txt_slotno.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_slotno.SelectedText = "";
            this.txt_slotno.SelectionLength = 0;
            this.txt_slotno.SelectionStart = 0;
            this.txt_slotno.Size = new System.Drawing.Size(271, 23);
            this.txt_slotno.TabIndex = 9;
            this.txt_slotno.UseSelectable = true;
            this.txt_slotno.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_slotno.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Slot_label
            // 
            this.Slot_label.AutoSize = true;
            this.Slot_label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Slot_label.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Slot_label.ForeColor = System.Drawing.Color.Purple;
            this.Slot_label.Location = new System.Drawing.Point(140, 569);
            this.Slot_label.Name = "Slot_label";
            this.Slot_label.Size = new System.Drawing.Size(126, 25);
            this.Slot_label.TabIndex = 8;
            this.Slot_label.Text = "Slot Number";
            this.Slot_label.UseCustomBackColor = true;
            this.Slot_label.UseCustomForeColor = true;
            this.Slot_label.UseStyleColors = true;
            this.Slot_label.UseWaitCursor = true;
            this.Slot_label.WrapToLine = true;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vehicle_Parking_System.Properties.Resources.car_parking__1___1_6;
            this.ClientSize = new System.Drawing.Size(989, 835);
            this.Controls.Add(this.Time_label);
            this.Controls.Add(this.Date_label);
            this.Controls.Add(this.label01);
            this.Controls.Add(this.Arrival_label);
            this.Controls.Add(this.txt_vnumber);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.reg_panel);
            this.Name = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.reg_panel.ResumeLayout(false);
            this.reg_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_vnumber;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel Arrival_label;
        private MetroFramework.Controls.MetroButton btn_reg;
        private System.Windows.Forms.Label label01;
        private MetroFramework.Controls.MetroLabel Date_label;
        private MetroFramework.Controls.MetroLabel Time_label;
        private System.Windows.Forms.Panel reg_panel;
        private MetroFramework.Controls.MetroLabel Slot_label;
        private MetroFramework.Controls.MetroTextBox txt_slotno;
        private MetroFramework.Controls.MetroButton btn_regback;
        private System.Windows.Forms.TextBox txt_timearrived;
        private System.Windows.Forms.TextBox txt_datereg;
        private System.Windows.Forms.Label label_slots;
        private System.Windows.Forms.Label slot_error;
    }
}