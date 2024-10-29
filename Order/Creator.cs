

namespace Order
{
   public class Creator
   {
      public Booking FactoryMethod(string data)
      {
         return Booking.Parse(data);
      }
   }
}
