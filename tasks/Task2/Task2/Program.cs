using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Net;



namespace Task2
{
    
    public class Pet
    {
        private int ratio = 7;
       
           

        /// <summary>
        /// Creates a new pet object.
        /// </summary>
        /// <param name="race">Race must not be empty.</param>
        /// <param name="sex">Gender.</param>
        /// <param name="personality">Personality must not be empty.</param>
    


        public Pet (string race, string sex, string personality, int age)
        {
            if (string.IsNullOrWhiteSpace(race)) throw new ArgumentException("Race must be defined.", nameof(race));
            if (string.IsNullOrWhiteSpace(sex)) throw new ArgumentException("Sex must be defined.", nameof(sex));
            if (string.IsNullOrWhiteSpace(personality)) throw new ArgumentException("Come on, one good trait.", nameof(personality));
           

            Race = race;
            Sex = sex;
            Personality = personality;

           /* Pet Hildy = new Pet("Hauskatze", "weiblich", "grantig, ready for Battle, Rustypyjamas", 1);
            Pet Seppi = new Pet("Hauskatze", "maennlich", "schlaeft viel, macht nichts", 11);
            */
            UpdateAge(age, ratio);

            
        }

       
        public string Race{get;}     
        public string Sex { get; }
        public string Personality { get; }
        public int Age { get; private set; }

            

        public void UpdateAge(int newAge, int ratio)
        {
            if (newAge < 0) throw new ArgumentException("Age must not be negative.", nameof(newAge));
            Age = newAge * 7;
            
              }

        override public string ToString()
        {
            return Race +" " + Sex +" " + Personality + " " + Age.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pet Hildy = new Pet("Hauskatze", "weiblich", "grantig, ready for Battle, Rustypyjamas", 1);
            Pet Seppi = new Pet("Hauskatze", "maennlich", "schlaeft viel, macht nichts", 11);
            Console.WriteLine(Hildy.ToString());
           Console.WriteLine(Seppi.ToString());

            ///  Console.WriteLine(Seppi.UpdateAge(11, ratio)); Warum funktioniert Seppi.Age nicht?

            Console.Read();
        }
    }
}



