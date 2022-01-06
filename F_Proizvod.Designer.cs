namespace Home_Appliance_Store
{
    partial class F_Proizvod
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
            this.dataGV_Proizvod = new System.Windows.Forms.DataGridView();
            this.B_Add = new System.Windows.Forms.Button();
            this.num_Nasenka = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.B_Save = new System.Windows.Forms.Button();
            this.tB_Pr = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.StatusStrip();
            this.StatusRes = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Proizvod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Nasenka)).BeginInit();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGV_Proizvod
            // 
            this.dataGV_Proizvod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_Proizvod.Location = new System.Drawing.Point(6, 134);
            this.dataGV_Proizvod.Name = "dataGV_Proizvod";
            this.dataGV_Proizvod.Size = new System.Drawing.Size(442, 198);
            this.dataGV_Proizvod.TabIndex = 0;
            this.dataGV_Proizvod.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_Proizvod_CellClick);
            // 
            // B_Add
            // 
            this.B_Add.BackColor = System.Drawing.SystemColors.HotTrack;
            this.B_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_Add.Location = new System.Drawing.Point(347, 5);
            this.B_Add.Name = "B_Add";
            this.B_Add.Size = new System.Drawing.Size(101, 46);
            this.B_Add.TabIndex = 2;
            this.B_Add.Text = "Добавить";
            this.B_Add.UseVisualStyleBackColor = false;
            this.B_Add.Click += new System.EventHandler(this.B_Add_Click);
            // 
            // num_Nasenka
            // 
            this.num_Nasenka.Location = new System.Drawing.Point(143, 60);
            this.num_Nasenka.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_Nasenka.Name = "num_Nasenka";
            this.num_Nasenka.Size = new System.Drawing.Size(71, 20);
            this.num_Nasenka.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Производитель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Наценка";
            // 
            // B_Save
            // 
            this.B_Save.BackColor = System.Drawing.SystemColors.Highlight;
            this.B_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_Save.Location = new System.Drawing.Point(349, 61);
            this.B_Save.Name = "B_Save";
            this.B_Save.Size = new System.Drawing.Size(99, 48);
            this.B_Save.TabIndex = 9;
            this.B_Save.Text = "Сохранить";
            this.B_Save.UseVisualStyleBackColor = false;
            this.B_Save.Click += new System.EventHandler(this.B_Save_Click);
            // 
            // tB_Pr
            // 
            this.tB_Pr.Location = new System.Drawing.Point(143, 28);
            this.tB_Pr.Name = "tB_Pr";
            this.tB_Pr.Size = new System.Drawing.Size(100, 20);
            this.tB_Pr.TabIndex = 10;
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.Color.Red;
            this.status.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusRes});
            this.status.Location = new System.Drawing.Point(0, 335);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(462, 22);
            this.status.TabIndex = 19;
            // 
            // StatusRes
            // 
            this.StatusRes.Name = "StatusRes";
            this.StatusRes.Size = new System.Drawing.Size(0, 17);
            // 
            // F_Proizvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(462, 357);
            this.Controls.Add(this.status);
            this.Controls.Add(this.tB_Pr);
            this.Controls.Add(this.B_Save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num_Nasenka);
            this.Controls.Add(this.B_Add);
            this.Controls.Add(this.dataGV_Proizvod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "F_Proizvod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ф_Производители";
            this.Load += new System.EventHandler(this.F_Proizvod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Proizvod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Nasenka)).EndInit();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGV_Proizvod;
        private System.Windows.Forms.Button B_Add;
        private System.Windows.Forms.NumericUpDown num_Nasenka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button B_Save;
        private System.Windows.Forms.TextBox tB_Pr;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel StatusRes;
    }
}