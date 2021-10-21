using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class TasitKrediManager : IKrediBaseManager
    {
        public void BiSeyYap()
        {
            Console.WriteLine("Ödeme planında bir şeyler yapıldı");
        }

        public void Hesapla()
        {
            Console.WriteLine("Taşıt kredisi Ödeme planı hesaplandı");
        }
    }
}
