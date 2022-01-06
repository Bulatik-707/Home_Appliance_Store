namespace Home_Appliance_Store
{
    partial class F_Avtor
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
            this.Baton_OK = new System.Windows.Forms.Button();
            this.cBox_Login = new System.Windows.Forms.ComboBox();
            this.tBox_Pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Baton_OK
            // 
            this.Baton_OK.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Baton_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Baton_OK.Location = new System.Drawing.Point(51, 152);
            this.Baton_OK.Name = "Baton_OK";
            this.Baton_OK.Size = new System.Drawing.Size(152, 60);
            this.Baton_OK.TabIndex = 0;
            this.Baton_OK.Text = "Войти";
            this.Baton_OK.UseVisualStyleBackColor = false;
            this.Baton_OK.Click += new System.EventHandler(this.Baton_OK_Click);
            // 
            // cBox_Login
            // 
            this.cBox_Login.FormattingEnabled = true;
            this.cBox_Login.Location = new System.Drawing.Point(65, 44);
            this.cBox_Login.Name = "cBox_Login";
            this.cBox_Login.Size = new System.Drawing.Size(121, 21);
            this.cBox_Login.TabIndex = 1;
            // 
            // tBox_Pass
            // 
            this.tBox_Pass.Location = new System.Drawing.Point(65, 99);
            this.tBox_Pass.Name = "tBox_Pass";
            this.tBox_Pass.PasswordChar = '*';
            this.tBox_Pass.Size = new System.Drawing.Size(121, 20);
            this.tBox_Pass.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(101, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(101, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль";
            // 
            // F_Avtor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(259, 224);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBox_Pass);
            this.Controls.Add(this.cBox_Login);
            this.Controls.Add(this.Baton_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "F_Avtor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ф_Авторизация";
            this.Load += new System.EventHandler(this.F_Avtor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Baton_OK;
        private System.Windows.Forms.ComboBox cBox_Login;
        private System.Windows.Forms.TextBox tBox_Pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}