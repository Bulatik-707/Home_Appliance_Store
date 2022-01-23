using System;
using System.Linq;
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
            using ( BitMagEntities context = new BitMagEntities() )
            {
                bs_Postavshik.DataSource = context.Поставщик.ToList();
            }

            Tuning.ComboBinding(bs_Postavshik, "Поставщик", "Код_Поставщика", cB_Postavshik);

        }
        private void B_Add_Click(object sender, EventArgs e)
        {
            using ( BitMagEntities context = new BitMagEntities() )
            {
                Поставки postavka = new Поставки();
                postavka.Код_Поставщика_ПТ = (int)cB_Postavshik.SelectedValue;
                postavka.ДатаПоставки = DateTime.Today;

                context.Поставки.Add(postavka);
                context.SaveChanges();

                F_Post_Tovar f = new F_Post_Tovar(postavka);
                f.ShowDialog();
                this.Close();
            }

        }

        
    }
}