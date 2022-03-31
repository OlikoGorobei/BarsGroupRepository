using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public interface ILogger 
        {
            public string LogInfo (string message);
            public string LogWarning(string message);
            public string LogError(string message, Exception ex);
        }
        public class LocalFileLogger: ILogger
        {
            

        }
    }
}
