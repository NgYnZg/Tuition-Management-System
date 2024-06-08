namespace Lecturer
{
    partial class L_Delete
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.cb_Name = new System.Windows.Forms.ComboBox();
            this.btn_del1 = new System.Windows.Forms.Button();
            this.gb_del = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.gb_del.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(126, 95);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(53, 21);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name";
            // 
            // cb_Name
            // 
            this.cb_Name.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Name.FormattingEnabled = true;
            this.cb_Name.Location = new System.Drawing.Point(233, 89);
            this.cb_Name.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Name.Name = "cb_Name";
            this.cb_Name.Size = new System.Drawing.Size(160, 27);
            this.cb_Name.TabIndex = 1;
            this.cb_Name.SelectedIndexChanged += new System.EventHandler(this.cb_Name_SelectedIndexChanged);
            // 
            // btn_del1
            // 
            this.btn_del1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del1.Location = new System.Drawing.Point(204, 201);
            this.btn_del1.Margin = new System.Windows.Forms.Padding(4);
            this.btn_del1.Name = "btn_del1";
            this.btn_del1.Size = new System.Drawing.Size(107, 41);
            this.btn_del1.TabIndex = 2;
            this.btn_del1.Text = "Delete";
            this.btn_del1.UseVisualStyleBackColor = true;
            this.btn_del1.Click += new System.EventHandler(this.btn_del1_Click);
            // 
            // gb_del
            // 
            this.gb_del.Controls.Add(this.lbl_name);
            this.gb_del.Controls.Add(this.btn_del1);
            this.gb_del.Controls.Add(this.cb_Name);
            this.gb_del.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_del.Location = new System.Drawing.Point(138, 45);
            this.gb_del.Margin = new System.Windows.Forms.Padding(4);
            this.gb_del.Name = "gb_del";
            this.gb_del.Padding = new System.Windows.Forms.Padding(4);
            this.gb_del.Size = new System.Drawing.Size(517, 287);
            this.gb_del.TabIndex = 3;
            this.gb_del.TabStop = false;
            this.gb_del.Text = "Student to Delete";
            this.gb_del.Enter += new System.EventHandler(this.gb_del_Enter);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(342, 369);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(107, 37);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
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
            // L_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.gb_del);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "L_Delete";
            this.Text = "Delete";
            this.Load += new System.EventHandler(this.Delete_Load);
            this.gb_del.ResumeLayout(false);
            this.gb_del.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.ComboBox cb_Name;
        private System.Windows.Forms.Button btn_del1;
        private System.Windows.Forms.GroupBox gb_del;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button button6;
    }
}