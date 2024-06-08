namespace Admin
{
    partial class A_Assign_Trainer
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
            this.comboName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelLevel = new System.Windows.Forms.Panel();
            this.rdAd = new System.Windows.Forms.RadioButton();
            this.rdInter = new System.Windows.Forms.RadioButton();
            this.rdBeg = new System.Windows.Forms.RadioButton();
            this.panelModule = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdP = new System.Windows.Forms.RadioButton();
            this.rdCSharp = new System.Windows.Forms.RadioButton();
            this.rdC = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panelIntakeMonth = new System.Windows.Forms.Panel();
            this.rdSep = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rdJune = new System.Windows.Forms.RadioButton();
            this.rdMarch = new System.Windows.Forms.RadioButton();
            this.btnRemove = new System.Windows.Forms.Button();
            this.classViewer = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbHall3 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.rbHall2 = new System.Windows.Forms.RadioButton();
            this.rbHall1 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelLevel.SuspendLayout();
            this.panelModule.SuspendLayout();
            this.panelIntakeMonth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classViewer)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboName
            // 
            this.comboName.AllowDrop = true;
            this.comboName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboName.FormattingEnabled = true;
            this.comboName.Location = new System.Drawing.Point(12, 75);
            this.comboName.Name = "comboName";
            this.comboName.Size = new System.Drawing.Size(169, 33);
            this.comboName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Level";
            // 
            // panelLevel
            // 
            this.panelLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLevel.Controls.Add(this.rdAd);
            this.panelLevel.Controls.Add(this.label2);
            this.panelLevel.Controls.Add(this.rdInter);
            this.panelLevel.Controls.Add(this.rdBeg);
            this.panelLevel.Location = new System.Drawing.Point(362, 12);
            this.panelLevel.Name = "panelLevel";
            this.panelLevel.Size = new System.Drawing.Size(141, 212);
            this.panelLevel.TabIndex = 12;
            // 
            // rdAd
            // 
            this.rdAd.AutoSize = true;
            this.rdAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdAd.Location = new System.Drawing.Point(14, 153);
            this.rdAd.Name = "rdAd";
            this.rdAd.Size = new System.Drawing.Size(94, 24);
            this.rdAd.TabIndex = 12;
            this.rdAd.TabStop = true;
            this.rdAd.Text = "Advance";
            this.rdAd.UseVisualStyleBackColor = true;
            // 
            // rdInter
            // 
            this.rdInter.AutoSize = true;
            this.rdInter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdInter.Location = new System.Drawing.Point(14, 109);
            this.rdInter.Name = "rdInter";
            this.rdInter.Size = new System.Drawing.Size(122, 24);
            this.rdInter.TabIndex = 11;
            this.rdInter.TabStop = true;
            this.rdInter.Text = "Intermediate";
            this.rdInter.UseVisualStyleBackColor = true;
            // 
            // rdBeg
            // 
            this.rdBeg.AutoSize = true;
            this.rdBeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBeg.Location = new System.Drawing.Point(14, 64);
            this.rdBeg.Name = "rdBeg";
            this.rdBeg.Size = new System.Drawing.Size(97, 24);
            this.rdBeg.TabIndex = 10;
            this.rdBeg.TabStop = true;
            this.rdBeg.Text = "Beginner";
            this.rdBeg.UseVisualStyleBackColor = true;
            // 
            // panelModule
            // 
            this.panelModule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelModule.Controls.Add(this.label6);
            this.panelModule.Controls.Add(this.label5);
            this.panelModule.Controls.Add(this.rdP);
            this.panelModule.Controls.Add(this.rdCSharp);
            this.panelModule.Controls.Add(this.rdC);
            this.panelModule.Controls.Add(this.label3);
            this.panelModule.Location = new System.Drawing.Point(187, 12);
            this.panelModule.Name = "panelModule";
            this.panelModule.Size = new System.Drawing.Size(169, 212);
            this.panelModule.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Programming";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Programming";
            // 
            // rdP
            // 
            this.rdP.AutoSize = true;
            this.rdP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdP.Location = new System.Drawing.Point(13, 153);
            this.rdP.Name = "rdP";
            this.rdP.Size = new System.Drawing.Size(81, 24);
            this.rdP.TabIndex = 9;
            this.rdP.TabStop = true;
            this.rdP.Text = "Python";
            this.rdP.UseVisualStyleBackColor = true;
            // 
            // rdCSharp
            // 
            this.rdCSharp.AutoSize = true;
            this.rdCSharp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCSharp.Location = new System.Drawing.Point(13, 109);
            this.rdCSharp.Name = "rdCSharp";
            this.rdCSharp.Size = new System.Drawing.Size(51, 24);
            this.rdCSharp.TabIndex = 8;
            this.rdCSharp.TabStop = true;
            this.rdCSharp.Text = "C#";
            this.rdCSharp.UseVisualStyleBackColor = true;
            // 
            // rdC
            // 
            this.rdC.AutoSize = true;
            this.rdC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdC.Location = new System.Drawing.Point(13, 64);
            this.rdC.Name = "rdC";
            this.rdC.Size = new System.Drawing.Size(42, 24);
            this.rdC.TabIndex = 7;
            this.rdC.TabStop = true;
            this.rdC.Text = "C";
            this.rdC.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Module";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(633, 264);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(155, 56);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panelIntakeMonth
            // 
            this.panelIntakeMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelIntakeMonth.Controls.Add(this.rdSep);
            this.panelIntakeMonth.Controls.Add(this.label4);
            this.panelIntakeMonth.Controls.Add(this.rdJune);
            this.panelIntakeMonth.Controls.Add(this.rdMarch);
            this.panelIntakeMonth.Location = new System.Drawing.Point(509, 12);
            this.panelIntakeMonth.Name = "panelIntakeMonth";
            this.panelIntakeMonth.Size = new System.Drawing.Size(134, 212);
            this.panelIntakeMonth.TabIndex = 13;
            // 
            // rdSep
            // 
            this.rdSep.AutoSize = true;
            this.rdSep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSep.Location = new System.Drawing.Point(13, 153);
            this.rdSep.Name = "rdSep";
            this.rdSep.Size = new System.Drawing.Size(111, 24);
            this.rdSep.TabIndex = 15;
            this.rdSep.TabStop = true;
            this.rdSep.Text = "September";
            this.rdSep.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Intake Month";
            // 
            // rdJune
            // 
            this.rdJune.AutoSize = true;
            this.rdJune.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdJune.Location = new System.Drawing.Point(13, 109);
            this.rdJune.Name = "rdJune";
            this.rdJune.Size = new System.Drawing.Size(66, 24);
            this.rdJune.TabIndex = 14;
            this.rdJune.TabStop = true;
            this.rdJune.Text = "June";
            this.rdJune.UseVisualStyleBackColor = true;
            // 
            // rdMarch
            // 
            this.rdMarch.AutoSize = true;
            this.rdMarch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMarch.Location = new System.Drawing.Point(13, 64);
            this.rdMarch.Name = "rdMarch";
            this.rdMarch.Size = new System.Drawing.Size(77, 24);
            this.rdMarch.TabIndex = 13;
            this.rdMarch.TabStop = true;
            this.rdMarch.Text = "March";
            this.rdMarch.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(633, 344);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(155, 56);
            this.btnRemove.TabIndex = 15;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // classViewer
            // 
            this.classViewer.AllowUserToAddRows = false;
            this.classViewer.AllowUserToDeleteRows = false;
            this.classViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classViewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3,
            this.Column4});
            this.classViewer.Location = new System.Drawing.Point(26, 264);
            this.classViewer.Name = "classViewer";
            this.classViewer.ReadOnly = true;
            this.classViewer.RowHeadersWidth = 51;
            this.classViewer.RowTemplate.Height = 24;
            this.classViewer.Size = new System.Drawing.Size(576, 150);
            this.classViewer.TabIndex = 16;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Module";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Level";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Intake Month";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Venue";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rbHall3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.rbHall2);
            this.panel1.Controls.Add(this.rbHall1);
            this.panel1.Location = new System.Drawing.Point(649, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 212);
            this.panel1.TabIndex = 16;
            // 
            // rbHall3
            // 
            this.rbHall3.AutoSize = true;
            this.rbHall3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHall3.Location = new System.Drawing.Point(13, 153);
            this.rbHall3.Name = "rbHall3";
            this.rbHall3.Size = new System.Drawing.Size(69, 24);
            this.rbHall3.TabIndex = 15;
            this.rbHall3.TabStop = true;
            this.rbHall3.Text = "Hall3";
            this.rbHall3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Venue";
            // 
            // rbHall2
            // 
            this.rbHall2.AutoSize = true;
            this.rbHall2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHall2.Location = new System.Drawing.Point(13, 109);
            this.rbHall2.Name = "rbHall2";
            this.rbHall2.Size = new System.Drawing.Size(69, 24);
            this.rbHall2.TabIndex = 14;
            this.rbHall2.TabStop = true;
            this.rbHall2.Text = "Hall2";
            this.rbHall2.UseVisualStyleBackColor = true;
            // 
            // rbHall1
            // 
            this.rbHall1.AutoSize = true;
            this.rbHall1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHall1.Location = new System.Drawing.Point(13, 64);
            this.rbHall1.Name = "rbHall1";
            this.rbHall1.Size = new System.Drawing.Size(69, 24);
            this.rbHall1.TabIndex = 13;
            this.rbHall1.TabStop = true;
            this.rbHall1.Text = "Hall1";
            this.rbHall1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Empty Slots";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(727, 420);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(62, 28);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // A_Assign_Trainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.classViewer);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.panelIntakeMonth);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.panelModule);
            this.Controls.Add(this.panelLevel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboName);
            this.Name = "A_Assign_Trainer";
            this.Text = "Assign_Trainer";
            this.Load += new System.EventHandler(this.Assign_Trainer_Load);
            this.panelLevel.ResumeLayout(false);
            this.panelLevel.PerformLayout();
            this.panelModule.ResumeLayout(false);
            this.panelModule.PerformLayout();
            this.panelIntakeMonth.ResumeLayout(false);
            this.panelIntakeMonth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classViewer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelLevel;
        private System.Windows.Forms.Panel panelModule;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panelIntakeMonth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn classIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moduleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intakeMonthDataGridViewTextBoxColumn;
        private System.Windows.Forms.RadioButton rdAd;
        private System.Windows.Forms.RadioButton rdInter;
        private System.Windows.Forms.RadioButton rdBeg;
        private System.Windows.Forms.RadioButton rdP;
        private System.Windows.Forms.RadioButton rdCSharp;
        private System.Windows.Forms.RadioButton rdC;
        private System.Windows.Forms.RadioButton rdSep;
        private System.Windows.Forms.RadioButton rdJune;
        private System.Windows.Forms.RadioButton rdMarch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource levelModuleBindingSource1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView classViewer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbHall3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbHall2;
        private System.Windows.Forms.RadioButton rbHall1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnExit;
    }
}