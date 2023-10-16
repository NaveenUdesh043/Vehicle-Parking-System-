
namespace Vehicle_Parking_System
{
    partial class Payment
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_pay = new System.Windows.Forms.Label();
            this.btn_finish = new System.Windows.Forms.Button();
            this.btn_card = new System.Windows.Forms.Button();
            this.btn_cash = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(185, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment Methods";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Vehicle_Parking_System.Properties.Resources._1_0x0_790x520_0x520_bay_parking_guide__1___1_;
            this.panel1.Controls.Add(this.label_pay);
            this.panel1.Controls.Add(this.btn_finish);
            this.panel1.Controls.Add(this.btn_card);
            this.panel1.Controls.Add(this.btn_cash);
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 812);
            this.panel1.TabIndex = 5;
            // 
            // label_pay
            // 
            this.label_pay.AutoSize = true;
            this.label_pay.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_pay.Location = new System.Drawing.Point(279, 585);
            this.label_pay.Name = "label_pay";
            this.label_pay.Size = new System.Drawing.Size(0, 27);
            this.label_pay.TabIndex = 8;
            // 
            // btn_finish
            // 
            this.btn_finish.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finish.ForeColor = System.Drawing.Color.Purple;
            this.btn_finish.Location = new System.Drawing.Point(325, 644);
            this.btn_finish.Name = "btn_finish";
            this.btn_finish.Size = new System.Drawing.Size(144, 72);
            this.btn_finish.TabIndex = 7;
            this.btn_finish.Text = "Done";
            this.btn_finish.UseVisualStyleBackColor = true;
            this.btn_finish.Click += new System.EventHandler(this.btn_finish_Click);
            // 
            // btn_card
            // 
            this.btn_card.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_card.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_card.Location = new System.Drawing.Point(464, 332);
            this.btn_card.Name = "btn_card";
            this.btn_card.Size = new System.Drawing.Size(226, 148);
            this.btn_card.TabIndex = 6;
            this.btn_card.Text = "Card Payments";
            this.btn_card.UseVisualStyleBackColor = false;
            this.btn_card.Click += new System.EventHandler(this.btn_card_Click);
            // 
            // btn_cash
            // 
            this.btn_cash.BackColor = System.Drawing.Color.Navy;
            this.btn_cash.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cash.Location = new System.Drawing.Point(106, 342);
            this.btn_cash.Name = "btn_cash";
            this.btn_cash.Size = new System.Drawing.Size(235, 148);
            this.btn_cash.TabIndex = 5;
            this.btn_cash.Text = "Cash";
            this.btn_cash.UseVisualStyleBackColor = false;
            this.btn_cash.Click += new System.EventHandler(this.btn_cash_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 831);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Payment";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_card;
        private System.Windows.Forms.Button btn_cash;
        private System.Windows.Forms.Button btn_finish;
        private System.Windows.Forms.Label label_pay;
    }
}