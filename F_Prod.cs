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
    public partial class F_Prod : Form
    {
        public F_Prod() // Форма Продажи Товара
        {
            InitializeComponent();
        }
        
        BindingSource bs_ProdTov = new BindingSource();
        
        //Загрузка данных
        void LoadProdaja(BindingSource bs_ProdTov)
        {
            using (Entities3 context = new Entities3())
            {
                var str = from s in context.Т_Продажи_Товара
                          select new
                          {// Что выводить
                              
                              КодПродажи = s.Код_Продажи,
                              Дата = s.Т_Продажи.Дата_Продажи_П,

                              Продавец = s.Т_Продажи.Т_Сотрудники.ФИО,
                              КодПродавца = s.Т_Продажи.Код_Продовца_П,

                              Клиент = s.Т_Продажи.Т_Клиенты.ФИО_клиента,
                              КодКлиента = s.Т_Продажи.Код_Клиента_П,

                              Катег = s.Т_Товар.Т_КатегорияТовара.Кат_Товара,
                              КодКатег = s.Код_Катег,

                              Товар = s.Т_Товар.Товар_Т,
                              КодТовара = s.Код_Товара,

                              Колво = s.Кол_во,
                              Цена = s.Т_Товар.Цена_Реализации_Т,
                              Сумма = s.Т_Товар.Цена_Реализации_Т * s.Кол_во

                          };
                bs_ProdTov.DataSource = str.ToList();
            }
            dataGV_Prod.DataSource = bs_ProdTov;
            // Скрыть поля
            
            dataGV_Prod.Columns["КодПродавца"].Visible = false;
            dataGV_Prod.Columns["КодКлиента"].Visible = false;
            dataGV_Prod.Columns["КодКатег"].Visible = false;
            dataGV_Prod.Columns["КодТовара"].Visible = false;
        }

        
        private void F_Prod_Load(object sender, EventArgs e)
        {
            LoadProdaja(bs_ProdTov);

            //Настраиваем вн. вид сетки
            Tuning.ChangeViewGrid(dataGV_Prod, Color.LightBlue);
                              
        }

        private void B_Add_Click(object sender, EventArgs e)
        {
            
            F_Add_Prodaja f = new F_Add_Prodaja();
            f.Show();
            LoadProdaja(bs_ProdTov);
        }

        private void F_Prod_Activated(object sender, EventArgs e)
        {
            LoadProdaja(bs_ProdTov);
        }
    }


}
