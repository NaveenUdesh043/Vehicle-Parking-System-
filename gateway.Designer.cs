
namespace Vehicle_Parking_System
{
    partial class gateway
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
            this.label_tp = new System.Windows.Forms.Label();
            this.txt_tp = new System.Windows.Forms.TextBox();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.label_port = new System.Windows.Forms.Label();
            this.txt_message = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_tp
            // 
            this.label_tp.AutoSize = true;
            this.label_tp.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tp.Location = new System.Drawing.Point(32, 83);
            this.label_tp.Name = "label_tp";
            this.label_tp.Size = new System.Drawing.Size(115, 19);
            this.label_tp.TabIndex = 0;
            this.label_tp.Text = "Phone Number";
            // 
            // txt_tp
            // 
            this.txt_tp.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tp.Location = new System.Drawing.Point(208, 83);
            this.txt_tp.Name = "txt_tp";
            this.txt_tp.Size = new System.Drawing.Size(203, 25);
            this.txt_tp.TabIndex = 1;
            // 
            // txt_port
            // 
            this.txt_port.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_port.Location = new System.Drawing.Point(659, 83);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(203, 25);
            this.txt_port.TabIndex = 3;
            // 
            // label_port
            // 
            this.label_port.AutoSize = true;
            this.label_port.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_port.Location = new System.Drawing.Point(555, 83);
            this.label_port.Name = "label_port";
            this.label_port.Size = new System.Drawing.Size(47, 19);
            this.label_port.TabIndex = 2;
            this.label_port.Text = "Port :";
            // 
            // txt_message
            // 
            this.txt_message.Location = new System.Drawing.Point(208, 144);
            this.txt_message.Multiline = true;
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(654, 428);
            this.txt_message.TabIndex = 4;
            // 
            // btn_send
            // 
            this.btn_send.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.Location = new System.Drawing.Point(729, 620);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(133, 52);
            this.btn_send.TabIndex = 5;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // gateway
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 763);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txt_message);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.label_port);
            this.Controls.Add(this.txt_tp);
            this.Controls.Add(this.label_tp);
            this.Name = "gateway";
            this.Text = "gateway";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_tp;
        private System.Windows.Forms.TextBox txt_tp;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.Label label_port;
        private System.Windows.Forms.TextBox txt_message;
        private System.Windows.Forms.Button btn_send;
    }
}