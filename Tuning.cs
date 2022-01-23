using System.Drawing;
using System.Windows.Forms;

namespace Home_Appliance_Store
{
    class Tuning
    {
        // Изменить вид сетки
        public static void ChangeViewGrid(DataGridView grid, Color color)
        {
            // Цвет чередующихся строк
            grid.AlternatingRowsDefaultCellStyle.BackColor = color;// Color.LightGray;
            //  Цвет фона сетки
            grid.BackgroundColor = Color.White;
            // Сделать заголовок строк НЕвидимыми
            grid.RowHeadersVisible = false;
            // Установить выделение строки целиком
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // Убрать доп.(новую) пустую строку
            grid.AllowUserToAddRows = false;
            // Сетка заполняется так, чтобы вошла ВСЯ инфа
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Установить режим раб. сетки - "ТОЛЬКО ДЛЯ ЧТЕНИЯ"
            grid.ReadOnly = true;
        }
        // Сделать указынные столбцы НЕВИДИМЫМИ (Назв. строки, Сетка)
        public static void NotVisebleColumnGrid(string[] columnNames, DataGridView data)
        {
            foreach (var Z in columnNames)
            {
                data.Columns[Z].Visible = false;
            }
        }
        // Настройка привязки TextBox
        // куда (зап.), что (столбец), откуда брать даные.
        public static void TextBinding(BindingSource bs, string field, TextBox TB)
        {
            TB.DataBindings.Add( "Text", bs, field, true );
        }

        //  Настройка привязки ComboBox
        public static void ComboBinding(BindingSource bs, string displayField, string valueField, ComboBox Combo)
        {
            Combo.DataSource = bs;
            Combo.DisplayMember = displayField;
            Combo.ValueMember = valueField;
        }
        //  Настройка привязки ComboBox
        // BS (откуда берем), Название, Код_*, Куда (comoBox), в какой BS (куда), new имя поля в сетке **.
        //BS Откуда, Что (Поле), Что (Код), Куда (ComboBox), Куда (BS), Имя new
      public static void ComboBinding(BindingSource bs, string displayField, string valueField, ComboBox Combo, BindingSource bsTarget, string valueFieldTarget)
        {
            Combo.DataSource = bs;
            Combo.DisplayMember = displayField;
            Combo.ValueMember = valueField;
            Combo.DataBindings.Add("SelectedValue", bsTarget, valueFieldTarget, true);
        }
        // Настройка привязки  DateTimePicker
        public static void NumData(BindingSource bs, string field, DateTimePicker dt)
        {
            dt.DataBindings.Add("Value", bs, field, true);
        }
        // Настройка привязки Numeric
        public static void NumValue(BindingSource bs, string field, NumericUpDown num)
        {
           num.DataBindings.Add("Value", bs, field, true);
        }
        // Настройка привязки MaskedTextBox
        public static void Masket(BindingSource bs, string field, MaskedTextBox MTB)
        {
            MTB.DataBindings.Add("Text", bs, field, true);
        }
       
        // Метод для добавления кнопок в сетку
        public static void DobBatonSetka(string Name, string Zagolowok_Stolbsa, string Text_in_Baton, DataGridView grid)
        {
            if (!grid.Columns.Contains(Name)) // Если столбец УЖЕ не добавлен
            {
                DataGridViewButtonColumn columName = new DataGridViewButtonColumn();
                columName.Name = Name;
                columName.HeaderText = Zagolowok_Stolbsa;
                columName.Text = Text_in_Baton;
                columName.UseColumnTextForButtonValue = true;
                grid.Columns.Add(columName);
            }
        }
    }
}