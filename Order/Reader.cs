using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
   public class Reader
   {
      public string file { get; set; }
     
      public List<Booking> ReadFile() 
      {
         List<Booking> bookings = new List<Booking>();
         Validation verifier = new Validation();
         try
         {
            using (StreamReader reader = new StreamReader(file))
            {

               while (!reader.EndOfStream)
               {
                  string line = reader.ReadLine();
                  string weight = line.Split(' ')[0];
                  string deliveryArea = line.Split(' ')[1];
                  string deliveryDate = line.Split(' ')[2] + " " + line.Split(' ')[3];
                  if (!verifier.WeightValidation(weight))
                     continue;

                 
                  if (!verifier.DateTimeValidation(deliveryDate))
                  {
                     Console.WriteLine("Проверьте формат даты и времени заказа в входном файле.");
                     continue;
                  }
                  Creator creator = new Creator();
                  bookings.Add(creator.FactoryMethod(line));


               }
            }
         }
         catch (Exception ex) { Console.WriteLine(ex.Message); }
           

         return bookings;
         
      }
   }
}
