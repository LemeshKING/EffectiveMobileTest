using System;
using System.Globalization;


namespace Order
{
   public class Validation
   {
      public bool WeightValidation(string data)
      {
         try
         {
            float.Parse(data, NumberStyles.Any, CultureInfo.InvariantCulture);
            return true;
         }
         catch (Exception ex) 
         {
            Log.instance.WriteLog(DateTime.Now + " Попытка добавить новый заказ. " + ex.Message + " Проверьте вес заказа.");
            return false;
         }
      }

      public bool DateTimeValidation(string data)
      {
         return DateTime.TryParseExact(data, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out _);
      }

      public bool DateTimeValidation(string data, out DateTime date)
      {
         return DateTime.TryParseExact(data, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out date);
      }
   }
}
