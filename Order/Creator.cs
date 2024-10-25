using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
   public class Creator
   {
      public Booking FactoryMethod(List<string> data)
      {
         string tmp = data[0] + "_" + data[1] + "_" + data[2];
         return Booking.Parse(tmp);
      }
   }
}
