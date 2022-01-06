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
    public partial class F_A_Yprav : Form
    {
        public F_A_Yprav() // Форма Управляющий
        {
            InitializeComponent();
            MessageBox.Show("Вы вошли на форму Управляющего.");
        }
        private void B_Sotr_Click(object sender, EventArgs e)
        {
            F_Sotr p = new F_Sotr();
            p.Show(); // на Ф_Сотрудники
        }
        private void B_Klient_Click(object sender, EventArgs e)
        {
            F_Klient p = new F_Klient();
            p.Show(); // на Ф_Клиенты
        }
        private void B_Postavshiki_Click(object sender, EventArgs e)
        {
            F_Postavshiki p = new F_Postavshiki();
            p.Show(); // на Ф_Поставщики
        }
        private void B_Proizvod_Click(object sender, EventArgs e)
        {
            F_Proizvod p = new F_Proizvod();
            p.Show(); // на Ф_Производители
        }
        private void B_Tovar_Click(object sender, EventArgs e)
        {
            F_Tovar p = new F_Tovar();
            p.Show(); // на Ф_Товар
        }
        private void B_Prodasi_Click(object sender, EventArgs e)
        {
            F_Prod p = new F_Prod();
            p.Show(); // на Ф_Продажи
        }
        private void B_Postavki_Click(object sender, EventArgs e)
        {
            F_Postavki p = new F_Postavki();
            p.Show(); // на Ф_Поставки
        }
        private void B_End_Click(object sender, EventArgs e)
        {
            F_Avtor END = new F_Avtor();
            END.Show(); // на Ф_Авторизация
        }

        
    }
}
