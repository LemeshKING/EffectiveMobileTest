using System.IO;


namespace Order
{
   public class Log
   {
      public static Log instance;
      public string PathFile { get; set; }

      public static Log GetInstance()
      {
         if (instance == null)
            instance = new Log();
         return instance;
      }

      public void ClearFile()
      {
         File.WriteAllText(PathFile, string.Empty);
      }

      public void WriteLog(string message) 
      {  
         using(StreamWriter writer = new StreamWriter(PathFile, true))
            writer.WriteLine(message); 
      }

   }
}
