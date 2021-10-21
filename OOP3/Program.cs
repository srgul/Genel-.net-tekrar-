using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediBaseManager ihtiyacKrediManager = new IhtiyacKrediManager();
           
            IKrediBaseManager tasitKrediManager = new TasitKrediManager();
     
            IKrediBaseManager konutKrediManage = new KonutKrediManager();

            IKrediBaseManager esnafKredisi = new EsnafKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new DatabaseLoggerService(), new SmsLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKredisi, loggers);

           

            List<IKrediBaseManager> krediler = new List<IKrediBaseManager>() {
                ihtiyacKrediManager, konutKrediManage, tasitKrediManager 
            };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
