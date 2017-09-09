//Clément Simon & Florian Allermoz - C# Project - 2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Project.Entity;
using Project.TimeEntity;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {

            //Création des joueur de la partie
            List<Soldier> ListOfSoldier = InitSoldier(3);
            Wall DefenseWall = new Wall(10, 10);
            List<Zombie> ListZombie = new List<Zombie>();
            Zombie zombie = new Zombie(1, 1, 1, 1, 1, 1, "Zombie");
            Zombie zomb = new Zombie(1, 1, 1, 1, 1, 1, "Zomb");
            Zombie z = new Zombie(1, 1, 1, 1, 1, 1, "Z");
            ListZombie.Add(zombie);
            ListZombie.Add(zomb);
            ListZombie.Add(z);
            /* Console.WriteLine(ListOfSoldier[0].ToString());
             Console.WriteLine();
             Console.WriteLine();
             Console.WriteLine();
             Console.WriteLine();
             Console.WriteLine();
             ListOfSoldier[0].TakeDamage(1);
             Console.WriteLine(ListOfSoldier[0].ToString());
             Console.WriteLine();
             Console.WriteLine();
             Console.WriteLine();
             Console.WriteLine();
             Console.WriteLine();
             ListOfSoldier[0].TakeHeal(12);
             Console.WriteLine(ListOfSoldier[0].ToString());
             Console.WriteLine();
             Console.WriteLine();
             Console.WriteLine();
             Console.WriteLine();
             Console.WriteLine();
             ListOfSoldier[0].TakeLevel(20);

             Console.WriteLine(ListOfSoldier[0].ToString());
             Console.WriteLine("___________________________________________");
             Zombie zombie = new Zombie(1, 1, 1, 1, 1, 1,"Zombie mort");
             Console.WriteLine(zombie.ToString());

             Console.WriteLine();
             Console.WriteLine();
             Console.WriteLine();
             Console.WriteLine();
             Console.WriteLine();
             ListOfSoldier[0].Attack(zombie);
             Console.WriteLine(zombie.ToString());
             Console.WriteLine();
             Console.WriteLine();
             Console.WriteLine();
             Console.WriteLine();
             Console.WriteLine();
             Console.WriteLine(DefenseWall.ToString());
             zombie.Attack(ListOfSoldier[0], DefenseWall);
             Console.WriteLine();
             Console.WriteLine();
             Console.WriteLine();
             Console.WriteLine();
             Console.WriteLine();
             Console.WriteLine(DefenseWall.ToString());
             Console.WriteLine(ListOfSoldier[0].ToString());
             */

            //on commence une vague
            Wave vagueTest = new Wave(1, 10);
            vagueTest.UpdateLevel(ListOfSoldier);
            Console.WriteLine(ListOfSoldier[0].ToString());
            Turn tour = new Turn(1);
            tour.AttackPhase(ListOfSoldier, ListZombie, DefenseWall);


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Zombie " + zombie.ToString());
            Console.WriteLine("Zomb " + zomb.ToString());
            Console.WriteLine("Z " + z.ToString());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(ListOfSoldier[0].ToString());
            Console.WriteLine();
            Console.WriteLine(ListOfSoldier[1].ToString());
            Console.WriteLine();
            Console.WriteLine(ListOfSoldier[2].ToString());
            //Console.WriteLine(vagueTest.ToString());
            Console.ReadLine();


        }



        public static List<Soldier> InitSoldier(int NbSoldiers)
        {
            //initialisation des soldats
            List<Soldier> ListOfSoldier = new List<Soldier>();
            for(int i = 0; i < NbSoldiers; i ++)
            {

                Soldier NewSoldier = new Soldier(3, 3, 1, 1, 1, 1, 10,"Soldier "+(i+1));

                ListOfSoldier.Add(NewSoldier);
            }
            return ListOfSoldier;
        }
    }
}
