namespace Home_Appliance_Store
{
    partial class F_Prod
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
            this.dataGV_Prod = new System.Windows.Forms.DataGridView();
            this.label_Info = new System.Windows.Forms.Label();
            this.B_Add = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.StatusStrip();
            this.StatusRes = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Prod)).BeginInit();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGV_Prod
            // 
            this.dataGV_Prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_Prod.Location = new System.Drawing.Point(14, 75);
            this.dataGV_Prod.Name = "dataGV_Prod";
            this.dataGV_Prod.RowHeadersWidth = 51;
            this.dataGV_Prod.Size = new System.Drawing.Size(668, 265);
            this.dataGV_Prod.TabIndex = 4;
            // 
            // label_Info
            // 
            this.label_Info.AutoSize = true;
            this.label_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Info.ForeColor = System.Drawing.Color.Red;
            this.label_Info.Location = new System.Drawing.Point(293, 9);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(19, 15);
            this.label_Info.TabIndex = 30;
            this.label_Info.Text = "...";
            // 
            // B_Add
            // 
            this.B_Add.BackColor = System.Drawing.SystemColors.HotTrack;
            this.B_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_Add.Location = new System.Drawing.Point(14, 12);
            this.B_Add.Name = "B_Add";
            this.B_Add.Size = new System.Drawing.Size(316, 46);
            this.B_Add.TabIndex = 33;
            this.B_Add.Text = "Добавить продажу";
            this.B_Add.UseVisualStyleBackColor = false;
            this.B_Add.Click += new System.EventHandler(this.B_Add_Click);
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.Color.Red;
            this.status.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.status.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusRes});
            this.status.Location = new System.Drawing.Point(0, 347);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(710, 22);
            this.status.TabIndex = 34;
            // 
            // StatusRes
            // 
            this.StatusRes.Name = "StatusRes";
            this.StatusRes.Size = new System.Drawing.Size(0, 17);
            // 
            // F_Prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(710, 369);
            this.Controls.Add(this.status);
            this.Controls.Add(this.B_Add);
            this.Controls.Add(this.label_Info);
            this.Controls.Add(this.dataGV_Prod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "F_Prod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ф_Продажи_Товара";
            this.Activated += new System.EventHandler(this.F_Prod_Activated);
            this.Load += new System.EventHandler(this.F_Prod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Prod)).EndInit();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGV_Prod;
        private System.Windows.Forms.Label label_Info;
        private System.Windows.Forms.Button B_Add;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel StatusRes;
    }
}