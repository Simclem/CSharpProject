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

        //Attributs du mur
        private int currentHealth;
        private int maxHealth;

        //Constructeur par défaut
        public Wall()
        { }

        //Constructeur avec les attributs du mur
        public Wall(int NewCurrentHealth, int NewMaxHealth)
        {
            CurrentHealth = NewCurrentHealth;
            MaxHealth = NewMaxHealth;
        }

        //Fonction pour savoir si le mur est tombé face aux assaillants
        public bool IsDown()
        {
            return (CurrentHealth <= 0);
        }

        //Méthode pour que le mur prenne des dégats quand il est attaqué
        public void TakeDamage(int DamageTaken)
        {
            CurrentHealth -= DamageTaken;
            //Si le mur tombe pendant le combat
            if (CurrentHealth <=0)
            {
                Console.WriteLine("Wall fainted \n");
            }
        }

        //Getter et Setter
        public int CurrentHealth
        {
            get
            {
                return this.currentHealth;
            }
            set
            {
                this.currentHealth = value;
            }
        }
        public int MaxHealth
        {
            get
            {
                return this.maxHealth;
            }
            set
            {
                this.maxHealth = value;
            }
        }

        //Méthode pour voir tous les attributs du mur
        public string ToString()
        {
            return "Wall\nCurrent health : " + CurrentHealth + "\nMax Health : " + MaxHealth +"\n";
        }
    }
}
