using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entity
{
    class Wall
    {
        private int currentHealth;
        private int maxHealth;






        public Wall()
        { }

        public Wall(int NewCurrentHealth, int NewMaxHealth)
        {
            CurrentHealth = NewCurrentHealth;
            MaxHealth = NewMaxHealth;
        }




        public bool IsDown()
        {
            return (CurrentHealth < 0);
        }




        public void TakeDamage(int DamageTaken)
        {
            CurrentHealth -= DamageTaken;
            if (CurrentHealth <=0)
            {
                Console.WriteLine("Wall fainted \n");
            }
        }


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
        public string ToString()
        {
            return "Wall\nCurrent health : " + CurrentHealth + "\nMax Health : " + MaxHealth +"\n";
        }
    }
}
