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
    public partial class F_Add_Postavki : Form
    {
        public F_Add_Postavki() // Форма Поставка 
        {
            InitializeComponent();
        }

        BindingSource bs_Postavshik = new BindingSource();

        private void F_Add_Postavki_Load(object sender, EventArgs e)
        {
            using (Entities3 context = new Entities3())
            {
                bs_Postavshik.DataSource = context.Т_Поставщик.ToList();
            }

            Tuning.ComboBinding(bs_Postavshik, "Поставщик", "Код_Поставщика", cB_Postavshik);

        }
        private void B_Add_Click(object sender, EventArgs e)
        {
            using (Entities3 context = new Entities3())
            {
                Т_Поставки postavka = new Т_Поставки();
                postavka.Код_Поставщика_ПТ = (int)cB_Postavshik.SelectedValue;
                postavka.ДатаПоставки = DateTime.Today;

                context.Т_Поставки.Add(postavka);
                context.SaveChanges();

                F_Post_Tovar f = new F_Post_Tovar(postavka);
                f.ShowDialog();
                this.Close();
            }

        }

        
    }
}
