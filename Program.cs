using System;

namespace Aula10POO
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("messi :");
            Messi messi = new Messi();
            messi.correr();
            messi.driblar();


            System.Console.WriteLine("Cr7 :");
            Cr7 cr7 = new Cr7();
            cr7.correr();
            cr7.driblar();
            

        }
    }
}
