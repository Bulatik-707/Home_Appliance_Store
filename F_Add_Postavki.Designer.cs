namespace Home_Appliance_Store
{
    partial class F_Add_Postavki
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Date_Pst = new System.Windows.Forms.DateTimePicker();
            this.cB_Postavshik = new System.Windows.Forms.ComboBox();
            this.B_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(35, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "Поставщик";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(35, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Дата поставки";
            // 
            // Date_Pst
            // 
            this.Date_Pst.Enabled = false;
            this.Date_Pst.Location = new System.Drawing.Point(151, 60);
            this.Date_Pst.Name = "Date_Pst";
            this.Date_Pst.Size = new System.Drawing.Size(175, 20);
            this.Date_Pst.TabIndex = 20;
            // 
            // cB_Postavshik
            // 
            this.cB_Postavshik.FormattingEnabled = true;
            this.cB_Postavshik.Location = new System.Drawing.Point(151, 23);
            this.cB_Postavshik.Name = "cB_Postavshik";
            this.cB_Postavshik.Size = new System.Drawing.Size(175, 21);
            this.cB_Postavshik.TabIndex = 19;
            // 
            // B_Add
            // 
            this.B_Add.BackColor = System.Drawing.SystemColors.HotTrack;
            this.B_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_Add.Location = new System.Drawing.Point(80, 117);
            this.B_Add.Margin = new System.Windows.Forms.Padding(2);
            this.B_Add.Name = "B_Add";
            this.B_Add.Size = new System.Drawing.Size(167, 37);
            this.B_Add.TabIndex = 39;
            this.B_Add.Text = "Далее";
            this.B_Add.UseVisualStyleBackColor = false;
            this.B_Add.Click += new System.EventHandler(this.B_Add_Click);
            // 
            // F_Add_Postavki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(353, 178);
            this.Controls.Add(this.B_Add);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Date_Pst);
            this.Controls.Add(this.cB_Postavshik);
            this.MaximizeBox = false;
            this.Name = "F_Add_Postavki";
            this.Text = "Ф_Поставка";
            this.Load += new System.EventHandler(this.F_Add_Postavki_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker Date_Pst;
        private System.Windows.Forms.ComboBox cB_Postavshik;
        private System.Windows.Forms.Button B_Add;
    }
}