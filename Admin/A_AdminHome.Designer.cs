namespace Admin
{
    partial class A_AdminHome
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
            this.btnRegDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnIncome = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.btnAssign = new System.Windows.Forms.Button();
            this.lblWelc = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegDel
            // 
            this.btnRegDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegDel.Location = new System.Drawing.Point(311, 100);
            this.btnRegDel.Name = "btnRegDel";
            this.btnRegDel.Size = new System.Drawing.Size(160, 68);
            this.btnRegDel.TabIndex = 0;
            this.btnRegDel.Text = "Register / Delete Trainer";
            this.btnRegDel.UseVisualStyleBackColor = true;
            this.btnRegDel.Click += new System.EventHandler(this.btnRegDel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(276, 357);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(215, 52);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update Profile";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnIncome
            // 
            this.btnIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncome.Location = new System.Drawing.Point(311, 174);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Size = new System.Drawing.Size(160, 55);
            this.btnIncome.TabIndex = 2;
            this.btnIncome.Text = "View Income";
            this.btnIncome.UseVisualStyleBackColor = true;
            this.btnIncome.Click += new System.EventHandler(this.btnIncome_Click);
            // 
            // btnFeedback
            // 
            this.btnFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedback.Location = new System.Drawing.Point(311, 235);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(160, 55);
            this.btnFeedback.TabIndex = 3;
            this.btnFeedback.Text = "View Feedback";
            this.btnFeedback.UseVisualStyleBackColor = true;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // btnAssign
            // 
            this.btnAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssign.Location = new System.Drawing.Point(311, 296);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(160, 55);
            this.btnAssign.TabIndex = 4;
            this.btnAssign.Text = "Assign Trainer";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // lblWelc
            // 
            this.lblWelc.AutoSize = true;
            this.lblWelc.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelc.Location = new System.Drawing.Point(344, 36);
            this.lblWelc.Name = "lblWelc";
            this.lblWelc.Size = new System.Drawing.Size(94, 38);
            this.lblWelc.TabIndex = 5;
            this.lblWelc.Text = "-------";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(727, 411);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(62, 28);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button6_Click);
            // 
            // A_AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblWelc);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.btnFeedback);
            this.Controls.Add(this.btnIncome);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRegDel);
            this.Name = "A_AdminHome";
            this.Text = "AdminHome";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegDel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnIncome;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Label lblWelc;
        private System.Windows.Forms.Button btnExit;
    }
}

