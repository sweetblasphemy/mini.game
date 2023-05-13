using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace mini.game
{
    internal class miniGame
    {

        public string human_name = Console.ReadLine();
        public string enemy_name = "Zombie";
        public int human_health = 45;
        public int enemy_health = 40;
        public int ammo = int.Parse(Console.ReadLine());


        public miniGame(string human_name, string enemy_name, int human_health, int enemy_health, int ammo)
        {

            this.human_name = human_name;
            this.enemy_name = enemy_name;
            this.human_health = human_health;
            this.enemy_health = enemy_health;
            this.ammo = ammo;

        }

        public void print()
        {

            if (ammo == 10)
            {
                Console.WriteLine("Zombie's health -" + 10);
                Console.WriteLine("Zombie's health is: 30");

                int n = int.Parse(Console.ReadLine());

                if (n == 10)
                {
                    Console.WriteLine("Zombie's health -" + 10);
                    Console.WriteLine("Zombie's health is: 20");

                    int m = int.Parse(Console.ReadLine());

                    if (m == 10)
                    {
                        Console.WriteLine("Zombie's health -" + 10);
                        Console.WriteLine("Zombie's health is; 10");
                        
                        int b = int.Parse(Console.ReadLine());

                        if (b == 10)
                        {
                            Console.WriteLine("------------");
                            Console.WriteLine("You killed the zombie !");
                        }
                    }
                    else if (m == 20)
                    {
                        Console.WriteLine("------------");
                        Console.WriteLine("Critical hit !");
                        Console.WriteLine("------------");
                        Console.WriteLine("You killed the zombie !");
                    }
                }
                
            }
            

        }

      

    }
}
