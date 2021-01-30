using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        public void DoApplication(ICreditManager creditManager, ILoggerService loggerService) //Method injection
        {
            //Başvuran bilgilerini değerlendirme
            //
            creditManager.Calculate(); //tüm krediler bağımsız bir şekilde hesaplanır
            loggerService.Log();
        }

        public void DoCreditInformation(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
