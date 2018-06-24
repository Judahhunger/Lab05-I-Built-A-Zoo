using System;
using System.Reflection;
using I_Built_a_Zoo.classes;


namespace I_Built_a_Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MakeBatman();
            Console.WriteLine("");
            FernGullyBat();
            Console.ReadLine();

        }


        /// <summary>
        /// testing to see if i can get the keys to objects other stuff.
        /// </summary>
        static void MakeBatman()
        {
            TechBat batman = new TechBat("Batman");

            foreach (PropertyInfo prop in batman.GetType().GetProperties())
            {
                Console.WriteLine(prop.GetValue(batman).ToString() + " : "  + ":" + prop.GetGetMethod().ToString());
            }
            
            Console.WriteLine();
        }

        /// <summary>
        /// Writing stuff to console for new fruitbat from base bat.
        /// </summary>
        static void FernGullyBat()
        {
            FruitBat batty = new FruitBat();

            Console.WriteLine(batty.Eats());
            string home = "FernGully";
            batty.Name = "Batty";
           
           
            Console.WriteLine($"My name is {batty.Name}, I say {batty.SaysSound()} {batty.Eats()} i have {batty.NumOfLegs} legs, and {batty.FlyingTo(home)} i don't like being in a {batty.LivesIn()}");
        }

        
    }
}
