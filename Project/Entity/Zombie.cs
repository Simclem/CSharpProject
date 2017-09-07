using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entity
{
    class Zombie
    {
        private int currentHealth;
        private int maxHealth;
        private int currentHit;
        private int maxHit;
        private int damage;
        private string name;




        public Zombie()
        { }

        public Zombie(int NewCurrentHealth, int NewMaxHealth, int NewCurrentHit, int NewMaxHit, int newLevel, int NewDamage, string NewNameZombie)
        {
            CurrentHealth = NewCurrentHealth;
            MaxHealth = NewMaxHealth;
            CurrentHit = NewCurrentHit;
            MaxHit = NewMaxHit;
            Damage = NewDamage;
            Name = NewNameZombie;
        }


        public bool IsAlive()
        {
            return (CurrentHealth > 0);
        }

        public void TakeDamage(int DamageTaken)
        {
            CurrentHealth -= DamageTaken;
            if (CurrentHealth <=0)
            {
                Console.WriteLine(Name + " fainted \n");
            }
        }




        public bool canAttack()
        {
            return (currentHit > 0);
        }




        public void Attack(Soldier SoldierAttacked, Wall ProtectionWall)
        {
            if (ProtectionWall.IsDown())
            {
                SoldierAttacked.TakeDamage(this.Damage);
            }
            else
            {
                ProtectionWall.TakeDamage(this.damage);
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
        public int CurrentHit
        {
            get
            {
                return this.currentHit;
            }
            set
            {
                this.currentHit = value;
            }
        }
        public int MaxHit
        {
            get
            {
                return this.maxHit;
            }
            set
            {
                this.maxHit = value;
            }
        }
        public int Damage
        {
            get
            {
                return this.damage;
            }
            set
            {
                this.damage = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public string ToString()
        {
            return "Zombie\nCurrent health : " + CurrentHealth + "\nMax Health : " + MaxHealth + "\nCurrentHit : " + CurrentHit + "\nMax hit : " + MaxHit + "\nDamage : " + Damage + "\nName : " + Name+"\n";
        }
    }
}
