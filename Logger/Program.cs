namespace Logger
{
    internal class Program
    {
         static void Main(string[] args)
         {
             LocalFileLogger<int> logger = new LocalFileLogger<int>(@"D:\Docs\logger.txt");
             
             logger.LogInfo("LogInfo");
             logger.LogWarning("LogWarning");
             logger.LogError("LogWarning");
         }
    }

    class LocalFileLogger<T>
    {
        private string path;

        public LocalFileLogger(string message)
        {
            path = message;
        }

        public void LogInfo(string message)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine($"[Info]: [{typeof(T).Name}] : {message}");
            }
        }
        
        public void LogWarning(string message)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine($"[Warning]: [{typeof(T).Name}] : {message}");
            }
        }
        
        public void LogError (string message)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine($"[Error]: [{typeof(T).Name}] : {message}");
            }
        }
    }

}

