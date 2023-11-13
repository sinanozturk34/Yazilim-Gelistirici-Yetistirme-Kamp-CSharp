using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class FilebaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya  loglandı");
        }
    }
}
