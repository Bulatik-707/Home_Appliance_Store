using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Home_Appliance_Store
{
    class DB
    {
        // Настроить подключение
        static string ConnectionString = Properties.Settings.Default.BitMag;

        public static SqlConnection Conn => new SqlConnection(ConnectionString);
        // Создать набор даных
        public static DataSet ds = new DataSet();
        // Загрузить в набор даных рез. выполнения запроса ТАБЛИЦУ
        public static DataTable LoadTable(string query, string nameTable)
        {
            SqlCommand Comand = Conn.CreateCommand();
            Comand.CommandText = query;
            SqlDataAdapter DA = new SqlDataAdapter(Comand);
            if (!ds.Tables.Contains(nameTable))
            {
                DA.Fill(ds, nameTable);
            }
            return ds.Tables[nameTable];
        }
        // Команда ля добавления даных в любую таблицу
        public static int insertData(string nameProc, string tableNAme, List<Param> listParams, Param outParam)
        {
            // Команда
            SqlCommand Komand_Dob_Zap = Conn.CreateCommand();
            Komand_Dob_Zap.CommandType = CommandType.StoredProcedure;
            Komand_Dob_Zap.CommandText = nameProc;

            //Входные параметры со значениями в колекцию параметров команды
            foreach (Param p in listParams)
            {
                Komand_Dob_Zap.Parameters.AddWithValue(p.paramName, p.paramValue);
            }
            // Доб. в команду выходной парамерт - id доб. записи
            Komand_Dob_Zap.Parameters.Add(outParam.paramName, outParam.paramType);
            Komand_Dob_Zap.Parameters[outParam.paramName].Direction = ParameterDirection.Output;

            // Обновимть даные в табл
            SqlDataAdapter Adapter = new SqlDataAdapter(Komand_Dob_Zap);
            if (ds.Tables.Contains(tableNAme))
            {
                ds.Tables[tableNAme].Clear();
            }
            Adapter.Fill(ds, tableNAme);

            // Вернуть id добавленой записи
            return (int)Komand_Dob_Zap.Parameters["@id"].Value;
        }

        // Метод на Обновление записи из табл.
        public static void UpdateData(string nameProc, string tableName, List<Param> listParams)
        {
            // Команда
            SqlCommand Komand_Upd_Zap = Conn.CreateCommand();
            Komand_Upd_Zap.CommandType = CommandType.StoredProcedure;
            Komand_Upd_Zap.CommandText = nameProc;

            //Входные параметры со значениями в колекцию параметров команды
            foreach (Param p in listParams)
            {
                Komand_Upd_Zap.Parameters.AddWithValue(p.paramName, p.paramValue);
            }
            // Обновимть даные в табл
            SqlDataAdapter Adapter = new SqlDataAdapter(Komand_Upd_Zap);
            if (ds.Tables.Contains(tableName))
            {
                ds.Tables[tableName].Clear();
            }
            Adapter.Fill(ds, tableName);
        }
    }
}