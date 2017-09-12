//Clément Simon & Florian Allermoz - C# Project - 2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entity
{
    class Wall
    {

      

        //Constructeur par défaut
        public Wall()
        { }

        //Constructeur avec les attributs du mur
        public Wall(int newCurrentHealth, int newMaxHealth)
        {
            CurrentHealth = newCurrentHealth;
            MaxHealth = newMaxHealth;
        }

        //Fonction pour savoir si le mur est tombé face aux assaillants
        public bool IsDown()
        {
            return (CurrentHealth <= 0);
        }

        //Méthode pour que le mur prenne des dégats quand il est attaqué
        public void TakeDamage(int damageTaken)
        {
            CurrentHealth -= damageTaken;
            //Si le mur tombe pendant le combat
            if (CurrentHealth <=0)
            {
                Console.WriteLine("Wall has fallen \n");
            }
        }

        //Getter et Setter
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }

        //Méthode pour voir tous les attributs du mur
        public override string  ToString()
        {
            return "Wall\nCurrent health : " + CurrentHealth + "\nMax Health : " + MaxHealth +"\n";
        }
    }
}
