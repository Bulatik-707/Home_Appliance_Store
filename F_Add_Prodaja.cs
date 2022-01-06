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
    public partial class F_Add_Prodaja : Form
    {
        public F_Add_Prodaja() // Форма Продажа
        {
            InitializeComponent();
        }

        BindingSource bs_Sotr = new BindingSource();
        BindingSource bs_Kl = new BindingSource();

        private void F_Add_Prodaja_Load(object sender, EventArgs e)
        {
            using (Entities3 context = new Entities3())
            {
                bs_Sotr.DataSource = context.Т_Сотрудники.ToList();
                bs_Kl.DataSource = context.Т_Клиенты.ToList();
            }

            Tuning.ComboBinding(bs_Sotr, "ФИО", "Код_Сотрудника", cB_Pr);
            Tuning.ComboBinding(bs_Kl, "ФИО_клиента", "Код_клиента", cB_Kl);

        }
        private void B_Add_Click(object sender, EventArgs e)
        {
            using (Entities3 context = new Entities3())
            {
                Т_Продажи prodaja = new Т_Продажи();
                prodaja.Код_Клиента_П = (int)cB_Kl.SelectedValue;
                prodaja.Код_Продовца_П = (int)cB_Pr.SelectedValue;
                prodaja.Дата_Продажи_П = DateTime.Today;

                context.Т_Продажи.Add(prodaja);
                context.SaveChanges();
            
                F_Prod_Tovar f = new F_Prod_Tovar(prodaja);
                f.ShowDialog();
                this.Close();
            }

        }


    }
}
