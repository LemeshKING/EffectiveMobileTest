using System;
using System.Linq;
using Order;

namespace EffectMobileTest
{
   internal class Program
   {
      static void Main(string[] args)
      {
         if (args.Length < 3)
         {
            Console.WriteLine("Необходимы параметры: <cityDistrict> <firstDeliveryDateTime> <deliveryLog>");
            Console.ReadLine();
            return;
         }

         string _cityDistrict = args[0]; /*"Кировский"*/;

         Validation verifier = new Validation();
         DateTime _firstDeliveryDateTime /*= new DateTime(2024,06,23,23,10,0)*/;

         if (!verifier.DateTimeValidation(args[1], out _firstDeliveryDateTime))
         {
            Console.WriteLine("Неверный формат даты и времени для фильтрации");
            return;
         }
         string _deliveryLog = args[2] /*"Logs.txt"*/;

         Log.GetInstance();
         Log.instance.PathFile = _deliveryLog;
         Log.instance.ClearFile();

         Reader reader = new Reader();
         reader.FilePath = "../../input.txt";
      
         var bookings = reader.ReadFile();  
         var ln = bookings.Where(x => x.DeliveryArea == _cityDistrict && (x.DeliveryDate - _firstDeliveryDateTime).TotalMinutes < 30 && 
         (x.DeliveryDate - _firstDeliveryDateTime).TotalMinutes >= 0).OrderBy(x => x.DeliveryDate);

         Writer writer = new Writer();
         string _deliveryOrder = "result.txt";
         writer.FilePath = _deliveryOrder;
         writer.ClearFile();
         writer.Write($"{"id", -10} {"Вес", -11} {"Район доставки", -23} {"Дата и время"} ");
       
         foreach(var booking in ln)
            writer.Write(booking.ToString());
         
         Console.ReadLine();

      }
   }
}
