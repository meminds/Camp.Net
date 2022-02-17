using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class AppealManager
    {
        //Method injection
        public void MakeApplication(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            //Başvuran bilgilerini değerlendirme
            //
            creditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void CreditOnNotificationMake(List<ICreditManager> credits)
        {
            foreach (var kredi in credits)
            {
                kredi.Calculate();
            }
        }
    }
}
