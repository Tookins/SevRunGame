using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stoff theStoff = new Stoff("theStoff");
            Jeff Jeffus = new Jeff("Jeffus");


             theStoff.MakeSound();

            int whiskey = 10;

            theStoff.getShitFaced(whiskey);

            Jeffus.Tornado(theStoff);

            theStoff.trickClouds(theStoff);

            Console.WriteLine("The Stoff has " + theStoff.checkHealth() + " remaining hit points");


            if (theStoff.checkAlive())
            {
                Console.WriteLine("A new stoff has been born and is alive");
            }
            else
            {
                Console.WriteLine("He's dead Jim");
            }
        }
    }
}
