using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Order
{
   public class Booking
   {
      private static int CountOrders;
      public int id { get; }
      public float _Weight { get; }
      public string _DeliveryArea { get; }
      public DateTime _DeliveryDate { get; }

      public Booking(float Weight, string DeliveryArea, DateTime DeliveryDate) 
      {
         id = ++CountOrders;
         _Weight = Weight;
         _DeliveryArea = DeliveryArea;
         _DeliveryDate = DeliveryDate;
      }

    

      public static Booking Parse(string data)
      {
         string[] tmp = data.Split(' ');
         return new Booking(float.Parse(tmp[0], NumberStyles.Any, CultureInfo.InvariantCulture), tmp[1], DateTime.Parse(tmp[2] + " " + tmp[3]));
      }

      public override string ToString()
      {
         return $"{id, -10} {_Weight + " кг", -10}  {_DeliveryArea, -23} {_DeliveryDate, 0:yyyy-MM-dd HH:mm:ss}";
      }
      

   }
}
