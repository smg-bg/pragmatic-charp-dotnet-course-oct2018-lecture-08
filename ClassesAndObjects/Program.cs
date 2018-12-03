using System;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {

            //Desk myDesk = new Desk();

            //Console.WriteLine(myDesk.Size);
            //Console.WriteLine(myDesk._myPrivateSerialNumber);

            //Cat myKitten = new Cat("Misha");
            //myKitten.SayUsualPhrase();
            //myKitten.SayUsualPhrase("Bau");
            //myKitten.SayUsualPhrase("Opps", 7);

            Cat myKitten = new Cat("Misha");

            Console.WriteLine(myKitten.Name);

            // we can't set Name, because the set accessor is private
            // myKitten.Name = "fsafsa";
        

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
