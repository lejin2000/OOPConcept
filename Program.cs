using System;
using System.Collections.Generic;

namespace OOPConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creator youTuber = new YouTuber();
            //Programmer programmer = new Programmer();

            //Console.WriteLine("----YouTuber----");
            //Console.WriteLine();
            //youTuber.Create();
            //Console.WriteLine();
            //Console.WriteLine("----Programmer----");
            //Console.WriteLine();
            //programmer.Create();
            //Console.WriteLine();

            //polymophism show 
            List<Creator> creators = new List<Creator>() { new YouTuber(), new Programmer() };

            foreach( var creator in creators) //Abstract od class of create method in class
            {
                Console.WriteLine(creator.GetType().Name);
                Console.WriteLine();
                creator.Create(); //Abtraction is internal methods not exposed
                Console.WriteLine();
            }

        }
    }
}
