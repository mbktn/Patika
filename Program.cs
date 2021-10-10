using System;

namespace Pratikler1Odev1
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("İsminizi Giriniz :");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadinizi Giriniz");
            string surname = Console.ReadLine();
            Console.WriteLine("Merhaba :{0} {1} ",name,surname );
            
        }
    }
}
