using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    abstract class Person
    {
        protected bool alive;
        protected int hitPoints;
        protected int age;
        protected int strength;
        protected int intelligence;
        public string name;
        protected string stateOfMind;
        protected int sobriety;
        protected string sounds;
        protected int happiness;

        public Person(string name)
        {
            this.alive = true;
            this.hitPoints = 100;
            this.age = 0;
            this.strength = 1;
            this.intelligence = 1;
            this.name = name;
            this.happiness = 50;
        }

        public bool checkAlive()
        {
            return this.alive;
        }

        public int checkHealth()
        {
            return this.hitPoints;
        }

        public void setHappiness(int x)
        {
            //MAX HAPPINESS IS 100 MIN HAPPINESS 1
            if ((this.happiness += x) <= 100 && (this.happiness += x) > 0)
            {
                this.happiness += x;
            }
        }


        virtual public void fallDown()
        {
            this.takeDamage(10);

            if (this.hitPoints < 0)
            {
                this.alive = false;
            }

            Console.WriteLine(this.name + " has taken damage. FUCK THAT HURT!");
        }

        virtual public void takeDamage(int attack)
        {
            this.hitPoints -= attack;

            //the character is dead
            if (this.hitPoints < 1)
                this.alive = false;
        }

        virtual public void setHealth(int hp)
        {
            this.hitPoints += hp;
        }

        virtual public void takeInsult(string insult, int burnRating)
        {
            this.stateOfMind = "Insulted";
            this.setHappiness(burnRating);
        }

        virtual public bool isDrunk()
        {
            if (this.sobriety < -8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        virtual public void getShitFaced(int alcoholRating)
        {
            this.sobriety = sobriety - alcoholRating;
        }

        //MEMBER FUNCTIONS
        virtual public string MakeSound()
        {
            return this.sounds;
        }

    }
}
