﻿//Clément Simon & Florian Allermoz - C# Project - 2017

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
        public void AttackPhase(List<Soldier> ListOfSoldier, List<Zombie>ListOfZombie)
        {
            for (int i = 0; i < ListOfSoldier.Count; i++)
            {
                int nbAttack = 0;

                for (int y = ListOfSoldier[i].CurrentHit; y > 0; y--)
                {
                    nbAttack ++;

                    Zombie LastZombie = FindFirstZombieAlive(ListOfZombie);
                    
                    if (LastZombie != null)
                    {
                        Console.WriteLine("ATTACKED DONE");
                        ListOfSoldier[i].Attack(LastZombie);
                    }
                }
                Console.WriteLine("__________________");
                Console.WriteLine("Current " + ListOfSoldier[i].CurrentHit);
                Console.WriteLine("nbAttack " + nbAttack);
                Console.WriteLine("__________________");
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
            int i = 0;
            
            while ((ListOfZombie[i].IsAlive()) && (i< ListOfZombie.Count))
            {
                if (ListOfZombie[i].IsAlive())
                {
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine(ListOfZombie[i].ToString());
                    Console.WriteLine("------------------------------------------------------");
                    return (ListOfZombie[i]);
                }
                i++;
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
