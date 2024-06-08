namespace Admin
{
    partial class A_View_Feedback
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
            this.lstFeedback = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboName
            // 
            this.comboName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboName.FormattingEnabled = true;
            this.comboName.Location = new System.Drawing.Point(302, 120);
            this.comboName.Name = "comboName";
            this.comboName.Size = new System.Drawing.Size(164, 33);
            this.comboName.TabIndex = 3;
            this.comboName.SelectedIndexChanged += new System.EventHandler(this.comboName_SelectedIndexChanged);
            // 
            // lstFeedback
            // 
            this.lstFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFeedback.FormattingEnabled = true;
            this.lstFeedback.ItemHeight = 25;
            this.lstFeedback.Location = new System.Drawing.Point(187, 210);
            this.lstFeedback.Name = "lstFeedback";
            this.lstFeedback.Size = new System.Drawing.Size(365, 179);
            this.lstFeedback.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Feedback Page";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(727, 411);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(62, 28);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // A_View_Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboName);
            this.Controls.Add(this.lstFeedback);
            this.Name = "A_View_Feedback";
            this.Text = "View_Feedback";
            this.Load += new System.EventHandler(this.View_Feedback_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboName;
        private System.Windows.Forms.ListBox lstFeedback;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
    }
}