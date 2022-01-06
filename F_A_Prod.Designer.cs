namespace Home_Appliance_Store
{
    partial class F_A_Prod
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
            this.B_in_Prod = new System.Windows.Forms.Button();
            this.B_End = new System.Windows.Forms.Button();
            this.B_in_Tov = new System.Windows.Forms.Button();
            this.B_Klient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B_in_Prod
            // 
            this.B_in_Prod.BackColor = System.Drawing.SystemColors.Highlight;
            this.B_in_Prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_in_Prod.Location = new System.Drawing.Point(31, 98);
            this.B_in_Prod.Name = "B_in_Prod";
            this.B_in_Prod.Size = new System.Drawing.Size(163, 37);
            this.B_in_Prod.TabIndex = 0;
            this.B_in_Prod.Text = "Форма \"Продажи\"";
            this.B_in_Prod.UseVisualStyleBackColor = false;
            this.B_in_Prod.Click += new System.EventHandler(this.B_in_Prod_Click);
            // 
            // B_End
            // 
            this.B_End.BackColor = System.Drawing.SystemColors.Highlight;
            this.B_End.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_End.ForeColor = System.Drawing.Color.Red;
            this.B_End.Location = new System.Drawing.Point(68, 155);
            this.B_End.Name = "B_End";
            this.B_End.Size = new System.Drawing.Size(90, 38);
            this.B_End.TabIndex = 1;
            this.B_End.Text = "Назад";
            this.B_End.UseVisualStyleBackColor = false;
            this.B_End.Click += new System.EventHandler(this.B_End_Click);
            // 
            // B_in_Tov
            // 
            this.B_in_Tov.BackColor = System.Drawing.SystemColors.Highlight;
            this.B_in_Tov.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_in_Tov.Location = new System.Drawing.Point(31, 55);
            this.B_in_Tov.Name = "B_in_Tov";
            this.B_in_Tov.Size = new System.Drawing.Size(163, 37);
            this.B_in_Tov.TabIndex = 2;
            this.B_in_Tov.Text = "Форма \"Товары\"";
            this.B_in_Tov.UseVisualStyleBackColor = false;
            this.B_in_Tov.Click += new System.EventHandler(this.B_in_Tov_Click);
            // 
            // B_Klient
            // 
            this.B_Klient.BackColor = System.Drawing.SystemColors.Highlight;
            this.B_Klient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_Klient.Location = new System.Drawing.Point(31, 12);
            this.B_Klient.Name = "B_Klient";
            this.B_Klient.Size = new System.Drawing.Size(163, 37);
            this.B_Klient.TabIndex = 10;
            this.B_Klient.Text = "Форма \"Клиенты\"";
            this.B_Klient.UseVisualStyleBackColor = false;
            this.B_Klient.Click += new System.EventHandler(this.B_Klient_Click);
            // 
            // F_A_Prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(232, 205);
            this.Controls.Add(this.B_Klient);
            this.Controls.Add(this.B_in_Tov);
            this.Controls.Add(this.B_End);
            this.Controls.Add(this.B_in_Prod);
            this.MaximizeBox = false;
            this.Name = "F_A_Prod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ф_Продавец";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_in_Prod;
        private System.Windows.Forms.Button B_End;
        private System.Windows.Forms.Button B_in_Tov;
        private System.Windows.Forms.Button B_Klient;
    }
}