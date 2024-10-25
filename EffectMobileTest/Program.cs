using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Order;

namespace EffectMobileTest
{
   internal class Program
   {
      static void Main(string[] args)
      {
         List<Booking> orders = new List<Booking>();
         Creator creator = new Creator();
         List<string> list = new List<string>() { "2,5", "Верхненовокутлумбетьево", "2024-10-01 15:59:59" };
         List<string> list1 = new List<string>() { "2,5", "Верхненовокутлумбетьево", "2024-10-01 15:59:59" };
         orders.Add(creator.FactoryMethod(list));
         orders.Add(creator.FactoryMethod(list1));
         Console.WriteLine($"{"id", -10} {"Вес", -11} {"Район доставки", -23} {"Дата и время"} ");
       
         foreach(var booking in orders) 
            Console.WriteLine(booking.ToString());
         Console.ReadLine();

      }
   }
}
