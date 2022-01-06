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
            using (Entities3 context = new Entities3())
            {
                var str = from s in context.Т_Сотрудники
                          select new
                          {// Что выводить
                              Код = s.Код_Сотрудника,
                              ФИО = s.ФИО,
                              Должность = s.Т_Должность.Должность,
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_TechnikaDataSet.Т_Сотрудники". При необходимости она может быть перемещена или удалена.
            this.т_СотрудникиTableAdapter.Fill( this.dB_TechnikaDataSet.Т_Сотрудники );
            LoadSotr( bs_Sotrydniki);

            //Настраиваем вн. вид сетки
            Tuning.ChangeViewGrid(dataGV_Sotr, Color.LightBlue);
            // Добавить кнопку "Удалить"
            Tuning.DobBatonSetka("Dell_Button", "Удалить", "Удалить", dataGV_Sotr);
            // Добавить кнопку "Изменить"
            Tuning.DobBatonSetka("Update_Button", "Изменить", "Изменить", dataGV_Sotr);

            using (Entities3 context = new Entities3())
            {
                bs_Dolzn.DataSource = context.Т_Должность.ToList();
            }
            // Привязка полей формы           
            Tuning.TextBinding(bs_Sotrydniki, "ФИО", tB_FIO_Sotr);
            //BS Откуда, Что (Поле), Что (Код), Куда (ComboBox),   Куда (BS), Имя из что выводить
            Tuning.ComboBinding(bs_Dolzn, "Должность", "Код_Должности", cB_Dolznost, bs_Sotrydniki, "КодДолжности");

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
                using (Entities3 context = new Entities3())
                {
                    if (flag)
                    {
                        Т_Сотрудники newSotr = new Т_Сотрудники();
                        newSotr.ФИО = tB_FIO_Sotr.Text;
                        newSotr.Код_Должности = (int)cB_Dolznost.SelectedValue;
                        context.Т_Сотрудники.Add(newSotr);
                        flag = false;
                        res = "Запись добавлена!";
                    }
                    //  if Редактируем запись
                    else
                    {
                        this.Text = "Внесение изменений...";
                        int idSotr = (int)dataGV_Sotr.CurrentRow.Cells["Код"].Value;
                        Т_Сотрудники rs = context.Т_Сотрудники.FirstOrDefault(x => x.Код_Сотрудника == idSotr);
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
            using (Entities3 context = new Entities3())
            {
                // Найти нужную запись
                Т_Сотрудники s = context.Т_Сотрудники.FirstOrDefault(z => z.Код_Сотрудника == id);

                if (dataGV_Sotr.Columns[e.ColumnIndex].Name == "Dell_Button")
                {
                    //Удалить выбраную запись
                    context.Т_Сотрудники.Remove(s);
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
