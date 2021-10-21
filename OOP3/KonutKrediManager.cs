using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class KonutKrediManager : IKrediBaseManager
    {
        public void BiSeyYap()
        {
            Console.WriteLine("bir şey yapıldı");
        }

        public void Hesapla()
        {
            Console.WriteLine("Konut kredisi planı hesaplandı");
        }
    }
}
