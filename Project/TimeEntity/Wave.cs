//Clément Simon & Florian Allermoz - C# Project - 2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Entity;
namespace Project.TimeEntity
{
    class Wave
    {

        //Attributs de la vague 
        //Constructeur par défaut
        public Wave()
        { }

        //Constructeur avec les attributs
        public Wave(int newIdWave, int newNumberZombies)
        {
            IdWave = newIdWave;
            NumberZombies = newNumberZombies;
            ListOfZombie = InitZombie(NumberZombies);
        }

        //Méthode pour commencer la vague
        public void Play(List<Soldier> ListOfSoldier, Wall DefenseWall)
        {
            
            int i = 1;
            FirstPhase(ListOfSoldier, DefenseWall);
            while ((AreSoldierAlive(ListOfSoldier) == true) && (AreZombieAlive(ListOfZombie)))
            {
                Turn NewTurn = new Turn(i);
                NewTurn.AttackPhase(ListOfSoldier, ListOfZombie, DefenseWall);
                Console.WriteLine("Press enter to update the level of soldiers");
                Console.ReadLine();
                UpdateLevel(ListOfSoldier);
                i++;
            }
            Console.WriteLine("End Wave");
        }

        //Méthode pour augmenter les niveaux des soldats
        public void UpdateLevel(List<Soldier> listOfSoldier)
        {
            for (int i = 0; i < listOfSoldier.Count; i ++)
            {
                Console.WriteLine("Zombie tué : " + listOfSoldier[i].ZombieKillesThisTurn);
                //si un soldat a tué au moins un zombie, on lui augmente son niveau
                if ((listOfSoldier[i].ZombieKillesThisTurn > 0) && (listOfSoldier[i].IsAlive()))
                {
                    listOfSoldier[i].TakeLevel(listOfSoldier[i].ZombieKillesThisTurn);
                }
                listOfSoldier[i].ZombieKillesThisTurn = 0;
            }
        }
        public void FirstPhase(List<Soldier> listOfSoldier, Wall defenseWall)
        {
            Console.WriteLine("First phase");
            Console.WriteLine("New Zombies are coming.");
            for (int i = 0; i < this.ListOfZombie.Count; i++)
            {
                Console.WriteLine("Name : " + this.ListOfZombie[i].Name);
                Console.WriteLine("Damage : " + this.ListOfZombie[i].Damage);
                Console.WriteLine("Life : " + this.ListOfZombie[i].MaxHealth);
                Console.WriteLine("Number of hit : " + this.ListOfZombie[i].MaxHit +"\n");
                

            }
            Console.WriteLine("Your Soldier alive");
            for (int i = 0; i < listOfSoldier.Count; i++)
            {
                Console.WriteLine("Name : " + listOfSoldier[i].Name);
                Console.WriteLine("Damage : " + listOfSoldier[i].Damage);
                Console.WriteLine("Life : " + listOfSoldier[i].CurrentHealth);
                Console.WriteLine("Number of hit : " + listOfSoldier[i].MaxHit);
                Console.WriteLine("Level : " + listOfSoldier[i].Level + "\n");

            }
            Console.WriteLine("The Wall : " + defenseWall.CurrentHealth+"hp" + "\n");
            Console.WriteLine("Press enter to continue ...");
            Console.ReadLine();

        }
        public bool AreSoldierAlive(List<Soldier> listOfSoldier)
        {
            for (int i = 0; i < listOfSoldier.Count; i++)
            {
                if (listOfSoldier[i].IsAlive())
                {
                    return true;
                }
            }
            return false;
        }

        public bool AreZombieAlive(List<Zombie> listOfZombie)
        {
            for (int i = 0; i < listOfZombie.Count; i++)
            {
                if (listOfZombie[i].IsAlive())
                {
                    return true;
                }
            }
            return false;
        }

        public static List<Zombie> InitZombie(int nZombie)
        {
            //initialisation des zombies
            List<Zombie> listZombie = new List<Zombie>();
            for (int i = 0; i < nZombie; i++)
            {

                Zombie NewZombie = new Zombie(3, 3, 1, 1, 1, 1,"Zombie " + (i + 1));

                listZombie.Add(NewZombie);
            }

            return listZombie;
        }

        //Getter et Setter
        public int IdWave { get; set; }
        public int NumberZombies { get; set; }
        public List<Zombie> ListOfZombie { get; set; }

        //Méthode pour voir tous les attributs de la vague
        public override string ToString()
        {
            return ("Wave : \nIdWave : " + this.IdWave+"\nNumber Zombie : " +this.NumberZombies);
        }
    }
}
