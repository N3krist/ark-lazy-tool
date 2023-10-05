using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkToolLazy1
{
    class Class1
    {
        static void Main(string[] args)
        {
            int maxLevel, stamina, melee, hp, weight, food, oxy, speed;
            int stamina1, melee1, hp1, weight1, food1, oxy1, speed1;
            int stamina2, melee2, hp2, weight2, food2, oxy2, speed2;

            maxLevel = 1;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello you wonderful lazy people ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Looks like ur as lazy as me so here we go");
            Console.WriteLine("Just give me the Levels of each stat and i give you the possible Max-Level of ur Baby");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Give me the Health of the first Dino :");
            hp1 = int.Parse(Console.ReadLine());
            Console.WriteLine("next is Stamina :");
            stamina1 = int.Parse(Console.ReadLine());
            Console.WriteLine("an now Oxygen pls :");
            oxy1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Food pls :");
            food1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Weight pls :");
            weight1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Damage pls :");
            melee1 = int.Parse(Console.ReadLine());
            Console.WriteLine("at last Speed pls :");
            speed1  = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("so now to the second Dino.\nPls give me the Health of the second Dino :");
            hp2 = int.Parse(Console.ReadLine());
            Console.WriteLine("next is Stamina :");
            stamina2 = int.Parse(Console.ReadLine());
            Console.WriteLine("an now Oxygen pls :");
            oxy2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Food pls :");
            food2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Weight pls :");
            weight2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Damage pls :");
            melee2 = int.Parse(Console.ReadLine());
            Console.WriteLine("at last Speed pls :");
            speed2 = int.Parse(Console.ReadLine());
            if (hp1 > hp2)
                hp = hp1;
            else
                hp = hp2;
            if (stamina1 > stamina2)
                stamina = stamina1;
            else
                stamina = stamina2;
            if (oxy1>oxy2)
                oxy = oxy1;
            else
                oxy = oxy2;
            if (food1 > food2)
                food = food1;
            else
                food = food2;   
            if (weight1 > weight2)
                weight = weight1;
            else
                weight = weight2;
            if (speed1 > speed2)
                speed = speed1;
            else 
                speed = speed2; 
            if (melee1 > melee2)
                melee = melee1;
            else 
                melee = melee2;    
                
            maxLevel = maxLevel + hp + stamina + oxy + food + weight + speed + melee;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("The Max-Level of the Baby is : " + maxLevel);
            Console.WriteLine("Thx for using this little tool");
            System.Console.ReadKey();

        }
    }
}
