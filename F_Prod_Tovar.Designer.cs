namespace Home_Appliance_Store
{
    partial class F_Prod_Tovar
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
            this.dataGV_ProdTov = new System.Windows.Forms.DataGridView();
            this.B_Add = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.StatusStrip();
            this.StatusRes = new System.Windows.Forms.ToolStripStatusLabel();
            this.cB_Kat = new System.Windows.Forms.ComboBox();
            this.cB_Tov = new System.Windows.Forms.ComboBox();
            this.num_Kol = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Cost = new System.Windows.Forms.Label();
            this.label_Sum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label_Itogo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Date_Prod = new System.Windows.Forms.DateTimePicker();
            this.label_Sotr = new System.Windows.Forms.Label();
            this.label_Client = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_ProdTov)).BeginInit();
            this.status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Kol)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGV_ProdTov
            // 
            this.dataGV_ProdTov.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGV_ProdTov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_ProdTov.Location = new System.Drawing.Point(10, 268);
            this.dataGV_ProdTov.Name = "dataGV_ProdTov";
            this.dataGV_ProdTov.RowHeadersWidth = 51;
            this.dataGV_ProdTov.Size = new System.Drawing.Size(717, 185);
            this.dataGV_ProdTov.TabIndex = 4;
            this.dataGV_ProdTov.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_ProdTov_CellContentClick);
            // 
            // B_Add
            // 
            this.B_Add.BackColor = System.Drawing.SystemColors.HotTrack;
            this.B_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B_Add.Location = new System.Drawing.Point(397, 200);
            this.B_Add.Name = "B_Add";
            this.B_Add.Size = new System.Drawing.Size(153, 47);
            this.B_Add.TabIndex = 33;
            this.B_Add.Text = "Добавить в заказ";
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
            this.status.Location = new System.Drawing.Point(0, 492);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(739, 22);
            this.status.TabIndex = 34;
            // 
            // StatusRes
            // 
            this.StatusRes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StatusRes.Name = "StatusRes";
            this.StatusRes.Size = new System.Drawing.Size(0, 17);
            // 
            // cB_Kat
            // 
            this.cB_Kat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cB_Kat.FormattingEnabled = true;
            this.cB_Kat.Location = new System.Drawing.Point(455, 12);
            this.cB_Kat.Name = "cB_Kat";
            this.cB_Kat.Size = new System.Drawing.Size(248, 23);
            this.cB_Kat.TabIndex = 9;
            this.cB_Kat.SelectedIndexChanged += new System.EventHandler(this.cB_Kat_SelectedIndexChanged);
            // 
            // cB_Tov
            // 
            this.cB_Tov.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cB_Tov.FormattingEnabled = true;
            this.cB_Tov.Location = new System.Drawing.Point(452, 45);
            this.cB_Tov.Name = "cB_Tov";
            this.cB_Tov.Size = new System.Drawing.Size(249, 23);
            this.cB_Tov.TabIndex = 10;
            this.cB_Tov.SelectedIndexChanged += new System.EventHandler(this.cB_Tov_SelectedIndexChanged);
            // 
            // num_Kol
            // 
            this.num_Kol.Location = new System.Drawing.Point(452, 124);
            this.num_Kol.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Kol.Name = "num_Kol";
            this.num_Kol.Size = new System.Drawing.Size(98, 20);
            this.num_Kol.TabIndex = 17;
            this.num_Kol.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Kol.ValueChanged += new System.EventHandler(this.num_Kol_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(396, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Кол-во";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(396, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Цена";
            // 
            // label_Cost
            // 
            this.label_Cost.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Cost.Location = new System.Drawing.Point(452, 84);
            this.label_Cost.Name = "label_Cost";
            this.label_Cost.Padding = new System.Windows.Forms.Padding(2);
            this.label_Cost.Size = new System.Drawing.Size(98, 20);
            this.label_Cost.TabIndex = 21;
            this.label_Cost.Text = "                  ";
            // 
            // label_Sum
            // 
            this.label_Sum.AutoSize = true;
            this.label_Sum.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Sum.Location = new System.Drawing.Point(485, 166);
            this.label_Sum.Name = "label_Sum";
            this.label_Sum.Padding = new System.Windows.Forms.Padding(2);
            this.label_Sum.Size = new System.Drawing.Size(65, 19);
            this.label_Sum.TabIndex = 21;
            this.label_Sum.Text = "                  ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(396, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Товар";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(371, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Категория";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(394, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 15);
            this.label10.TabIndex = 28;
            this.label10.Text = "Сумма (итого):";
            // 
            // label_Itogo
            // 
            this.label_Itogo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Itogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Itogo.Location = new System.Drawing.Point(632, 464);
            this.label_Itogo.Name = "label_Itogo";
            this.label_Itogo.Padding = new System.Windows.Forms.Padding(2);
            this.label_Itogo.Size = new System.Drawing.Size(87, 20);
            this.label_Itogo.TabIndex = 21;
            this.label_Itogo.Text = "                  ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(504, 464);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "Стоимость заказа:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(23, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 15);
            this.label9.TabIndex = 43;
            this.label9.Text = "Продовец";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(24, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 15);
            this.label8.TabIndex = 42;
            this.label8.Text = "Клиент";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(2, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 15);
            this.label7.TabIndex = 41;
            this.label7.Text = "Дата продажи";
            // 
            // Date_Prod
            // 
            this.Date_Prod.Enabled = false;
            this.Date_Prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Date_Prod.Location = new System.Drawing.Point(115, 16);
            this.Date_Prod.Name = "Date_Prod";
            this.Date_Prod.Size = new System.Drawing.Size(180, 21);
            this.Date_Prod.TabIndex = 39;
            // 
            // label_Sotr
            // 
            this.label_Sotr.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Sotr.Location = new System.Drawing.Point(111, 57);
            this.label_Sotr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Sotr.Name = "label_Sotr";
            this.label_Sotr.Padding = new System.Windows.Forms.Padding(2);
            this.label_Sotr.Size = new System.Drawing.Size(184, 20);
            this.label_Sotr.TabIndex = 45;
            // 
            // label_Client
            // 
            this.label_Client.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Client.Location = new System.Drawing.Point(111, 88);
            this.label_Client.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Client.Name = "label_Client";
            this.label_Client.Padding = new System.Windows.Forms.Padding(2);
            this.label_Client.Size = new System.Drawing.Size(184, 20);
            this.label_Client.TabIndex = 45;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.Date_Prod);
            this.panel1.Controls.Add(this.label_Client);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label_Sotr);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 135);
            this.panel1.TabIndex = 51;
            // 
            // F_Prod_Tovar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(739, 514);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.B_Add);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_Itogo);
            this.Controls.Add(this.label_Sum);
            this.Controls.Add(this.label_Cost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num_Kol);
            this.Controls.Add(this.cB_Tov);
            this.Controls.Add(this.cB_Kat);
            this.Controls.Add(this.dataGV_ProdTov);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "F_Prod_Tovar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ф_Продажа_Товара";
            this.Load += new System.EventHandler(this.F_Prod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_ProdTov)).EndInit();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Kol)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGV_ProdTov;
        private System.Windows.Forms.Button B_Add;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel StatusRes;
        private System.Windows.Forms.ComboBox cB_Kat;
        private System.Windows.Forms.ComboBox cB_Tov;
        private System.Windows.Forms.NumericUpDown num_Kol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Cost;
        private System.Windows.Forms.Label label_Sum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_Itogo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker Date_Prod;
        private System.Windows.Forms.Label label_Sotr;
        private System.Windows.Forms.Label label_Client;
        private System.Windows.Forms.Panel panel1;
    }
}