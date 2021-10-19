using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi ");
        }

        public void update(Product product)
        {
            Console.WriteLine(product.ProductName + " Güncellendi ");
        }

        // eğer bir işlem sonucunu tekrardan kullanmak istemiyorsan void kullanmalısın. 
        // eğer işlemden geri dönen datayı kullanacaksan ona bir değer atarak func yazmalısın string ise string int ise int 


        public int Topla(int Sayi1, int Sayi2)
        {
            return Sayi1 + Sayi2;  //işlem sonucunu returnle geri kullanılır*
        }

        public void Topla2(int Sayi1, int Sayi2)
        {
            Console.WriteLine( Sayi1 + Sayi2 ); // işlem sonucunu sadece ekrana bastırır sonucu kullanamazsın*
        }
    }
}
