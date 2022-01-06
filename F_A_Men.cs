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
    public partial class F_A_Men : Form
    {
        public F_A_Men() // Форма Менеджер
        {
            InitializeComponent();
            MessageBox.Show("Вы вошли на форму Менеджера.");
        }
        private void B_Tovar_Click(object sender, EventArgs e)
        {
            F_Tovar p = new F_Tovar();
            p.Show(); // на Ф_Товар
        }
        private void B_Postavki_Click(object sender, EventArgs e)
        {
            F_Postavki p = new F_Postavki();
            p.Show(); // на Ф_Поставки
        }
        private void B_Prod_Click(object sender, EventArgs e)
        {
            F_Prod p = new F_Prod();
            p.Show(); // на Ф_Продажи
        }
        private void B_End_Click(object sender, EventArgs e)
        {
            F_Avtor END = new F_Avtor();
            END.Show(); // на Ф_Авторизация
        }

    }
}
