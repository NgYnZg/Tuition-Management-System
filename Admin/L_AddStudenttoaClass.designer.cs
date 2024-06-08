namespace Lecturer
{
    partial class L_AddStudenttoaClass
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_IM = new System.Windows.Forms.ComboBox();
            this.cb_level = new System.Windows.Forms.ComboBox();
            this.cb_module = new System.Windows.Forms.ComboBox();
            this.cb_name = new System.Windows.Forms.ComboBox();
            this.lbl_IM = new System.Windows.Forms.Label();
            this.lbl_module = new System.Windows.Forms.Label();
            this.lbl_lvl = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_IM);
            this.groupBox1.Controls.Add(this.cb_level);
            this.groupBox1.Controls.Add(this.cb_module);
            this.groupBox1.Controls.Add(this.cb_name);
            this.groupBox1.Controls.Add(this.lbl_IM);
            this.groupBox1.Controls.Add(this.lbl_module);
            this.groupBox1.Controls.Add(this.lbl_lvl);
            this.groupBox1.Controls.Add(this.lbl_name);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(94, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(594, 292);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Assign Student to Class";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cb_IM
            // 
            this.cb_IM.FormattingEnabled = true;
            this.cb_IM.Items.AddRange(new object[] {
            "March",
            "June",
            "september"});
            this.cb_IM.Location = new System.Drawing.Point(269, 213);
            this.cb_IM.Margin = new System.Windows.Forms.Padding(4);
            this.cb_IM.Name = "cb_IM";
            this.cb_IM.Size = new System.Drawing.Size(209, 34);
            this.cb_IM.TabIndex = 7;
            // 
            // cb_level
            // 
            this.cb_level.FormattingEnabled = true;
            this.cb_level.Items.AddRange(new object[] {
            "Beginner",
            "Intermediate",
            "Advance"});
            this.cb_level.Location = new System.Drawing.Point(269, 163);
            this.cb_level.Margin = new System.Windows.Forms.Padding(4);
            this.cb_level.Name = "cb_level";
            this.cb_level.Size = new System.Drawing.Size(209, 34);
            this.cb_level.TabIndex = 6;
            // 
            // cb_module
            // 
            this.cb_module.FormattingEnabled = true;
            this.cb_module.Items.AddRange(new object[] {
            "C",
            "C#",
            "Python"});
            this.cb_module.Location = new System.Drawing.Point(269, 110);
            this.cb_module.Margin = new System.Windows.Forms.Padding(4);
            this.cb_module.Name = "cb_module";
            this.cb_module.Size = new System.Drawing.Size(209, 34);
            this.cb_module.TabIndex = 5;
            // 
            // cb_name
            // 
            this.cb_name.FormattingEnabled = true;
            this.cb_name.Location = new System.Drawing.Point(269, 54);
            this.cb_name.Margin = new System.Windows.Forms.Padding(4);
            this.cb_name.Name = "cb_name";
            this.cb_name.Size = new System.Drawing.Size(209, 34);
            this.cb_name.TabIndex = 4;
            // 
            // lbl_IM
            // 
            this.lbl_IM.AutoSize = true;
            this.lbl_IM.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IM.Location = new System.Drawing.Point(94, 219);
            this.lbl_IM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_IM.Name = "lbl_IM";
            this.lbl_IM.Size = new System.Drawing.Size(112, 22);
            this.lbl_IM.TabIndex = 3;
            this.lbl_IM.Text = "Intake Month";
            // 
            // lbl_module
            // 
            this.lbl_module.AutoSize = true;
            this.lbl_module.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_module.Location = new System.Drawing.Point(94, 116);
            this.lbl_module.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_module.Name = "lbl_module";
            this.lbl_module.Size = new System.Drawing.Size(71, 22);
            this.lbl_module.TabIndex = 2;
            this.lbl_module.Text = "Module";
            // 
            // lbl_lvl
            // 
            this.lbl_lvl.AutoSize = true;
            this.lbl_lvl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lvl.Location = new System.Drawing.Point(96, 169);
            this.lbl_lvl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_lvl.Name = "lbl_lvl";
            this.lbl_lvl.Size = new System.Drawing.Size(55, 22);
            this.lbl_lvl.TabIndex = 1;
            this.lbl_lvl.Text = "Level";
            this.lbl_lvl.Click += new System.EventHandler(this.lbl_lvl_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(94, 59);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(56, 22);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name";
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(205, 349);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(133, 37);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(439, 349);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(133, 37);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "Cancel";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
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
            // L_AddStudenttoaClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "L_AddStudenttoaClass";
            this.Text = "AddStudenttoaClass";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_IM;
        private System.Windows.Forms.ComboBox cb_level;
        private System.Windows.Forms.ComboBox cb_module;
        private System.Windows.Forms.ComboBox cb_name;
        private System.Windows.Forms.Label lbl_IM;
        private System.Windows.Forms.Label lbl_module;
        private System.Windows.Forms.Label lbl_lvl;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button button6;
    }
}