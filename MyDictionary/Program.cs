using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> sehir = new MyList<string>();
            sehir.Add("Erzurum..");
            sehir.Add("Erzurum..");
            sehir.Add("Erzurum..");
            Console.WriteLine(sehir.Count);
            Console.ReadLine();

        }
    }
}
