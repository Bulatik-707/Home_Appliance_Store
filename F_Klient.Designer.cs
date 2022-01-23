namespace Home_Appliance_Store
{
    partial class F_Klient
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
            this.status = new System.Windows.Forms.StatusStrip();
            this.StatusRes = new System.Windows.Forms.ToolStripStatusLabel();
            this.maskedTB_Tell = new System.Windows.Forms.MaskedTextBox();
            this.tB_FIO = new System.Windows.Forms.TextBox();
            this.B_Add = new System.Windows.Forms.Button();
            this.B_Save = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGV_Postavshiki = new System.Windows.Forms.DataGridView();
            this.status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Postavshiki)).BeginInit();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.Color.Red;
            this.status.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusRes});
            this.status.Location = new System.Drawing.Point(0, 282);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(420, 22);
            this.status.TabIndex = 32;
            // 
            // StatusRes
            // 
            this.StatusRes.Name = "StatusRes";
            this.StatusRes.Size = new System.Drawing.Size(0, 17);
            // 
            // maskedTB_Tell
            // 
            this.maskedTB_Tell.Location = new System.Drawing.Point(88, 60);
            this.maskedTB_Tell.Mask = "(999) 000-00-00";
            this.maskedTB_Tell.Name = "maskedTB_Tell";
            this.maskedTB_Tell.Size = new System.Drawing.Size(86, 20);
            this.maskedTB_Tell.TabIndex = 31;
            // 
            // tB_FIO
            // 
            this.tB_FIO.Location = new System.Drawing.Point(88, 27);
            this.tB_FIO.Name = "tB_FIO";
            this.tB_FIO.Size = new System.Drawing.Size(113, 20);
            this.tB_FIO.TabIndex = 30;
            // 
            // B_Add
            // 
            this.B_Add.BackColor = System.Drawing.SystemColors.HotTrack;
            this.B_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_Add.Location = new System.Drawing.Point(307, 12);
            this.B_Add.Name = "B_Add";
            this.B_Add.Size = new System.Drawing.Size(101, 38);
            this.B_Add.TabIndex = 29;
            this.B_Add.Text = "Добавить";
            this.B_Add.UseVisualStyleBackColor = false;
            this.B_Add.Click += new System.EventHandler(this.B_Add_Click);
            // 
            // B_Save
            // 
            this.B_Save.BackColor = System.Drawing.SystemColors.Highlight;
            this.B_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_Save.Location = new System.Drawing.Point(309, 60);
            this.B_Save.Name = "B_Save";
            this.B_Save.Size = new System.Drawing.Size(99, 42);
            this.B_Save.TabIndex = 28;
            this.B_Save.Text = "Сохранить";
            this.B_Save.UseVisualStyleBackColor = false;
            this.B_Save.Click += new System.EventHandler(this.B_Save_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Телефон";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "ФИО";
            // 
            // dataGV_Postavshiki
            // 
            this.dataGV_Postavshiki.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGV_Postavshiki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_Postavshiki.Location = new System.Drawing.Point(15, 114);
            this.dataGV_Postavshiki.Name = "dataGV_Postavshiki";
            this.dataGV_Postavshiki.Size = new System.Drawing.Size(392, 160);
            this.dataGV_Postavshiki.TabIndex = 23;
            this.dataGV_Postavshiki.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_Postavshiki_CellClick);
            // 
            // F_Klient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(420, 304);
            this.Controls.Add(this.status);
            this.Controls.Add(this.maskedTB_Tell);
            this.Controls.Add(this.tB_FIO);
            this.Controls.Add(this.B_Add);
            this.Controls.Add(this.B_Save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGV_Postavshiki);
            this.MaximizeBox = false;
            this.Name = "F_Klient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ф_Клиенты";
            this.Load += new System.EventHandler(this.F_Klient_Load);
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Postavshiki)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel StatusRes;
        private System.Windows.Forms.MaskedTextBox maskedTB_Tell;
        private System.Windows.Forms.TextBox tB_FIO;
        private System.Windows.Forms.Button B_Add;
        private System.Windows.Forms.Button B_Save;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGV_Postavshiki;
    }
}