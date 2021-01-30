using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager demandCreditManager = new DemandCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager homeCreditManager = new HomeCreditManager();
            ICreditManager tradeCreditManager = new TradeCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.DoApplication(tradeCreditManager, smsLoggerService);


            List<ICreditManager> credits = new List<ICreditManager>() {demandCreditManager, vehicleCreditManager };
            //applicationManager.DoCreditInformation(credits);


        }
    }
}
