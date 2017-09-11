//Clément Simon & Florian Allermoz - C# Project - 2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entity
{
    class Soldier
    {

        //Attributs d'un soldat
        private int currentHealth;
        private int maxHealth;
        private int currentHit;
        private int maxHit;
        private int level;
        private int damage;
        private int zombieKillesThisTurn;
        private string name;

        //Constructeur par défaut
        public Soldier()
        { }

        //Constructeur avec les attributs
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


        public bool IsAlive()
        {
            return (CurrentHealth > 0);
        }

        public bool canAttack()
        {
            if (IsAlive())
            {
                return (currentHit > 0);
            }
            else
            {
                return false;
            }
            
        }


        public void TakeLevel(int NbLevel)
        {
            //on ajoute à ses attibuts son nouveau niveau
            CurrentHealth += NbLevel;
            MaxHealth += NbLevel;
            Level += NbLevel;
            Console.WriteLine(this.Name + " Take a new level");
            Console.WriteLine("Current health : " + CurrentHealth +"\nMax : " + MaxHealth + "\n" + "Level : " + Level);
            //Son hit maximum dépend dans quel dizaine est son niveau
            if ((Level % 10) >= 1)
            {
                MaxHit = ((int)(Level / 10)) + 1;
            }
        }

        //Méthode pour qu'un soldat prenne un dommage
        public void TakeDamage(int DamageTaken)
        {
            CurrentHealth -= DamageTaken;
            //Si le soldat meurt au combat
            if (CurrentHealth<=0)
            {
                Console.WriteLine(Name + " fainted \n");
            }
        }

        //Méthode pour que le soldat gagne de la vie
        public void TakeHeal(int HealTaken)
        {
            //Si ça dépasse son maximum de vie possible
            if ((CurrentHealth + HealTaken) > MaxHealth)
            {
                CurrentHealth = MaxHealth;
            }
            else
            {
                CurrentHealth += HealTaken;
            }
        }

        //Méthode pour qu'un soldat attaque un zombie
        public void Attack(Zombie ZombieAttacked)
        {
            //le zombie prend le dommage du soldat
            Console.WriteLine(this.Name + "attack " + ZombieAttacked.Name);
            ZombieAttacked.TakeDamage(this.Damage);
            Console.WriteLine(ZombieAttacked.Name + " life :" + ZombieAttacked.CurrentHealth);
            //le soldat incrémente son compteur de zombie tués
            if (ZombieAttacked.CurrentHealth <= 0 )
            {
                this.ZombieKillesThisTurn += 1;
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
    
        //Méthode pour voir tous les attibuts du soldat
        public string ToString()
        {
            return "Soldier\nCurrent health : " + CurrentHealth + "\nMax Health : " + MaxHealth + "\nCurrentHit : " + CurrentHit + "\nMax hit : " + MaxHit + "\nLevel : " + Level+ "\nDamage : " + Damage+"\nZombie killes this turn : " +ZombieKillesThisTurn+"\nName : " + Name;
        }

    }




}
