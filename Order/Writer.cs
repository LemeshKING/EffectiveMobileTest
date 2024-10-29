using System;
using System.IO;


namespace Order
{
   public class Writer
   {
      public string FilePath { get; set; }

      public void ClearFile()
      {
         File.WriteAllText(FilePath, string.Empty);
      }

      public void Write(string text) 
      {
         try
         {
            using (StreamWriter writer = new StreamWriter(FilePath, true))
            {
               Log.instance.WriteLog(DateTime.Now + " Запись в файл с результатами фильтрации");
               writer.WriteLine(text);
            }
         }
         catch (Exception ex) 
         {
            Log.instance.WriteLog(DateTime.Now + " " + ex.Message);
         }
      }
   }
}
