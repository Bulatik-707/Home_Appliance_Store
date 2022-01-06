namespace Home_Appliance_Store
{
    partial class F_Post_Tovar
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num_Kol = new System.Windows.Forms.NumericUpDown();
            this.cB_Kat = new System.Windows.Forms.ComboBox();
            this.cB_Tov = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Postavshik = new System.Windows.Forms.Label();
            this.label_Cost = new System.Windows.Forms.Label();
            this.B_Add = new System.Windows.Forms.Button();
            this.label_Sum = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGV_ProdTov = new System.Windows.Forms.DataGridView();
            this.status = new System.Windows.Forms.StatusStrip();
            this.StatusRes = new System.Windows.Forms.ToolStripStatusLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label_Itogo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_Kol)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_ProdTov)).BeginInit();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(33, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 26;
            this.label8.Text = "Поставщик";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(22, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "Дата поставки";
            // 
            // Date_Pst
            // 
            this.Date_Pst.Enabled = false;
            this.Date_Pst.Location = new System.Drawing.Point(138, 19);
            this.Date_Pst.Name = "Date_Pst";
            this.Date_Pst.Size = new System.Drawing.Size(143, 20);
            this.Date_Pst.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(400, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 37;
            this.label5.Text = "Категория";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(427, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 36;
            this.label4.Text = "Товар";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(423, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 35;
            this.label3.Text = "Итого:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(421, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 34;
            this.label2.Text = "Кол-во";
            // 
            // num_Kol
            // 
            this.num_Kol.Location = new System.Drawing.Point(497, 80);
            this.num_Kol.Name = "num_Kol";
            this.num_Kol.Size = new System.Drawing.Size(57, 20);
            this.num_Kol.TabIndex = 32;
            this.num_Kol.ValueChanged += new System.EventHandler(this.num_Kol_ValueChanged);
            // 
            // cB_Kat
            // 
            this.cB_Kat.FormattingEnabled = true;
            this.cB_Kat.Location = new System.Drawing.Point(494, 10);
            this.cB_Kat.Name = "cB_Kat";
            this.cB_Kat.Size = new System.Drawing.Size(153, 21);
            this.cB_Kat.TabIndex = 31;
            this.cB_Kat.SelectedIndexChanged += new System.EventHandler(this.cB_Kat_SelectedIndexChanged);
            // 
            // cB_Tov
            // 
            this.cB_Tov.FormattingEnabled = true;
            this.cB_Tov.Location = new System.Drawing.Point(494, 43);
            this.cB_Tov.Name = "cB_Tov";
            this.cB_Tov.Size = new System.Drawing.Size(153, 21);
            this.cB_Tov.TabIndex = 30;
            this.cB_Tov.SelectedIndexChanged += new System.EventHandler(this.cB_Tov_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(431, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "Цена";
            // 
            // label_Postavshik
            // 
            this.label_Postavshik.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Postavshik.Location = new System.Drawing.Point(128, 54);
            this.label_Postavshik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Postavshik.Name = "label_Postavshik";
            this.label_Postavshik.Padding = new System.Windows.Forms.Padding(2);
            this.label_Postavshik.Size = new System.Drawing.Size(163, 20);
            this.label_Postavshik.TabIndex = 46;
            // 
            // label_Cost
            // 
            this.label_Cost.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Cost.Location = new System.Drawing.Point(494, 110);
            this.label_Cost.Name = "label_Cost";
            this.label_Cost.Padding = new System.Windows.Forms.Padding(2);
            this.label_Cost.Size = new System.Drawing.Size(98, 20);
            this.label_Cost.TabIndex = 47;
            this.label_Cost.Text = "                  ";
            // 
            // B_Add
            // 
            this.B_Add.BackColor = System.Drawing.SystemColors.HotTrack;
            this.B_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B_Add.Location = new System.Drawing.Point(102, 146);
            this.B_Add.Name = "B_Add";
            this.B_Add.Size = new System.Drawing.Size(165, 47);
            this.B_Add.TabIndex = 48;
            this.B_Add.Text = "Добавить в поставку";
            this.B_Add.UseVisualStyleBackColor = false;
            this.B_Add.Click += new System.EventHandler(this.B_Add_Click);
            // 
            // label_Sum
            // 
            this.label_Sum.AutoSize = true;
            this.label_Sum.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Sum.Location = new System.Drawing.Point(491, 146);
            this.label_Sum.Name = "label_Sum";
            this.label_Sum.Padding = new System.Windows.Forms.Padding(2);
            this.label_Sum.Size = new System.Drawing.Size(65, 19);
            this.label_Sum.TabIndex = 49;
            this.label_Sum.Text = "                  ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label_Postavshik);
            this.panel1.Controls.Add(this.Date_Pst);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(12, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 104);
            this.panel1.TabIndex = 50;
            // 
            // dataGV_ProdTov
            // 
            this.dataGV_ProdTov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_ProdTov.Location = new System.Drawing.Point(21, 212);
            this.dataGV_ProdTov.Name = "dataGV_ProdTov";
            this.dataGV_ProdTov.Size = new System.Drawing.Size(775, 178);
            this.dataGV_ProdTov.TabIndex = 51;
            this.dataGV_ProdTov.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_ProdTov_CellClick);
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.Color.Red;
            this.status.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.status.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusRes});
            this.status.Location = new System.Drawing.Point(0, 428);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(808, 22);
            this.status.TabIndex = 52;
            // 
            // StatusRes
            // 
            this.StatusRes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StatusRes.Name = "StatusRes";
            this.StatusRes.Size = new System.Drawing.Size(0, 17);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(571, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 15);
            this.label6.TabIndex = 54;
            this.label6.Text = "Стоимость заказа:";
            // 
            // label_Itogo
            // 
            this.label_Itogo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Itogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Itogo.Location = new System.Drawing.Point(694, 401);
            this.label_Itogo.Name = "label_Itogo";
            this.label_Itogo.Padding = new System.Windows.Forms.Padding(2);
            this.label_Itogo.Size = new System.Drawing.Size(102, 20);
            this.label_Itogo.TabIndex = 53;
            this.label_Itogo.Text = "                  ";
            // 
            // F_Post_Tovar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_Itogo);
            this.Controls.Add(this.status);
            this.Controls.Add(this.dataGV_ProdTov);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_Sum);
            this.Controls.Add(this.B_Add);
            this.Controls.Add(this.label_Cost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num_Kol);
            this.Controls.Add(this.cB_Kat);
            this.Controls.Add(this.cB_Tov);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "F_Post_Tovar";
            this.Text = "Ф_Поставка_Товара";
            this.Load += new System.EventHandler(this.F_Post_Tovar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_Kol)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_ProdTov)).EndInit();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker Date_Pst;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_Kol;
        private System.Windows.Forms.ComboBox cB_Kat;
        private System.Windows.Forms.ComboBox cB_Tov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Postavshik;
        private System.Windows.Forms.Label label_Cost;
        private System.Windows.Forms.Button B_Add;
        private System.Windows.Forms.Label label_Sum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGV_ProdTov;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel StatusRes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_Itogo;
    }
}