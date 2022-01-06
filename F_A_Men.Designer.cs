namespace Home_Appliance_Store
{
    partial class F_A_Men
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
            this.B_End = new System.Windows.Forms.Button();
            this.B_Prod = new System.Windows.Forms.Button();
            this.B_Postavki = new System.Windows.Forms.Button();
            this.B_Tovar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B_End
            // 
            this.B_End.BackColor = System.Drawing.SystemColors.Highlight;
            this.B_End.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_End.ForeColor = System.Drawing.Color.Red;
            this.B_End.Location = new System.Drawing.Point(64, 154);
            this.B_End.Name = "B_End";
            this.B_End.Size = new System.Drawing.Size(90, 38);
            this.B_End.TabIndex = 2;
            this.B_End.Text = "Назад";
            this.B_End.UseVisualStyleBackColor = false;
            this.B_End.Click += new System.EventHandler(this.B_End_Click);
            // 
            // B_Prod
            // 
            this.B_Prod.BackColor = System.Drawing.SystemColors.Highlight;
            this.B_Prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_Prod.Location = new System.Drawing.Point(47, 98);
            this.B_Prod.Name = "B_Prod";
            this.B_Prod.Size = new System.Drawing.Size(128, 37);
            this.B_Prod.TabIndex = 3;
            this.B_Prod.Text = "Продажи";
            this.B_Prod.UseVisualStyleBackColor = false;
            this.B_Prod.Click += new System.EventHandler(this.B_Prod_Click);
            // 
            // B_Postavki
            // 
            this.B_Postavki.BackColor = System.Drawing.SystemColors.Highlight;
            this.B_Postavki.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_Postavki.Location = new System.Drawing.Point(47, 55);
            this.B_Postavki.Name = "B_Postavki";
            this.B_Postavki.Size = new System.Drawing.Size(128, 37);
            this.B_Postavki.TabIndex = 4;
            this.B_Postavki.Text = "Поставки";
            this.B_Postavki.UseVisualStyleBackColor = false;
            this.B_Postavki.Click += new System.EventHandler(this.B_Postavki_Click);
            // 
            // B_Tovar
            // 
            this.B_Tovar.BackColor = System.Drawing.SystemColors.Highlight;
            this.B_Tovar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_Tovar.Location = new System.Drawing.Point(47, 12);
            this.B_Tovar.Name = "B_Tovar";
            this.B_Tovar.Size = new System.Drawing.Size(128, 37);
            this.B_Tovar.TabIndex = 5;
            this.B_Tovar.Text = "Товары";
            this.B_Tovar.UseVisualStyleBackColor = false;
            this.B_Tovar.Click += new System.EventHandler(this.B_Tovar_Click);
            // 
            // F_A_Men
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(227, 207);
            this.Controls.Add(this.B_Tovar);
            this.Controls.Add(this.B_Postavki);
            this.Controls.Add(this.B_Prod);
            this.Controls.Add(this.B_End);
            this.MaximizeBox = false;
            this.Name = "F_A_Men";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ф_Менеджер";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_End;
        private System.Windows.Forms.Button B_Prod;
        private System.Windows.Forms.Button B_Postavki;
        private System.Windows.Forms.Button B_Tovar;
    }
}