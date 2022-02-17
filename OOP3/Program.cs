using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            KonutKrediManager konutKrediManager = new KonutKrediManager();
             */
            ICreditManager needCreditManager = new NeedCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager houseCreditManager = new HouseCreditManager();

            

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };


            AppealManager appealManager = new AppealManager();
            appealManager.MakeApplication(new TradesmanCreditManager(), loggers);
            //basvuruManager.BasvuruYap(new EsnafKredisiManager(), new List<ILoggerService> {new FileLoggerService(), new DatabaseLoggerService()});

            List<ICreditManager> krediler = new List<ICreditManager>() { needCreditManager, vehicleCreditManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}