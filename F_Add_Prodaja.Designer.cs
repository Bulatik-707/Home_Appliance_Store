namespace Home_Appliance_Store
{
    partial class F_Add_Prodaja
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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cB_Kl = new System.Windows.Forms.ComboBox();
            this.Date_Prod = new System.Windows.Forms.DateTimePicker();
            this.cB_Pr = new System.Windows.Forms.ComboBox();
            this.B_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(30, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 15);
            this.label9.TabIndex = 36;
            this.label9.Text = "Продовец";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(44, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 15);
            this.label8.TabIndex = 35;
            this.label8.Text = "Клиент";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(44, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 15);
            this.label7.TabIndex = 34;
            this.label7.Text = "Дата продажи";
            // 
            // cB_Kl
            // 
            this.cB_Kl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cB_Kl.FormattingEnabled = true;
            this.cB_Kl.Location = new System.Drawing.Point(106, 59);
            this.cB_Kl.Name = "cB_Kl";
            this.cB_Kl.Size = new System.Drawing.Size(238, 23);
            this.cB_Kl.TabIndex = 33;
            // 
            // Date_Prod
            // 
            this.Date_Prod.Enabled = false;
            this.Date_Prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Date_Prod.Location = new System.Drawing.Point(142, 103);
            this.Date_Prod.Name = "Date_Prod";
            this.Date_Prod.Size = new System.Drawing.Size(143, 21);
            this.Date_Prod.TabIndex = 32;
            // 
            // cB_Pr
            // 
            this.cB_Pr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cB_Pr.FormattingEnabled = true;
            this.cB_Pr.Location = new System.Drawing.Point(107, 22);
            this.cB_Pr.Name = "cB_Pr";
            this.cB_Pr.Size = new System.Drawing.Size(224, 23);
            this.cB_Pr.TabIndex = 31;
            // 
            // B_Add
            // 
            this.B_Add.BackColor = System.Drawing.SystemColors.HotTrack;
            this.B_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_Add.Location = new System.Drawing.Point(91, 158);
            this.B_Add.Margin = new System.Windows.Forms.Padding(2);
            this.B_Add.Name = "B_Add";
            this.B_Add.Size = new System.Drawing.Size(167, 37);
            this.B_Add.TabIndex = 38;
            this.B_Add.Text = "Далее";
            this.B_Add.UseVisualStyleBackColor = false;
            this.B_Add.Click += new System.EventHandler(this.B_Add_Click);
            // 
            // F_Add_Prodaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(395, 221);
            this.Controls.Add(this.B_Add);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cB_Kl);
            this.Controls.Add(this.Date_Prod);
            this.Controls.Add(this.cB_Pr);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "F_Add_Prodaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ф_Продажа";
            this.Load += new System.EventHandler(this.F_Add_Prodaja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cB_Kl;
        private System.Windows.Forms.DateTimePicker Date_Prod;
        private System.Windows.Forms.ComboBox cB_Pr;
        private System.Windows.Forms.Button B_Add;
    }
}