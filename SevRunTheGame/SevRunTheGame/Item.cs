using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    abstract class Item
    {
        public string name;
	protected int price;
	protected string sounds;


        public Item(string name)
        {
            this.price = 0;
        }

        public bool checkPrice()
        {
            return this.price;
        }

        //MEMBER FUNCTIONS
        virtual public string MakeSound()
        {
            return this.sounds;
        }

    }
}
