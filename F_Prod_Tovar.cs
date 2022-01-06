using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Home_Appliance_Store
{
    public partial class F_Prod_Tovar : Form
    {
        public F_Prod_Tovar() // Форма Продажа Товара
        {
            InitializeComponent();
        }

        Т_Продажи new_prodaja;
        public F_Prod_Tovar(Т_Продажи prodaja)
        {
            InitializeComponent();
            this.new_prodaja = prodaja;
        }

        BindingSource bs_Kat = new BindingSource();
        BindingSource bs_Tov = new BindingSource();
        BindingSource bs_ProdTov = new BindingSource();
        
        string res = "";
        bool flag = false;

        //Загрузка данных
        void LoadProdaja(BindingSource bs_ProdTov)
        {
            using (Entities3 context = new Entities3())
            {
                var str = from s in context.Т_Продажи_Товара
                          where s.Код_Продажи == new_prodaja.Код_Продажи_П
                          select new
                          {
                              Код = s.Код,
                              Катег = s.Т_Товар.Т_КатегорияТовара.Кат_Товара,                            
                              Товар = s.Т_Товар.Товар_Т,
                              Колво = s.Кол_во,
                              Цена = s.Т_Товар.Цена_Реализации_Т,
                              Сумма = s.Т_Товар.Цена_Реализации_Т * s.Кол_во

                          };
                bs_ProdTov.DataSource = str.ToList();
                label_Itogo.Text = $"{str.Sum(z => z.Сумма)}";
            }
            dataGV_ProdTov.DataSource = bs_ProdTov;            
        }

        //Загрузка данных
        void LoadTovar(BindingSource bs_Tov, int kodKat)
        {
            using (Entities3 context = new Entities3())
            {
                var str = from s in context.Т_Товар
                          where s.Код_КатТовара_Т == kodKat
                          select new
                          {
                              Код = s.Код_Товара_Т,
                              Товар = s.Товар_Т,
                              ценаРеализации = s.Цена_Реализации_Т,
                          };
                bs_Tov.DataSource = str.ToList();
            }
        }
                      
        private void F_Prod_Load(object sender, EventArgs e)
        {
            LoadProdaja(bs_ProdTov);

            Tuning.DobBatonSetka("Dell_Button", "Удалить", "Удалить", dataGV_ProdTov);

            using (Entities3 context = new Entities3())
            {               
                bs_Kat.DataSource = context.Т_КатегорияТовара.ToList();
                bs_Tov.DataSource = context.Т_Товар.ToList();
            

                label_Sotr.Text = (context.Т_Сотрудники.FirstOrDefault(z=>z.Код_Сотрудника == new_prodaja.Код_Продовца_П)).ФИО;
                label_Client.Text =(context.Т_Клиенты.FirstOrDefault(z => z.Код_клиента == new_prodaja.Код_Клиента_П)).ФИО_клиента;
                Date_Prod.Value = (DateTime)new_prodaja.Дата_Продажи_П;
            }

            Tuning.ComboBinding(bs_Kat, "Кат_Товара", "Код_Кат", cB_Kat);           
            

            flag = true;
            cB_Kat_SelectedIndexChanged(sender, e);
            
        }        

        
        private void dataGV_ProdTov_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dataGV_ProdTov.CurrentRow.Cells["Код"].Value;
            using (Entities3 context = new Entities3())
            {                
               Т_Продажи_Товара s = context.Т_Продажи_Товара.FirstOrDefault(z => z.Код == id);

                if (dataGV_ProdTov.Columns[e.ColumnIndex].Name == "Dell_Button")
                {
                    //Удалить выбраную запись
                    context.Т_Продажи_Товара.Remove(s);
                    context.SaveChanges();
                    LoadProdaja(bs_ProdTov);
                    res = "Запись удалена!";
                    StatusRes.Text = res; //Ставим StatusStrip, выбрать  StatusLabel
                }
            }   
            
        }
        bool f2 = false;
        private void cB_Kat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                LoadTovar(bs_Tov, (int)cB_Kat.SelectedValue);
                cB_Tov.DataBindings.Clear();
                Tuning.ComboBinding(bs_Tov, "Товар", "Код", cB_Tov); 

                f2 = true;                
                cB_Tov_SelectedIndexChanged(sender, e);
            }

        }

        private void cB_Tov_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (f2)
            {
                using (Entities3 context = new Entities3())
                {
                    var q = context.Т_Товар.FirstOrDefault(z => z.Код_Товара_Т == (int)cB_Tov.SelectedValue);
                    label_Cost.DataBindings.Clear();
                    label_Cost.DataBindings.Add("Text", q, "Цена_Реализации_Т", true);
                    
                    label_Sum.Text = $"{num_Kol.Value * q.Цена_Реализации_Т}руб.";
                }
            }

        }

        private void num_Kol_ValueChanged(object sender, EventArgs e)
        {
            label_Sum.Text = $"{num_Kol.Value * decimal.Parse(label_Cost.Text)}руб.";
        }

        private void B_Add_Click(object sender, EventArgs e)
        {
            try
            {
                using (Entities3 context = new Entities3())
                {
                    Т_Продажи_Товара newPT = new Т_Продажи_Товара();
                    newPT.Код_Продажи = new_prodaja.Код_Продажи_П;
                    newPT.Код_Катег = (int)cB_Kat.SelectedValue;
                    newPT.Код_Товара = (int)cB_Tov.SelectedValue;
                    newPT.Кол_во = (int)num_Kol.Value;
                    context.Т_Продажи_Товара.Add(newPT);
                    
                    res = "Запись добавлена!";
                    context.SaveChanges(); // Сохр.
                }
                LoadProdaja(bs_ProdTov); // Загрузить
            }
            catch (Exception exeption)
            {
                res = exeption.Message;
            }
            StatusRes.Text = res;
        }
    }


}
