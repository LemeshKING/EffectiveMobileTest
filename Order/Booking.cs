using System;
using System.Globalization;


namespace Order
{
   public class Booking
   {
      private static int CountOrders;

      public int id { get; }
      public float Weight { get; }
      public string DeliveryArea { get; }
      public DateTime DeliveryDate { get; }

      public Booking(float Weight, string DeliveryArea, DateTime DeliveryDate) 
      {
         id = ++CountOrders;
         this.Weight = Weight;
         this.DeliveryArea = DeliveryArea;
         this.DeliveryDate = DeliveryDate;
      }

      public static Booking Parse(string data)
      {
         string[] tmp = data.Split(' ');
         return new Booking(float.Parse(tmp[0], NumberStyles.Any, CultureInfo.InvariantCulture), tmp[1], DateTime.Parse(tmp[2] + " " + tmp[3]));
      }

      public override string ToString()
      {
         return $"{id, -10} {Weight + " кг", -10}  {DeliveryArea, -23} {DeliveryDate, 0:yyyy-MM-dd HH:mm:ss}";
      }
      

   }
}
