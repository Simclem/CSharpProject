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
        private int idTurn;

        public Turn()
        {

        }

        public Turn(int NewIdTurn)
        {
            IdTurn = NewIdTurn;
        }



        //Méthode pour débuter le combat entre les soldats et les zombies
        public void AttackPhase(List<Soldier> ListOfSoldier, List<Zombie>ListOfZombie, Wall DefenseWall)
        {
            for (int i = 0; i < ListOfSoldier.Count; i++)
            {

                for (int y = ListOfSoldier[i].CurrentHit; y > 0; y--)
                {

                    Zombie LastZombie = FindFirstZombieAlive(ListOfZombie);
                    
                    if (LastZombie != null)
                    {
                        if (ListOfSoldier[i].canAttack())
                        {
                            Console.WriteLine("ATTACKED DONE");
                            ListOfSoldier[i].Attack(LastZombie);
                        }
                        
                    }
                }
               
            }
            for (int i = 0; i < ListOfZombie.Count; i++)
            {
                for (int y = ListOfZombie[i].CurrentHit; y >  0; y--)
                {
                    Soldier LastSoldierAlive = FindFirstSoldierAlive(ListOfSoldier);
                    {
                        if (LastSoldierAlive!= null)
                        {
                            Console.WriteLine("graaaaaa");
                            ListOfZombie[i].Attack(LastSoldierAlive, DefenseWall);
                        }
                    }
                }
            }
        }

        //Méthode pour afficher tous les zombies
        public void DisplayAllZombies(List<Zombie> ListOfZombie)
        {
            for ( int i = 0; i < ListOfZombie.Count; i ++)
            {
                ListOfZombie[i].ToString();
            }
        }

        //Fonction pour trouver le premier zombie encore en vie
        public Zombie FindFirstZombieAlive(List<Zombie> ListOfZombie)
        {
            for (int i = 0; i < ListOfZombie.Count; i++)
            {
                if (ListOfZombie[i].IsAlive())
                {
                    return ListOfZombie[i];
                }
            }

            return null;
        }
        public Soldier FindFirstSoldierAlive(List<Soldier> ListOfSoldier)
        {
            for (int i = 0; i < ListOfSoldier.Count; i++)
            {
                if (ListOfSoldier[i].IsAlive())
                {
                    return ListOfSoldier[i];
                }
            }

            return null;
        }

        //Getter et Setter
        public int IdTurn
        {
            get
            {
                return this.idTurn;
            }
            set
            {
                this.idTurn = value;
            }
        }

        //Méthode pour tous les attributs du tour
        private string ToString()
        {
            return "Turn\nidTurn : " + this.idTurn;
        }
    }
}
