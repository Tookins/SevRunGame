using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Jeff : Person
    {
        public Jeff(string name) : base(name)
        {
            this.sounds = "Sings Linkin Park";
        }

        public void Tornado(Person p)
        {
            p.takeDamage(20);
            Console.WriteLine(this.name + " uses TORNADO! Its all over!");
        }

        public override void fallDown()
        {
            if (this.isDrunk())
            {
                this.takeDamage(50);
            }
            else
            {
                this.takeDamage(5);
            }

            Console.WriteLine(this.name + " has taken damage. FUCK THAT HURT");
        }
    }
}
