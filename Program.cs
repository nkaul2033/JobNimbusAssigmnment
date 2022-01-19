using System;
using System.Collections.Generic;

namespace JobNimbusAssigmnment
{
    class Program
    {
        static BracketRegulatorService bracketRegulatorService = new BracketRegulatorService();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. Please Enter a string with matching brackets!");

            while (true)
            {
                string key = Console.ReadLine();

                if (bracketRegulatorService.areBracketsEqual(key.ToCharArray()))
                    Console.WriteLine("TRUE");
                else
                    Console.WriteLine("FALSE");

                continue;
            }
        }



    }
}
