using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Home_Appliance_Store
{
    public partial class F_Post_Tovar : Form
    {
        public F_Post_Tovar() // Форма Поставка Товара
        {
            InitializeComponent();
        }

        Поставки new_postavka;
        public F_Post_Tovar(Поставки postavka)
        {
            InitializeComponent();
            this.new_postavka = postavka;
        }

        BindingSource bs_Kat = new BindingSource();
        BindingSource bs_Tov = new BindingSource();
        BindingSource bs_PostTov = new BindingSource();

        string res = "";
        bool flag = false;

        //Загрузка данных
        void LoadPost(BindingSource bs_PostTov)
        {
            using ( BitMagEntities context = new BitMagEntities() )
            {
                var str = from s in context.ПоставкиТовара
                          where s.КодПоставки == new_postavka.Код_Поставки_ПТ
                          select new
                          {
                              Код = s.КодПоставки,
                              Катег = s.Товар.КатегорияТовара.Кат_Товара,
                              Товар = s.Товар.Товар_Т,
                              Колво = s.Кол_во,
                              Цена = s.Товар.Цена_Реализации_Т,
                              Сумма = s.Товар.Цена_Реализации_Т * s.Кол_во

                          };
                bs_PostTov.DataSource = str.ToList();
                label_Itogo.Text = $"{str.Sum(z => z.Сумма)}";
            }
            dataGV_ProdTov.DataSource = bs_PostTov;
        }

        //Загрузка данных
        void LoadTovar(BindingSource bs_Tov, int kodKat)
        {
            using ( BitMagEntities context = new BitMagEntities() )
            {
                var Tov = from t in context.Товар
                          where t.Код_КатТовара_Т == kodKat
                          select new
                          {
                              Код = t.Код_Товара_Т,
                              Товар = t.Товар_Т,
                              ценаРеализации = t.Цена_Реализации_Т,
                          };
                bs_Tov.DataSource = Tov.ToList();
            }
        }
        private void F_Post_Tovar_Load(object sender, EventArgs e)
        {
            LoadPost(bs_PostTov);

            Tuning.DobBatonSetka("Dell_Button", "Удалить", "Удалить", dataGV_ProdTov);

            using ( BitMagEntities context = new BitMagEntities() )
            {
                bs_Kat.DataSource = context.КатегорияТовара.ToList();
                bs_Tov.DataSource = context.Товар.ToList();


                label_Postavshik.Text = context.Поставщик.FirstOrDefault( z => z.Код_Поставщика == new_postavka.Код_Поставщика_ПТ ).Поставщик1;
                Date_Pst.Value = (DateTime)new_postavka.ДатаПоставки;
            }

            Tuning.ComboBinding(bs_Kat, "Кат_Товара", "Код_Кат", cB_Kat);


            flag = true;
            cB_Kat_SelectedIndexChanged(sender, e);

        }
        private void dataGV_ProdTov_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dataGV_ProdTov.CurrentRow.Cells["Код"].Value;
            using ( BitMagEntities context = new BitMagEntities() )
            {
                ПоставкиТовара s = context.ПоставкиТовара.FirstOrDefault( z => z.КодПоставки == id );

                if ( dataGV_ProdTov.Columns[e.ColumnIndex].Name == "Dell_Button" )
                {
                    //Удалить выбраную запись
                    context.ПоставкиТовара.Remove(s);
                    context.SaveChanges();
                    LoadPost(bs_PostTov);
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
                using ( BitMagEntities context = new BitMagEntities() )
                {
                    var q = context.Товар.FirstOrDefault(z => z.Код_Товара_Т == (int)cB_Tov.SelectedValue);
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
                using ( BitMagEntities context = new BitMagEntities() )
                {
                    ПоставкиТовара newPT = new ПоставкиТовара();
                    newPT.КодПоставки = new_postavka.Код_Поставки_ПТ;
                    newPT.КодКат_Товара = (int)cB_Kat.SelectedValue;
                    newPT.КодТовара = (int)cB_Tov.SelectedValue;
                    newPT.Кол_во = (int)num_Kol.Value;
                    context.ПоставкиТовара.Add(newPT);
                    res = "Запись добавлена!";
                    context.SaveChanges(); // Сохр.
                }
                LoadPost(bs_PostTov); // Загрузить
            }
            catch (Exception exeption)
            {
                res = exeption.Message;
            }
            StatusRes.Text = res;

        }


    }
}
