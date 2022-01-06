namespace Home_Appliance_Store
{
    partial class F_Tovar
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
            this.dataGV_Tovar = new System.Windows.Forms.DataGridView();
            this.B_add_Tov = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Tovar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGV_Tovar
            // 
            this.dataGV_Tovar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_Tovar.Location = new System.Drawing.Point(12, 12);
            this.dataGV_Tovar.Name = "dataGV_Tovar";
            this.dataGV_Tovar.Size = new System.Drawing.Size(806, 332);
            this.dataGV_Tovar.TabIndex = 0;
            this.dataGV_Tovar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_Tovar_CellClick);
            // 
            // B_add_Tov
            // 
            this.B_add_Tov.BackColor = System.Drawing.SystemColors.Highlight;
            this.B_add_Tov.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_add_Tov.Location = new System.Drawing.Point(333, 375);
            this.B_add_Tov.Name = "B_add_Tov";
            this.B_add_Tov.Size = new System.Drawing.Size(188, 63);
            this.B_add_Tov.TabIndex = 1;
            this.B_add_Tov.Text = "Добавить";
            this.B_add_Tov.UseVisualStyleBackColor = false;
            this.B_add_Tov.Click += new System.EventHandler(this.B_add_Tov_Click);
            // 
            // F_Tovar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(830, 450);
            this.Controls.Add(this.B_add_Tov);
            this.Controls.Add(this.dataGV_Tovar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "F_Tovar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ф_Товары";
            this.Load += new System.EventHandler(this.F_Tovar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Tovar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGV_Tovar;
        private System.Windows.Forms.Button B_add_Tov;
    }
}