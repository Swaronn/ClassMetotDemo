using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi " + musteri.FirstName + " " + musteri.LastName);
        }
        
        public void Remove (Musteri musteri)
        {
            Console.WriteLine("Müşteri Silidi " + musteri.FirstName + " " + musteri.LastName);
        }

        public void Update(Musteri musteri)
        {
            Console.WriteLine("Müşteri Güncellendi " + musteri.FirstName + " " + musteri.LastName);
        }

        public void List(Musteri[] musteri)
        {
            Console.WriteLine("Müşteriler Listelendi ");
            foreach (Musteri m in musteri) 
            { 
                Console.WriteLine(m.FirstName + " " + m.LastName); 
            }
            
        }

        
    }
}
