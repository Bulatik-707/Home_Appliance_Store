using System.Data;

namespace Home_Appliance_Store
{
    // Класс для раб. с ПАРАМЕТРАМИ
    class Param
   {
        public string paramName { get; set; }
        public object paramValue { get; set; }
        public SqlDbType paramType { get; set; }
    
        // МЕТОД
      public Param(string paramName, object paramValue, SqlDbType paramType = SqlDbType.NVarChar)
      {
        this.paramName = paramName;
        this.paramValue = paramValue;
        this.paramType = paramType;
      }
        // МЕТОД
       public Param(string paramName, SqlDbType paramType)
        {
        this.paramName = paramName;
        this.paramType = paramType;
        }
   }
}