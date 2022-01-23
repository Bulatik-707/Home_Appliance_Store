namespace Home_Appliance_Store
{
    partial class F_Sotr
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
            this.cB_Dolznost = new System.Windows.Forms.ComboBox();
            this.B_Save = new System.Windows.Forms.Button();
            this.dataGV_Sotr = new System.Windows.Forms.DataGridView();
            this.tB_FIO_Sotr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.B_Add = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.StatusStrip();
            this.StatusRes = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Sotr)).BeginInit();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // cB_Dolznost
            // 
            this.cB_Dolznost.FormattingEnabled = true;
            this.cB_Dolznost.Location = new System.Drawing.Point(95, 62);
            this.cB_Dolznost.Name = "cB_Dolznost";
            this.cB_Dolznost.Size = new System.Drawing.Size(121, 21);
            this.cB_Dolznost.TabIndex = 11;
            // 
            // B_Save
            // 
            this.B_Save.BackColor = System.Drawing.SystemColors.Highlight;
            this.B_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_Save.Location = new System.Drawing.Point(341, 64);
            this.B_Save.Name = "B_Save";
            this.B_Save.Size = new System.Drawing.Size(99, 48);
            this.B_Save.TabIndex = 8;
            this.B_Save.Text = "Сохранить";
            this.B_Save.UseVisualStyleBackColor = false;
            this.B_Save.Click += new System.EventHandler(this.B_Save_Click);
            // 
            // dataGV_Sotr
            // 
            this.dataGV_Sotr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_Sotr.Location = new System.Drawing.Point(13, 129);
            this.dataGV_Sotr.Name = "dataGV_Sotr";
            this.dataGV_Sotr.Size = new System.Drawing.Size(427, 169);
            this.dataGV_Sotr.TabIndex = 6;
            this.dataGV_Sotr.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_Sotr_CellClick);
            // 
            // tB_FIO_Sotr
            // 
            this.tB_FIO_Sotr.Location = new System.Drawing.Point(95, 29);
            this.tB_FIO_Sotr.Name = "tB_FIO_Sotr";
            this.tB_FIO_Sotr.Size = new System.Drawing.Size(121, 20);
            this.tB_FIO_Sotr.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "ФИО";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(10, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Должность";
            // 
            // B_Add
            // 
            this.B_Add.BackColor = System.Drawing.SystemColors.HotTrack;
            this.B_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_Add.Location = new System.Drawing.Point(339, 13);
            this.B_Add.Name = "B_Add";
            this.B_Add.Size = new System.Drawing.Size(101, 46);
            this.B_Add.TabIndex = 16;
            this.B_Add.Text = "Добавить";
            this.B_Add.UseVisualStyleBackColor = false;
            this.B_Add.Click += new System.EventHandler(this.B_Add_Click);
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.Color.Red;
            this.status.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusRes});
            this.status.Location = new System.Drawing.Point(0, 306);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(453, 22);
            this.status.TabIndex = 18;
            // 
            // StatusRes
            // 
            this.StatusRes.Name = "StatusRes";
            this.StatusRes.Size = new System.Drawing.Size(0, 17);
            // 
            // F_Sotr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(453, 328);
            this.Controls.Add(this.status);
            this.Controls.Add(this.B_Add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tB_FIO_Sotr);
            this.Controls.Add(this.cB_Dolznost);
            this.Controls.Add(this.B_Save);
            this.Controls.Add(this.dataGV_Sotr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "F_Sotr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ф_Сотрудники";
            this.Load += new System.EventHandler(this.F_Sotr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Sotr)).EndInit();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cB_Dolznost;
        private System.Windows.Forms.Button B_Save;
        private System.Windows.Forms.DataGridView dataGV_Sotr;
        private System.Windows.Forms.TextBox tB_FIO_Sotr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button B_Add;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel StatusRes;

    }
}