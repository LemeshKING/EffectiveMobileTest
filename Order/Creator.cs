using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
