using System;
using System.Linq;
using System.Windows.Forms;

namespace Home_Appliance_Store
{
    public partial class F_add_Tov : Form
    {
        public F_add_Tov() // Форма добавления Товара
        {
            InitializeComponent();
        }
        BindingSource bs_newTovar = new BindingSource();
        // добавить  Инфу из Т_Товары
        BindingSource bs = new BindingSource();
        Товар new_t;
        bool flag;
        public F_add_Tov( Товар t, BindingSource bs )
        {
            InitializeComponent();
            // IF добавляем новую запись
            if (t is null)
            {
                this.new_t = new Товар();
                this.flag = true;
            }
            // If Редактируем
            else
            {
                this.new_t = t;
                this.flag = false;
            }
            this.bs = bs;
            bs_newTovar.DataSource = this.new_t;
        }
        // Созд. глоб. - context
        BitMagEntities context = new BitMagEntities();
        private void F_add_Tov_Load(object sender, EventArgs e)
        {
            BindingSource bsKat = new BindingSource();
            BindingSource bsPr = new BindingSource();

            using ( BitMagEntities context = new BitMagEntities())
            {
                bsKat.DataSource = context.КатегорияТовара.ToList();
                bsPr.DataSource = context.Производитель.ToList();
            }


            // Привязка Полей
            Tuning.ComboBinding(bsKat, "Кат_Товара", "Код_Кат", cB_Kat, bs_newTovar, "Код_КатТовара_Т");
            Tuning.ComboBinding(bsPr, "Производитель", "Код_Производителя", cB_Pr, bs_newTovar, "Код_Производителя_Т");
            Tuning.TextBinding(bs_newTovar, "Товар_Т", tB_Tovar);
//            picture_Photo.DataBindings.Add("ImageLocation", bs_newTovar, "Изображение", true);
            Tuning.NumValue(bs_newTovar, "Цена_Закупочная_Т", num_costZ);
            Tuning.NumValue(bs_newTovar, "Цена_Реализации_Т", num_costR);
            Tuning.NumValue(bs_newTovar, "Кол_во_Т", num_Kol);
            Tuning.NumData(bs_newTovar, "ДатаВыпуска", dateTime);
            Tuning.NumValue(bs_newTovar, "Гарантия", num_Gar);
        }

        private void B_Save_Click(object sender, EventArgs e)
        {
            //using (context = new Entities())
            //{
            //if добовляем запись
            if (flag)
            {
                //if (context.Студент.FirstOrDefault(x => x.АДРЕС == st.АДРЕС)!=null)
                context.Товар.Add(new_t);
                flag = false;
            }

            //  if Редактируем запись
            else
            {
                Товар t2 = context.Товар.FirstOrDefault(x => x.Код_Товара_Т == new_t.Код_Товара_Т);
                //s2.НГ = (short)cB_Gr.SelectedValue;
                t2.Товар_Т = tB_Tovar.Text;
                t2.Код_КатТовара_Т = (int)cB_Kat.SelectedValue;
                t2.Код_Производителя_Т = (int)cB_Pr.SelectedValue;
//                t2.Изображение_Т = picture_Photo.ImageLocation;
                t2.Цена_Закупочная_Т = (int)num_costZ.Value;
                t2.Цена_Реализации_Т = (int)num_costR.Value;
                t2.ДатаВыпуска = dateTime.Value.Date; 
                t2.Гарантия = (short)num_Gar.Value;
                t2.Кол_во_Т = (int)num_Kol.Value;
            }
            context.SaveChanges();
            DB_Help.Load_Tovar(bs);
            //}
        }


        private void pictureB_Izobr_Click(object sender, EventArgs e)
        {
            ToolTip tov = new ToolTip();
            tov.SetToolTip(picture_Photo, "Для выбора фото, щелкните по области изображения");

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Фото (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg; *.jpeg; *.png; *.bmp|Все файлы (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK /*&& dialog.FileName !=""*/) 
            {
                picture_Photo.ImageLocation = dialog.FileName;
                //picture_Photo.ImageLocation = dialog.FileName;
                //new_t.Изображение_Т = dialog.FileName;
            }

        }

    }
}
