using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
   public class Reader
   {
      public string file { get; set; }
      public void ReadFile() 
      {
         using (StreamReader reader = new StreamReader(file)) 
         {
            string line = reader.ReadLine();
            string weight = line.Split(' ')[0];
            string deliveryArea = line.Split(' ')[1];
            string deliveryDate = line.Split(' ')[2];
            float.TryParse(weight, out float price);
           
         }
      }
   }
}
