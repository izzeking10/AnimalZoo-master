using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class House
    {
        List<Animal> AnimalList = new List<Animal>();

        public void Print()
        {
            
            Console.WriteLine("Följande djur finns i huset: ");
            
            foreach (Animal animal in AnimalList)
            {
                animal.Print();
            }
           
        }
    }
}
