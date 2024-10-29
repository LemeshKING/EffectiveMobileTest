using System;
using System.Collections.Generic;
using System.IO;


namespace Order
{
   public class Reader
   {
      public string FilePath { get; set; }
     
      public List<Booking> ReadFile() 
      {
         List<Booking> bookings = new List<Booking>();
         Validation verifier = new Validation();

         try
         {
            using (StreamReader reader = new StreamReader(FilePath))
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
                     Log.instance.WriteLog(DateTime.Now + " Попытка добавить новый заказ. Входная строка имела неверный формат. Проверьте формат даты и времени заказа в входном файле.");
                     continue;
                  }

                  Log.instance.WriteLog(DateTime.Now + " Добавление нового заказа с id " + (bookings.Count + 1));

                  Creator creator = new Creator();
                  bookings.Add(creator.FactoryMethod(line));


               }
            }
         }
         catch (Exception ex) { Log.instance.WriteLog(DateTime.Now + " " + ex.Message); }
           

         return bookings;
         
      }
   }
}
