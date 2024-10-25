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
         string list =  "2,5" + " Верхненовокутлумбетьево" + " 2024-10-01 15:59:59" ;
         string list1 = "2,5" + " Верхненовокутлумбетьево" + " 2024-10-01 15:59:59" ;
         Reader reader = new Reader();
         reader.file = "../../input.txt";
         orders = reader.ReadFile();
         Console.WriteLine($"{"id", -10} {"Вес", -11} {"Район доставки", -23} {"Дата и время"} ");
       
         foreach(var booking in orders) 
            Console.WriteLine(booking.ToString());
         Console.ReadLine();

      }
   }
}
