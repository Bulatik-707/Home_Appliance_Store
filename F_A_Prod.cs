using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Appliance_Store
{
    public partial class F_A_Prod : Form
    {
        public F_A_Prod() // Форма Продавец
        {
            InitializeComponent();
            MessageBox.Show("Вы вошли на форму Продавца.");
        }

        private void B_Klient_Click(object sender, EventArgs e)
        {
            F_Klient t = new F_Klient();
            t.Show(); // на Ф_Товары
        }
        private void B_in_Prod_Click(object sender, EventArgs e)
        {
            F_Prod p = new F_Prod();
            p.Show(); // на Ф_Продажи
        }
        private void B_in_Tov_Click(object sender, EventArgs e)
        {
            F_Tovar t = new F_Tovar();
            t.Show(); // на Ф_Товары
        }
        private void B_End_Click(object sender, EventArgs e)
        {
            F_Avtor END = new F_Avtor();
            END.Show(); // на Ф_Авторизация
        }


    }
}
