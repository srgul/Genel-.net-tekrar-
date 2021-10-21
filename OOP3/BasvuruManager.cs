using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediBaseManager krediBaseManager, List<ILoggerService> loggerService)
        {
            krediBaseManager.Hesapla();
            foreach ( var logger in loggerService)
            {
                logger.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediBaseManager> krediler)
        {

            foreach(var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
