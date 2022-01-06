using System.Linq;
using System.Windows.Forms;

namespace Home_Appliance_Store
{
    class DB_Help
    {
        // Метод на загрузку инфы из Т_Студент
        public static void Load_Tovar(BindingSource bs_Tovar)
        {
            using (Entities3 context = new Entities3())
            {
                var a = from t in context.Т_Товар
                        select new
                        {// Что выводить
                            Код = t.Код_Товара_Т,
                            Кат = t.Т_КатегорияТовара.Кат_Товара,
                            КодКат = t.Код_КатТовара_Т,
                            Производитель = t.Т_Производитель.Производитель,
                            КодПроизводителя = t.Код_Производителя_Т,
                            Товар = t.Товар_Т,
 //                           Изображение = t.Изображение_Т,
                            Ц_Зак = t.Цена_Закупочная_Т,
                            Ц_Реал = t.Цена_Реализации_Т,
                            Дата_произв = t.ДатаВыпуска,
                            Гарантия = t.Гарантия,
                            Кол_во = t.Кол_во_Т,
                            Сумма = t.Цена_Реализации_Т * t.Кол_во_Т                     
                        };
                // Куда
                bs_Tovar.DataSource = a.ToList();
            }
        }
        public static void L_Prod(BindingSource bs_Prod)
        {
            using (Entities3 context = new Entities3())
            {
                var b = from p in context.Т_Продажи
                        select new
                        {

                        };
                bs_Prod.DataSource = b.ToList();
            }
        }
    }
}
