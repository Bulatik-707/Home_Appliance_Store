using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Home_Appliance_Store
{
    public partial class F_Sotr : Form
    {
        public F_Sotr() // Форма Сотрудники
        {
            InitializeComponent();
        }
       
        BindingSource bs_Dolzn = new BindingSource();
        BindingSource bs_Sotrydniki = new BindingSource();
        string res = "";
        bool flag = false;

        //Загрузка данных
        void LoadSotr(BindingSource bs_Sotrydniki)
        {
            using ( BitMagEntities context = new BitMagEntities() )
            {
                var str = from s in context.Сотрудники
                          select new
                          {// Что выводить
                              Код = s.Код_Сотрудника,
                              ФИО = s.ФИО,
                              Должность = s.Должность.Должность1,
                              КодДолжности = s.Код_Должности
                          };
                bs_Sotrydniki.DataSource = str.ToList();
            }
            dataGV_Sotr.DataSource = bs_Sotrydniki;
            // Скрыть поля
            dataGV_Sotr.Columns["Код"].Visible = false;
            dataGV_Sotr.Columns["КодДолжности"].Visible = false;
        }

        void openForEdit()
        {
            tB_FIO_Sotr.ReadOnly = false;
            cB_Dolznost.Enabled = true;
            tB_FIO_Sotr.Focus();
        }

        private void F_Sotr_Load(object sender, EventArgs e)
        {
            //Настраиваем вн. вид сетки
            Tuning.ChangeViewGrid(dataGV_Sotr, Color.LightBlue);
            // Добавить кнопку "Удалить"
            Tuning.DobBatonSetka("Dell_Button", "Удалить", "Удалить", dataGV_Sotr);
            // Добавить кнопку "Изменить"
            Tuning.DobBatonSetka("Update_Button", "Изменить", "Изменить", dataGV_Sotr);

            using ( BitMagEntities context = new BitMagEntities() )
            {
                bs_Dolzn.DataSource = context.Должность.ToList();
            }
            // Привязка полей формы           
            Tuning.TextBinding( bs_Sotrydniki, "ФИО", tB_FIO_Sotr );
            //BS Откуда, Что (Поле), Что (Код), Куда (ComboBox),   Куда (BS), Имя из что выводить
            Tuning.ComboBinding( bs_Dolzn, "Должность", "Код_Должности", cB_Dolznost, bs_Sotrydniki, "КодДолжности" );

        }

        private void B_Add_Click(object sender, EventArgs e)
        {
            //label_Info.Text = "***"; // Оставить / сохр.???

            // Добавить
            tB_FIO_Sotr.Text = "";
            cB_Dolznost.SelectedIndex = 0;
            flag = true;
            this.Text = "Добавление нового сотрудника...";
            openForEdit();

        }

        private void B_Save_Click(object sender, EventArgs e)
        {
            // Сохранить
            //if добавляем запись
            try
            {
                using ( BitMagEntities context = new BitMagEntities() )
                {
                    if (flag)
                    {
                        Сотрудники newSotr = new Сотрудники();
                        newSotr.ФИО = tB_FIO_Sotr.Text;
                        newSotr.Код_Должности = (int)cB_Dolznost.SelectedValue;
                        context.Сотрудники.Add(newSotr);
                        flag = false;
                        res = "Запись добавлена!";
                    }
                    //  if Редактируем запись
                    else
                    {
                        this.Text = "Внесение изменений...";
                        int idSotr = (int)dataGV_Sotr.CurrentRow.Cells["Код"].Value;
                        Сотрудники rs = context.Сотрудники.FirstOrDefault(x => x.Код_Сотрудника == idSotr);
                        if (rs != null)
                        {
                            rs.ФИО = tB_FIO_Sotr.Text;
                            rs.Код_Должности = (int)cB_Dolznost.SelectedValue;
                            res = "Запись сохранена!";
                        }

                    }
                    context.SaveChanges(); // Сохр.
                }
                LoadSotr(bs_Sotrydniki); // Загрузить
            }
            catch (Exception exeption)
            {
                res = exeption.Message;
            }
            StatusRes.Text = res; //Ставим StatusStrip, выбрать  StatusLabel

        }

        private void dataGV_Sotr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dataGV_Sotr.CurrentRow.Cells["Код"].Value;
            using ( BitMagEntities context = new BitMagEntities() )
            {
                // Найти нужную запись
                Сотрудники s = context.Сотрудники.FirstOrDefault(z => z.Код_Сотрудника == id);

                if (dataGV_Sotr.Columns[e.ColumnIndex].Name == "Dell_Button")
                {
                    //Удалить выбраную запись
                    context.Сотрудники.Remove(s);
                    context.SaveChanges();
                    LoadSotr(bs_Sotrydniki);
                    res = "Запись удалена!";
                    StatusRes.Text = res; //Ставим StatusStrip, выбрать  StatusLabel
                }
            }

            if (dataGV_Sotr.Columns[e.ColumnIndex].Name == "Update_Button")
            {
                openForEdit();
            }

        }

    }
}