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
    public partial class F_Proizvod : Form
    {
        public F_Proizvod() // Форма Производители
        {
            InitializeComponent();
        }
        BindingSource bs_Proizvoditeli = new BindingSource();
        // здесь хран. Производители
        string res = "";
        bool flag = false;

        //Загрузка данных
        void LoadSotr(BindingSource bs_Proizvoditeli)
        {
            using ( BitMagEntities context = new BitMagEntities() )
            {
                var pr = from p in context.Производитель
                          select new
                          {// Что выводить
                              Код = p.Код_Производителя,
                              Производитель = p.Производитель1,
                              Наценка = p.Наценка
                              //Должность = s.Должность.Должность,
                              //КодДолжности = s.Код_Должности
                          };
                bs_Proizvoditeli.DataSource = pr.ToList();
            }
            dataGV_Proizvod.DataSource = bs_Proizvoditeli;
            // Скрыть поля
            dataGV_Proizvod.Columns["Код"].Visible = false;

        }

        void openForEdit()
        {
            tB_Pr.ReadOnly = false;
            num_Nasenka.ReadOnly = false;
//            cB_Dolznost.Enabled = true;
            tB_Pr.Focus();
        }
        private void F_Proizvod_Load(object sender, EventArgs e)
        {
            LoadSotr(bs_Proizvoditeli);

            //Настраиваем вн. вид сетки
            Tuning.ChangeViewGrid(dataGV_Proizvod, Color.LightBlue);
            // Добавить кнопку "Удалить"
            Tuning.DobBatonSetka("Dell_Button", "Удалить", "Удалить", dataGV_Proizvod);
            // Добавить кнопку "Изменить"
            Tuning.DobBatonSetka("Update_Button", "Изменить", "Изменить", dataGV_Proizvod);


            // Привязка полей формы           
            Tuning.TextBinding(bs_Proizvoditeli, "Производитель", tB_Pr);
            Tuning.NumValue(bs_Proizvoditeli, "Наценка", num_Nasenka);
        }

        private void B_Add_Click(object sender, EventArgs e)
        {
            //label_Info.Text = "***"; // Оставить / сохр.???

            // Добавить
            tB_Pr.Text = "";
            num_Nasenka.Value = 0;
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
                        Производитель newPr = new Производитель();
                        newPr.Производитель1 = tB_Pr.Text;
                        newPr.Наценка = (short)num_Nasenka.Value;
                        context.Производитель.Add(newPr);
                        flag = false;
                        res = "Запись добавлена!";
                    }
                    //  if Редактируем запись
                    else
                    {
                        this.Text = "Внесение изменений...";
                        int idPrz = (int)dataGV_Proizvod.CurrentRow.Cells["Код"].Value;
                        Производитель rp = context.Производитель.FirstOrDefault(x => x.Код_Производителя == idPrz);
                        if (rp != null)
                        {
                            rp.Производитель1 = tB_Pr.Text;
                            rp.Наценка = (short)num_Nasenka.Value;
                            res = "Запись сохранена!";
                        }

                    }
                    context.SaveChanges(); // Сохр.
                }
                LoadSotr(bs_Proizvoditeli); // Загрузить
            }
            catch (Exception exeption)
            {
                res = exeption.Message;
            }
            StatusRes.Text = res; //Ставим StatusStrip, выбрать  StatusLabel

        }

        private void dataGV_Proizvod_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dataGV_Proizvod.CurrentRow.Cells["Код"].Value;
            using ( BitMagEntities context = new BitMagEntities() )
            {
                // Найти нужную запись
                Производитель p = context.Производитель.FirstOrDefault(z => z.Код_Производителя == id);

                if (dataGV_Proizvod.Columns[e.ColumnIndex].Name == "Dell_Button")
                {
                    //Удалить выбраную запись
                    context.Производитель.Remove(p);
                    context.SaveChanges();
                    LoadSotr(bs_Proizvoditeli);
                    res = "Запись удалена!";
                    StatusRes.Text = res; //Ставим StatusStrip, выбрать  StatusLabel
                }
            }

            if (dataGV_Proizvod.Columns[e.ColumnIndex].Name == "Update_Button")
            {
                openForEdit();
            }


        }

    }
}