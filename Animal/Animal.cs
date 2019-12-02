using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    public class Animal
    {
        
        public enum SPECIES { CAT, DOG, BIRD }
        public string name { get; set; }
        public SPECIES species { get; set; }
        public bool canFly { get; set; }
        
        
        public static int currentYear = 2019;
        public int birthYear { get; set; }
        
        
        public int GetAge()
        {
            return currentYear - birthYear;
        }
        public void SetAge(int newAge)
        {
            birthYear = currentYear - newAge;
        }
        public virtual void IntroduceYourself()
        {
            Console.WriteLine("jag är " + GetAge() + " år gammal");
        }
        public void Print()
        {
            if (friend != null)
            {
                Console.WriteLine("Här är uppgifter om min kompis:");
                friend.introduceYourself();
            }
            else
            {
                Console.WriteLine("jag har inga vänner");
            }
        }
    }
    

}
