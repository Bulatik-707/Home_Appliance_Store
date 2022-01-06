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
    public partial class F_Postavki : Form
    {
        public F_Postavki() // Форма Поставки Товара
        {
            InitializeComponent();
        }

        BindingSource bs_PostTov = new BindingSource();
        //Загрузка данных
        void LoadPost(BindingSource bs_PostTov)
        {
            using (Entities3 context = new Entities3())
            {
                var str = from s in context.Т_ПоставкиТовара
                          select new
                          {// Что выводить
                              КодПоставки = s.КодПоставки,
                              Дата = s.Т_Поставки.ДатаПоставки,

                              Поставщик = s.Т_Поставки.Т_Поставщик.Поставщик,
                              КодПоставщика = s.Т_Поставки.Код_Поставщика_ПТ,

                              Катег = s.Т_Товар.Т_КатегорияТовара.Кат_Товара,
                              КодКатег = s.КодКат_Товара,

                              Товар = s.Т_Товар.Товар_Т,
                              КодТовара = s.КодТовара,

                              Колво = s.Кол_во,
                              Цена = s.Т_Товар.Цена_Реализации_Т,
                              Сумма = s.Т_Товар.Цена_Реализации_Т * s.Кол_во
                          };
                bs_PostTov.DataSource = str.ToList();
            }
            dataGV_Post.DataSource = bs_PostTov;
            // Скрыть поля
            dataGV_Post.Columns["КодПоставщика"].Visible = false;
            dataGV_Post.Columns["КодКатег"].Visible = false;
            dataGV_Post.Columns["КодТовара"].Visible = false;

        }

        private void F_Postavki_Load(object sender, EventArgs e)
        {
            LoadPost(bs_PostTov);
            //Настраиваем вн. вид сетки
            Tuning.ChangeViewGrid(dataGV_Post, Color.LightBlue);

        }
        private void B_Add_Click(object sender, EventArgs e)
        {
            F_Add_Postavki f = new F_Add_Postavki();
            f.Show();
            LoadPost(bs_PostTov);
        }
        private void F_Postavki_Activated(object sender, EventArgs e)
        {
            LoadPost(bs_PostTov);
        }

    }
}
    

