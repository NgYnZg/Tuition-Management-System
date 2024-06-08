namespace Lecturer
{
    partial class L_UpdateEn
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
            this.cb_Name = new System.Windows.Forms.ComboBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.gb_Update = new System.Windows.Forms.GroupBox();
            this.lbl_NewModule = new System.Windows.Forms.Label();
            this.lvl_Newlvl = new System.Windows.Forms.Label();
            this.cb_module = new System.Windows.Forms.ComboBox();
            this.cb_level = new System.Windows.Forms.ComboBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_classsid = new System.Windows.Forms.Label();
            this.cb_ID = new System.Windows.Forms.ComboBox();
            this.btn_check = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.gb_Update.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_Name
            // 
            this.cb_Name.FormattingEnabled = true;
            this.cb_Name.Location = new System.Drawing.Point(205, 97);
            this.cb_Name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cb_Name.Name = "cb_Name";
            this.cb_Name.Size = new System.Drawing.Size(140, 27);
            this.cb_Name.TabIndex = 0;
            this.cb_Name.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(69, 102);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(119, 22);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Student Name";
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(631, 319);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(88, 27);
            this.btn_Update.TabIndex = 2;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // gb_Update
            // 
            this.gb_Update.Controls.Add(this.lbl_NewModule);
            this.gb_Update.Controls.Add(this.lvl_Newlvl);
            this.gb_Update.Controls.Add(this.cb_module);
            this.gb_Update.Controls.Add(this.cb_level);
            this.gb_Update.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Update.Location = new System.Drawing.Point(417, 80);
            this.gb_Update.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gb_Update.Name = "gb_Update";
            this.gb_Update.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gb_Update.Size = new System.Drawing.Size(336, 204);
            this.gb_Update.TabIndex = 3;
            this.gb_Update.TabStop = false;
            this.gb_Update.Text = "Update";
            this.gb_Update.Enter += new System.EventHandler(this.gb_Update_Enter);
            // 
            // lbl_NewModule
            // 
            this.lbl_NewModule.AutoSize = true;
            this.lbl_NewModule.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NewModule.Location = new System.Drawing.Point(24, 149);
            this.lbl_NewModule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NewModule.Name = "lbl_NewModule";
            this.lbl_NewModule.Size = new System.Drawing.Size(128, 21);
            this.lbl_NewModule.TabIndex = 3;
            this.lbl_NewModule.Text = "Module/Subject";
            // 
            // lvl_Newlvl
            // 
            this.lvl_Newlvl.AutoSize = true;
            this.lvl_Newlvl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl_Newlvl.Location = new System.Drawing.Point(102, 40);
            this.lvl_Newlvl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lvl_Newlvl.Name = "lvl_Newlvl";
            this.lvl_Newlvl.Size = new System.Drawing.Size(50, 21);
            this.lvl_Newlvl.TabIndex = 2;
            this.lvl_Newlvl.Text = "Level";
            // 
            // cb_module
            // 
            this.cb_module.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_module.FormattingEnabled = true;
            this.cb_module.Items.AddRange(new object[] {
            "C",
            "C#",
            "Python"});
            this.cb_module.Location = new System.Drawing.Point(172, 143);
            this.cb_module.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cb_module.Name = "cb_module";
            this.cb_module.Size = new System.Drawing.Size(140, 27);
            this.cb_module.TabIndex = 1;
            this.cb_module.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cb_level
            // 
            this.cb_level.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_level.FormattingEnabled = true;
            this.cb_level.Items.AddRange(new object[] {
            "Beginner",
            "Intermediate",
            "Advance"});
            this.cb_level.Location = new System.Drawing.Point(172, 34);
            this.cb_level.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cb_level.Name = "cb_level";
            this.cb_level.Size = new System.Drawing.Size(140, 27);
            this.cb_level.TabIndex = 0;
            this.cb_level.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(436, 319);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(88, 27);
            this.btn_back.TabIndex = 4;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_classsid
            // 
            this.lbl_classsid.AutoSize = true;
            this.lbl_classsid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_classsid.Location = new System.Drawing.Point(56, 262);
            this.lbl_classsid.Name = "lbl_classsid";
            this.lbl_classsid.Size = new System.Drawing.Size(132, 22);
            this.lbl_classsid.TabIndex = 5;
            this.lbl_classsid.Text = "ClassStudentID";
            // 
            // cb_ID
            // 
            this.cb_ID.FormattingEnabled = true;
            this.cb_ID.Location = new System.Drawing.Point(205, 257);
            this.cb_ID.Name = "cb_ID";
            this.cb_ID.Size = new System.Drawing.Size(140, 27);
            this.cb_ID.TabIndex = 6;
            this.cb_ID.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_2);
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(233, 161);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(92, 38);
            this.btn_check.TabIndex = 7;
            this.btn_check.Text = "Check";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(727, 411);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(62, 28);
            this.button6.TabIndex = 10;
            this.button6.Text = "Exit";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // L_UpdateEn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.cb_ID);
            this.Controls.Add(this.lbl_classsid);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.gb_Update);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.cb_Name);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "L_UpdateEn";
            this.Text = "UpdateEn";
            this.Load += new System.EventHandler(this.UpdateEn_Load);
            this.gb_Update.ResumeLayout(false);
            this.gb_Update.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.GroupBox gb_Update;
        private System.Windows.Forms.Label lbl_NewModule;
        private System.Windows.Forms.Label lvl_Newlvl;
        private System.Windows.Forms.ComboBox cb_module;
        private System.Windows.Forms.ComboBox cb_level;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_classsid;
        private System.Windows.Forms.ComboBox cb_ID;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Button button6;
    }
}