using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entity
{
    class Soldier
    {
        private int currentHealth;
        private int maxHealth;
        private int currentHit;
        private int maxHit;
        private int level;
        private int damage;
        private int zombieKillesThisTurn;
        private string name;


        public Soldier()
        { }

        public Soldier(int NewCurrentHealth, int NewMaxHealth, int NewCurrentHit, int NewMaxHit, int newLevel, int NewDamage, int NewZombieKillesThisTurn, string NewNameSoldier)
        {
            CurrentHealth = NewCurrentHealth;
            MaxHealth = NewMaxHealth;
            CurrentHit = NewCurrentHit;
            MaxHit = NewMaxHit;
            Level = newLevel;
            Damage = NewDamage;
            ZombieKillesThisTurn = NewZombieKillesThisTurn;
            Name = NewNameSoldier;
        }




        public void TakeLevel(int NbLevel)
        {
            CurrentHealth += 1 * NbLevel;
            MaxHealth += 1 * NbLevel;
            Level += 1 * NbLevel;
            if((Level % 10) >= 1)
            {
                MaxHit = ((int)(Level / 10)) + 1;
            }
        }
        public void TakeDamage(int DamageTaken)
        {
            CurrentHealth -= DamageTaken;
            if (CurrentHealth<=0)
            {
                Console.WriteLine(Name + " fainted \n");
            }
        }
        public void TakeHeal(int HealTaken)
        {
            if ((CurrentHealth + HealTaken) > MaxHealth)
            {
                CurrentHealth = MaxHealth;
            }
            else
            {
                CurrentHealth += HealTaken;
            }
        }

        public void Attack(Zombie ZombieAttacked)
        {
            ZombieAttacked.TakeDamage(this.Damage);
            if (ZombieAttacked.CurrentHealth <= 0 )
            {
                this.ZombieKillesThisTurn += 1;
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
        public int Level
        {
            get
            {
                return this.level;
            }
            set
            {
                this.level = value;
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
        public int ZombieKillesThisTurn
        {
            get
            {
                return this.zombieKillesThisTurn;
            }
            set
            {
                this.zombieKillesThisTurn = value;
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
            return "Soldier\nCurrent health : " + CurrentHealth + "\nMax Health : " + MaxHealth + "\nCurrentHit : " + CurrentHit + "\nMax hit : " + MaxHit + "\nLevel : " + Level+ "\nDamage : " + Damage+"\nZombie killes this turn : " +ZombieKillesThisTurn+"\nName : " + Name;
        }

    }




}
