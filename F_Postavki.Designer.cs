namespace Home_Appliance_Store
{
    partial class F_Postavki
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
            this.dataGV_Post = new System.Windows.Forms.DataGridView();
            this.B_Add = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.StatusStrip();
            this.StatusRes = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Post)).BeginInit();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGV_Post
            // 
            this.dataGV_Post.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_Post.Location = new System.Drawing.Point(20, 80);
            this.dataGV_Post.Name = "dataGV_Post";
            this.dataGV_Post.Size = new System.Drawing.Size(679, 233);
            this.dataGV_Post.TabIndex = 0;
            // 
            // B_Add
            // 
            this.B_Add.BackColor = System.Drawing.SystemColors.HotTrack;
            this.B_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_Add.Location = new System.Drawing.Point(38, 12);
            this.B_Add.Name = "B_Add";
            this.B_Add.Size = new System.Drawing.Size(228, 46);
            this.B_Add.TabIndex = 21;
            this.B_Add.Text = "Добавить поставку";
            this.B_Add.UseVisualStyleBackColor = false;
            this.B_Add.Click += new System.EventHandler(this.B_Add_Click);
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.Color.Red;
            this.status.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusRes});
            this.status.Location = new System.Drawing.Point(0, 324);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(721, 22);
            this.status.TabIndex = 22;
            // 
            // StatusRes
            // 
            this.StatusRes.Name = "StatusRes";
            this.StatusRes.Size = new System.Drawing.Size(0, 17);
            // 
            // F_Postavki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(721, 346);
            this.Controls.Add(this.status);
            this.Controls.Add(this.B_Add);
            this.Controls.Add(this.dataGV_Post);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "F_Postavki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ф_Поставки_Товара";
            this.Activated += new System.EventHandler(this.F_Postavki_Activated);
            this.Load += new System.EventHandler(this.F_Postavki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Post)).EndInit();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGV_Post;
        private System.Windows.Forms.Button B_Add;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel StatusRes;
    }
}