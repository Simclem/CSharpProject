//Clément Simon & Florian Allermoz - C# Project - 2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Entity;
namespace Project.TimeEntity
{
    class Turn
    {

        //Attribut du tour

        public Turn()
        {

        }

        public Turn(int newIdTurn)
        {
            IdTurn = newIdTurn;
        }



        //Méthode pour débuter le combat entre les soldats et les zombies
        public void AttackPhase(List<Soldier> listOfSoldier, List<Zombie>listOfZombie, Wall defenseWall)
        {
            // On commence par faire attaquer l'ensemble des soldats
            for (int i = 0; i < listOfSoldier.Count; i++)
            {
                if (listOfSoldier[i].CanAttack())
                {
                    for (int y = listOfSoldier[i].CurrentHit; y > 0; y--)
                    {
                        Zombie LastZombie = FindFirstZombieAlive(listOfZombie);
                        if (LastZombie != null)
                        {
                            Console.WriteLine("ATTACKED DONE");
                            listOfSoldier[i].Attack(LastZombie);
                        }
                    }
                }
            }
            //Puis on fait attaquer tous les zombis
            for (int i = 0; i < listOfZombie.Count; i++)
            {
                if (listOfZombie[i].CanAttack())
                {
                    for (int y = listOfZombie[i].CurrentHit; y > 0; y--)
                    {
                        Soldier LastSoldierAlive = FindFirstSoldierAlive(listOfSoldier);
                        {
                            if (LastSoldierAlive != null)
                            {
                                listOfZombie[i].Attack(LastSoldierAlive, defenseWall);
                            }
                        }
                    }
                }

            }
        }

        //Méthode pour afficher tous les zombies
        public void DisplayAllZombies(List<Zombie> listOfZombie)
        {
            for ( int i = 0; i < listOfZombie.Count; i ++)
            {
                listOfZombie[i].ToString();
            }
        }

        //Fonction pour trouver le premier zombie encore en vie
        public Zombie FindFirstZombieAlive(List<Zombie> listOfZombie)
        {
            for (int i = 0; i < listOfZombie.Count; i++)
            {
                if (listOfZombie[i].IsAlive())
                {
                    return listOfZombie[i];
                }
            }

            return null;
        }
        public Soldier FindFirstSoldierAlive(List<Soldier> listOfSoldier)
        {
            for (int i = 0; i < listOfSoldier.Count; i++)
            {
                if (listOfSoldier[i].IsAlive())
                {
                    return listOfSoldier[i];
                }
            }

            return null;
        }

        //Getter et Setter
        public int IdTurn { get; set; }

        //Méthode pour tous les attributs du tour
        public override string ToString()
        {
            return "Turn\nidTurn : " + this.IdTurn;
        }
    }
}
