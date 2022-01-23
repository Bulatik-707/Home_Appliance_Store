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
    public partial class F_Tovar : Form
    {
        public F_Tovar() // Форма Товары
        {
            InitializeComponent();
        }
        BindingSource bs_Tovar = new BindingSource(); // здесь хран. ТОВАРЫ

        private void F_Tovar_Load(object sender, EventArgs e)
        {
            ////  *** Метод для вывода \ загр. инфы  *** !!!
            DB_Help.Load_Tovar(bs_Tovar); // Загр. даных из дб_хелп, с именем "Load_Tovar" в bs_Tovar

            dataGV_Tovar.DataSource = bs_Tovar; // Даные в грид из БС
            // Скрыть поля
            dataGV_Tovar.Columns["Код"].Visible = false;
            dataGV_Tovar.Columns["КодКат"].Visible = false;
            dataGV_Tovar.Columns["КодПроизводителя"].Visible = false;
            dataGV_Tovar.Columns["Сумма"].Visible = false;

            //Настраиваем вн. вид сетки
            Tuning.ChangeViewGrid(dataGV_Tovar, Color.LightBlue);
            // Добавить кнопку "Удалить"
            Tuning.DobBatonSetka("Dell_Baton", "Удалить", "Удалить", dataGV_Tovar);
            // Добавить кнопку "Подробно"
            Tuning.DobBatonSetka("Podr_Baton", "Подробно", "Изменить", dataGV_Tovar);

        }

        private void B_add_Tov_Click(object sender, EventArgs e)
        {// Доб. новую запись
            F_add_Tov f = new F_add_Tov(null, bs_Tovar);
            f.ShowDialog();
        }

        private void dataGV_Tovar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using ( BitMagEntities context = new BitMagEntities() )
            {
                int id = (int)dataGV_Tovar.CurrentRow.Cells["Код"].Value;
                // Найти нужную запись
                // Найти тек. V-т
                Товар t = context.Товар.FirstOrDefault(z => z.Код_Товара_Т == id);
                // У всех Z  у которых  z.НСтуд == id
                //    //if НАЖАТА КНОПКА Удалить
                if (dataGV_Tovar.Columns[e.ColumnIndex].Name == "Dell_Baton")
                {
                    //Удалить выбраную запись
                    context.Товар.Remove(t);
                    //Сохр. изменения
                    context.SaveChanges();
                    //Перезагрузка табл.
                    DB_Help.Load_Tovar(bs_Tovar);

                }
                //    //if НАЖАТА КНОПКА Подробно / Изменить
                if (dataGV_Tovar.Columns[e.ColumnIndex].Name == "Podr_Baton")
                {
                    F_add_Tov f = new F_add_Tov(t, bs_Tovar);
                    f.ShowDialog();
                }
            }

        }

    }
}
