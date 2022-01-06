using System;
using System.Linq;
using System.Windows.Forms;

namespace Home_Appliance_Store
{
    public partial class F_Avtor : Form
    {
        public F_Avtor() // Форма Авторизации 
        {
            InitializeComponent();
        }
        BindingSource bs_Pol = new BindingSource();
        private void F_Avtor_Load(object sender, EventArgs e)
        {
             bs_Pol.DataSource = cont.Т_Пользователи.ToList();
           
             cBox_Login.DataSource = bs_Pol;
             cBox_Login.ValueMember= "Код_П";
             cBox_Login.DisplayMember = "Пользователь";
        }
        Entities3 cont = new Entities3();

        private void Baton_OK_Click(object sender, EventArgs e)
        {
            int password = int.Parse(tBox_Pass.Text);
            var p = cont.Т_Пользователи.FirstOrDefault(z => z.Пароль == password && cBox_Login.Text==z.Пользователь);
            // 1234    1357  2468
            if (p != null)
            {
                if (p.Пользователь == "Управляющий")
                {
                    F_A_Yprav ypr = new F_A_Yprav();
                    ypr.Show();
                }
                else if (p.Пользователь == "Менеджер")
                {
                    F_A_Men m = new F_A_Men();
                    m.Show();
                }
                else if (p.Пользователь == "Продавец")
                {
                    F_A_Prod pr = new F_A_Prod();
                    pr.Show();
                }
            }
            else MessageBox.Show("НЕПРАВИЛЬНЫЙ ЛОГИН ИЛИ ПАРОЛЬ");
        }
    }
}
