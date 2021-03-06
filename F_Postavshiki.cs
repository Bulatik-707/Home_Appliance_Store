using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Home_Appliance_Store
{
    public partial class F_Postavshiki : Form
    {
        public F_Postavshiki() // Форма Поставщики
        {
            InitializeComponent();
        }
        string res = "";
        bool flag = false;
        // // Вывод инфы *!
        BindingSource bs_Postavshiki = new BindingSource();
        void LoadPostavshik(BindingSource bs_Postavshiki)
        {
            ////  *** Метод для вывода \ загр. инфы  *** !!!
            using ( BitMagEntities context = new BitMagEntities())
            {
                var pst = from p in context.Поставщик
                          select new
                          {// Что выводить
                              Код = p.Код_Поставщика,
                              Поставщик = p.Поставщик1,
                              Адрес = p.Адрес,
                              Телефон = p.Телефон
                          };
                // Куда
                bs_Postavshiki.DataSource = pst.ToList();
            }

            dataGV_Postavshiki.DataSource = bs_Postavshiki;
            dataGV_Postavshiki.Columns["Код"].Visible = false; // Скрыть поле
        }
        void openForEdit()
        {
            tB_Post.ReadOnly = false;
            tB_Adres_Post.ReadOnly = false;
            maskedTB_Tell.ReadOnly = false;
            tB_Post.Focus();
        }

        private void F_Postavshiki_Load(object sender, EventArgs e)
        {
            LoadPostavshik(bs_Postavshiki);

            // Настраиваем вн.вид сетки
            Tuning.ChangeViewGrid(dataGV_Postavshiki, Color.LightBlue);
            // Добавить кнопку "Удалить"
            Tuning.DobBatonSetka("Dell_Button", "Удалить", "Удалить", dataGV_Postavshiki);
            // Добавить кнопку "Изменить"
            Tuning.DobBatonSetka("Update_Button", "Изменить", "Изменить", dataGV_Postavshiki);

            // Привязка полей формы           
            Tuning.TextBinding(bs_Postavshiki, "Поставщик", tB_Post);
            Tuning.TextBinding(bs_Postavshiki, "Адрес", tB_Adres_Post);
            Tuning.Masket(bs_Postavshiki, "Телефон", maskedTB_Tell);

        }

        private void B_Add_Click(object sender, EventArgs e)
        {
            // Добавить
            // Пустое поле ""
            tB_Post.Text = "";
            tB_Adres_Post.Text = "";
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
                        Поставщик newPost = new Поставщик();
                        newPost.Поставщик1 = tB_Post.Text;
                        newPost.Адрес = tB_Adres_Post.Text;
                        newPost.Телефон = maskedTB_Tell.Text;
                        context.Поставщик.Add(newPost);
                        flag = false;
                        res = "Запись добавлена!";
                    }
                    //  if Редактируем запись
                    else
                    {
                        this.Text = "Внесение изменений...";
                        int idPost = (int)dataGV_Postavshiki.CurrentRow.Cells["Код"].Value;
                        Поставщик rpst = context.Поставщик.FirstOrDefault(x => x.Код_Поставщика == idPost);
                        if (rpst != null)
                        {
                            rpst.Поставщик1 = tB_Post.Text;
                            rpst.Адрес = tB_Adres_Post.Text;
                            rpst.Телефон = maskedTB_Tell.Text;
                            res = "Запись сохранена!";
                        }
                    }
                    context.SaveChanges(); // Сохр.
                }
                LoadPostavshik(bs_Postavshiki); // Загрузить
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
                Поставщик pst = context.Поставщик.FirstOrDefault(z => z.Код_Поставщика == id);

                if (dataGV_Postavshiki.Columns[e.ColumnIndex].Name == "Dell_Button")
                {
                    //Удалить выбраную запись
                    context.Поставщик.Remove(pst);
                    context.SaveChanges();
                    LoadPostavshik(bs_Postavshiki);
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