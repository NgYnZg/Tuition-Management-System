namespace Lecturer
{
    partial class L_Requests
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
            this.lbl_requests = new System.Windows.Forms.Label();
            this.cb_requests = new System.Windows.Forms.ComboBox();
            this.btn_check = new System.Windows.Forms.Button();
            this.gb_req = new System.Windows.Forms.GroupBox();
            this.lbl_detail1 = new System.Windows.Forms.Label();
            this.lbl_detail2 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_appr = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.gb_req.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_requests
            // 
            this.lbl_requests.AutoSize = true;
            this.lbl_requests.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_requests.Location = new System.Drawing.Point(38, 59);
            this.lbl_requests.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_requests.Name = "lbl_requests";
            this.lbl_requests.Size = new System.Drawing.Size(81, 22);
            this.lbl_requests.TabIndex = 0;
            this.lbl_requests.Text = "Requests";
            // 
            // cb_requests
            // 
            this.cb_requests.FormattingEnabled = true;
            this.cb_requests.Location = new System.Drawing.Point(161, 48);
            this.cb_requests.Margin = new System.Windows.Forms.Padding(4);
            this.cb_requests.Name = "cb_requests";
            this.cb_requests.Size = new System.Drawing.Size(182, 31);
            this.cb_requests.TabIndex = 1;
            this.cb_requests.SelectedIndexChanged += new System.EventHandler(this.cb_requests_SelectedIndexChanged);
            // 
            // btn_check
            // 
            this.btn_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_check.Location = new System.Drawing.Point(230, 126);
            this.btn_check.Margin = new System.Windows.Forms.Padding(4);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(113, 36);
            this.btn_check.TabIndex = 2;
            this.btn_check.Text = "Check";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // gb_req
            // 
            this.gb_req.Controls.Add(this.lbl_requests);
            this.gb_req.Controls.Add(this.btn_check);
            this.gb_req.Controls.Add(this.cb_requests);
            this.gb_req.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_req.Location = new System.Drawing.Point(51, 37);
            this.gb_req.Margin = new System.Windows.Forms.Padding(4);
            this.gb_req.Name = "gb_req";
            this.gb_req.Padding = new System.Windows.Forms.Padding(4);
            this.gb_req.Size = new System.Drawing.Size(390, 270);
            this.gb_req.TabIndex = 3;
            this.gb_req.TabStop = false;
            this.gb_req.Text = "List of Requests";
            // 
            // lbl_detail1
            // 
            this.lbl_detail1.AutoSize = true;
            this.lbl_detail1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_detail1.Location = new System.Drawing.Point(16, 12);
            this.lbl_detail1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_detail1.Name = "lbl_detail1";
            this.lbl_detail1.Size = new System.Drawing.Size(70, 22);
            this.lbl_detail1.TabIndex = 4;
            this.lbl_detail1.Text = "Detail :";
            // 
            // lbl_detail2
            // 
            this.lbl_detail2.AutoSize = true;
            this.lbl_detail2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_detail2.Location = new System.Drawing.Point(16, 43);
            this.lbl_detail2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_detail2.Name = "lbl_detail2";
            this.lbl_detail2.Size = new System.Drawing.Size(60, 22);
            this.lbl_detail2.TabIndex = 5;
            this.lbl_detail2.Text = "label1";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(71, 327);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(113, 41);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_appr
            // 
            this.btn_appr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_appr.Location = new System.Drawing.Point(281, 327);
            this.btn_appr.Margin = new System.Windows.Forms.Padding(4);
            this.btn_appr.Name = "btn_appr";
            this.btn_appr.Size = new System.Drawing.Size(113, 41);
            this.btn_appr.TabIndex = 7;
            this.btn_appr.Text = "Approve";
            this.btn_appr.UseVisualStyleBackColor = true;
            this.btn_appr.Click += new System.EventHandler(this.btn_appr_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.lbl_detail2);
            this.panel1.Controls.Add(this.lbl_detail1);
            this.panel1.Location = new System.Drawing.Point(493, 53);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 146);
            this.panel1.TabIndex = 8;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(727, 411);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(62, 28);
            this.button6.TabIndex = 9;
            this.button6.Text = "Exit";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // L_Requests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_appr);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.gb_req);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "L_Requests";
            this.Text = "Requests";
            this.Load += new System.EventHandler(this.L_Requests_Load);
            this.gb_req.ResumeLayout(false);
            this.gb_req.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_requests;
        private System.Windows.Forms.ComboBox cb_requests;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.GroupBox gb_req;
        private System.Windows.Forms.Label lbl_detail1;
        private System.Windows.Forms.Label lbl_detail2;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_appr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
    }
}