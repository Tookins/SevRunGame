using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Stoff : Person
    {
        //OBJECT PROPERTIES
        private int vapeJuice;

        //constructor
        public Stoff(string name) : base (name)
        {
            this.sounds = "Farts";
            this.vapeJuice = 3;
        }

        public override void fallDown()
        {
            this.takeDamage(5);

            if (this.hitPoints < 0)
            {
                this.alive = false;
            }

            Console.WriteLine(this.name + " has taken damage. FUCK THAT HURT");
        }

        public void trickClouds(Person p)
        {
            if (this.vapeJuice > 0)
            {
                p.setHealth(5);
                Console.WriteLine(this.name + " uses Trick Clouds! " + p.name + " is healed 5 hit points!");
            }
        }
    }
}
