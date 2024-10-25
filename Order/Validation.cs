using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine(ex.Message + " Проверьте вес заказа.");
            return false;
         }
      }
      public bool DateTimeValidation(string data)
      {
         return DateTime.TryParseExact(data, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out _);
      }
   }
}
