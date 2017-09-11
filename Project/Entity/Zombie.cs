//Clément Simon & Florian Allermoz - C# Project - 2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entity
{
    class Zombie
    {

        //Attributs d'un zombie
        private int currentHealth;
        private int maxHealth;
        private int currentHit;
        private int maxHit;
        private int damage;
        private string name;

        //Constructeur par défaut
        public Zombie()
        { }

        //Constructeur avec tous les attributs d'un zombie
        public Zombie(int NewCurrentHealth, int NewMaxHealth, int NewCurrentHit, int NewMaxHit, int newLevel, int NewDamage, string NewNameZombie)
        {
            CurrentHealth = NewCurrentHealth;
            MaxHealth = NewMaxHealth;
            CurrentHit = NewCurrentHit;
            MaxHit = NewMaxHit;
            Damage = NewDamage;
            Name = NewNameZombie;
        }

        //Fonction pour savoir si le zombie est en vie
        public bool IsAlive()
        {
            return (CurrentHealth > 0);
        }

        //Méthode pour que le zombie prenne des dégats
        public void TakeDamage(int DamageTaken)
        {
            CurrentHealth -= DamageTaken;
            //Si le zombie est battu
            
            if (CurrentHealth <=0)
            {
                Console.WriteLine(Name + " fainted \n");
            }
        }

        //Fonction pour savoir si le zombie peut attaquer (si il lui reste des coups à donner)
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

        //Méthode pour que le zombie attaque
        public void Attack(Soldier SoldierAttacked, Wall ProtectionWall)
        {
            //Le zombie attaque en priorité le mur (si il est encore debout)
            if (ProtectionWall.IsDown())
            {
                Console.WriteLine(this.Name + " Attack " + SoldierAttacked.Name);
                SoldierAttacked.TakeDamage(this.Damage);
                Console.WriteLine(SoldierAttacked.Name +" life : " + SoldierAttacked.CurrentHealth);

            }
            else
            {
                Console.WriteLine(this.Name +" Attack the wall");
                ProtectionWall.TakeDamage(this.damage);
                Console.WriteLine("Wall life : " + ProtectionWall.CurrentHealth);
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

        //Méthode pour voir tous les attributs du zombie
        public string ToString()
        {
            return "Zombie\nCurrent health : " + CurrentHealth + "\nMax Health : " + MaxHealth + "\nCurrentHit : " + CurrentHit + "\nMax hit : " + MaxHit + "\nDamage : " + Damage + "\nName : " + Name+"\n";
        }
    }
}
