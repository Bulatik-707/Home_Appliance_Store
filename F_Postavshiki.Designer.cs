namespace Home_Appliance_Store
{
    partial class F_Postavshiki
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
            this.dataGV_Postavshiki = new System.Windows.Forms.DataGridView();
            this.tB_Adres_Post = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.B_Add = new System.Windows.Forms.Button();
            this.B_Save = new System.Windows.Forms.Button();
            this.tB_Post = new System.Windows.Forms.TextBox();
            this.maskedTB_Tell = new System.Windows.Forms.MaskedTextBox();
            this.status = new System.Windows.Forms.StatusStrip();
            this.StatusRes = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Postavshiki)).BeginInit();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGV_Postavshiki
            // 
            this.dataGV_Postavshiki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_Postavshiki.Location = new System.Drawing.Point(15, 151);
            this.dataGV_Postavshiki.Name = "dataGV_Postavshiki";
            this.dataGV_Postavshiki.Size = new System.Drawing.Size(422, 169);
            this.dataGV_Postavshiki.TabIndex = 6;
            this.dataGV_Postavshiki.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_Postavshiki_CellClick);
            // 
            // tB_Adres_Post
            // 
            this.tB_Adres_Post.Location = new System.Drawing.Point(122, 65);
            this.tB_Adres_Post.Name = "tB_Adres_Post";
            this.tB_Adres_Post.Size = new System.Drawing.Size(193, 20);
            this.tB_Adres_Post.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Поставщик";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Адрес";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Телефон";
            // 
            // B_Add
            // 
            this.B_Add.BackColor = System.Drawing.SystemColors.HotTrack;
            this.B_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_Add.Location = new System.Drawing.Point(351, 12);
            this.B_Add.Name = "B_Add";
            this.B_Add.Size = new System.Drawing.Size(101, 46);
            this.B_Add.TabIndex = 18;
            this.B_Add.Text = "Добавить";
            this.B_Add.UseVisualStyleBackColor = false;
            this.B_Add.Click += new System.EventHandler(this.B_Add_Click);
            // 
            // B_Save
            // 
            this.B_Save.BackColor = System.Drawing.SystemColors.Highlight;
            this.B_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_Save.Location = new System.Drawing.Point(353, 72);
            this.B_Save.Name = "B_Save";
            this.B_Save.Size = new System.Drawing.Size(99, 48);
            this.B_Save.TabIndex = 17;
            this.B_Save.Text = "Сохранить";
            this.B_Save.UseVisualStyleBackColor = false;
            this.B_Save.Click += new System.EventHandler(this.B_Save_Click);
            // 
            // tB_Post
            // 
            this.tB_Post.Location = new System.Drawing.Point(122, 28);
            this.tB_Post.Name = "tB_Post";
            this.tB_Post.Size = new System.Drawing.Size(193, 20);
            this.tB_Post.TabIndex = 20;
            // 
            // maskedTB_Tell
            // 
            this.maskedTB_Tell.Location = new System.Drawing.Point(122, 100);
            this.maskedTB_Tell.Mask = "(999) 000-00-00";
            this.maskedTB_Tell.Name = "maskedTB_Tell";
            this.maskedTB_Tell.Size = new System.Drawing.Size(86, 20);
            this.maskedTB_Tell.TabIndex = 21;
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.Color.Red;
            this.status.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusRes});
            this.status.Location = new System.Drawing.Point(0, 323);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(470, 22);
            this.status.TabIndex = 22;
            // 
            // StatusRes
            // 
            this.StatusRes.Name = "StatusRes";
            this.StatusRes.Size = new System.Drawing.Size(0, 17);
            // 
            // F_Postavshiki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(470, 345);
            this.Controls.Add(this.status);
            this.Controls.Add(this.maskedTB_Tell);
            this.Controls.Add(this.tB_Post);
            this.Controls.Add(this.B_Add);
            this.Controls.Add(this.B_Save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tB_Adres_Post);
            this.Controls.Add(this.dataGV_Postavshiki);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "F_Postavshiki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ф_Поставщики";
            this.Load += new System.EventHandler(this.F_Postavshiki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Postavshiki)).EndInit();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGV_Postavshiki;
        private System.Windows.Forms.TextBox tB_Adres_Post;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button B_Add;
        private System.Windows.Forms.Button B_Save;
        private System.Windows.Forms.TextBox tB_Post;
        private System.Windows.Forms.MaskedTextBox maskedTB_Tell;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel StatusRes;
    }
}