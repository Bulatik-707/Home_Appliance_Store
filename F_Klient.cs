using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Home_Appliance_Store
{
    public partial class F_Klient : Form
    {
        public F_Klient() // Форма Клиенты
        {
            InitializeComponent();
        }
        string res = "";
        bool flag = false;
        // // Вывод инфы *!
        BindingSource bs_Klienti = new BindingSource();
        void LoadPostavshik(BindingSource bs_Klienti)
        {
            ////  *** Метод для вывода \ загр. инфы  *** !!!
            using ( BitMagEntities context = new BitMagEntities() )
            {
                var kl = from k in context.Клиенты
                          select new
                          {// Что выводить
                              Код = k.Код_клиента,
                              ФИО = k.ФИО_клиента,
                              Телефон = k.Телефон
                          };
                // Куда
                bs_Klienti.DataSource = kl.ToList();
            }

            dataGV_Postavshiki.DataSource = bs_Klienti;
            dataGV_Postavshiki.Columns["Код"].Visible = false; // Скрыть поле
        }
        void openForEdit()
        {
            tB_FIO.ReadOnly = false;
            maskedTB_Tell.ReadOnly = false;
            tB_FIO.Focus();
        }

        private void F_Klient_Load(object sender, EventArgs e)
        {
            LoadPostavshik(bs_Klienti);

            // Настраиваем вн.вид сетки
            Tuning.ChangeViewGrid(dataGV_Postavshiki, Color.LightBlue);
            // Добавить кнопку "Удалить"
            Tuning.DobBatonSetka("Dell_Button", "Удалить", "Удалить", dataGV_Postavshiki);
            // Добавить кнопку "Изменить"
            Tuning.DobBatonSetka("Update_Button", "Изменить", "Изменить", dataGV_Postavshiki);

            // Привязка полей формы           
            Tuning.TextBinding(bs_Klienti, "ФИО", tB_FIO);
            Tuning.Masket(bs_Klienti, "Телефон", maskedTB_Tell);
        }
        private void B_Add_Click(object sender, EventArgs e)
        {
            // Добавить
            // Пустое поле ""
            tB_FIO.Text = "";
            maskedTB_Tell.Text = "";
            flag = true;
            this.Text = "Добавление нового поставщика...";
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
                        Клиенты newKl = new Клиенты();
                        newKl.ФИО_клиента = tB_FIO.Text;
                        newKl.Телефон = maskedTB_Tell.Text;
                        context.Клиенты.Add(newKl);
                        flag = false;
                        res = "Запись добавлена!";
                    }
                    //  if Редактируем запись
                    else
                    {
                        this.Text = "Внесение изменений...";
                        int idPost = (int)dataGV_Postavshiki.CurrentRow.Cells["Код"].Value;
                        Клиенты rkl = context.Клиенты.FirstOrDefault(x => x.Код_клиента == idPost);
                        if (rkl != null)
                        {
                            rkl.ФИО_клиента = tB_FIO.Text;
                            rkl.Телефон = maskedTB_Tell.Text;
                            res = "Запись сохранена!";
                        }
                    }
                    context.SaveChanges(); // Сохр.
                }
                LoadPostavshik(bs_Klienti); // Загрузить
            }
            catch (Exception exeption)
            {
                res = exeption.Message;
            }
            StatusRes.Text = res; //Ставим StatusStrip, выбрать  StatusLabel

        }
        private void dataGV_Postavshiki_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dataGV_Postavshiki.CurrentRow.Cells["Код"].Value;
            using ( BitMagEntities context = new BitMagEntities() )
            {
                // Найти нужную запись
                Клиенты klts = context.Клиенты.FirstOrDefault(z => z.Код_клиента == id);

                if (dataGV_Postavshiki.Columns[e.ColumnIndex].Name == "Dell_Button")
                {
                    //Удалить выбраную запись
                    context.Клиенты.Remove(klts);
                    context.SaveChanges();
                    LoadPostavshik(bs_Klienti);
                    res = "Запись удалена!";
                    StatusRes.Text = res; //Ставим StatusStrip, выбрать  StatusLabel
                }
            }

            if (dataGV_Postavshiki.Columns[e.ColumnIndex].Name == "Update_Button")
            {
                openForEdit();
            }

        }

    }
}