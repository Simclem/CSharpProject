//Clément Simon & Florian Allermoz - C# Project - 2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entity
{
    public class Soldier
    {

        //Attributs d'un soldat
       

        //Constructeur par défaut
        public Soldier()
        { }

        //Constructeur avec les attributs
        public Soldier(int newCurrentHealth, int newMaxHealth, int newCurrentHit, int newMaxHit, int newLevel, int newDamage, int newZombieKillesThisTurn, string newNameSoldier)
        {
            CurrentHealth = newCurrentHealth;
            MaxHealth = newMaxHealth;
            CurrentHit = newCurrentHit;
            MaxHit = newMaxHit;
            Level = newLevel;
            Damage = newDamage;
            ZombieKillesThisTurn = newZombieKillesThisTurn;
            Name = newNameSoldier;
        }


        public bool IsAlive()
        {
            return (CurrentHealth > 0);
        }

        public bool CanAttack()
        {
            if (IsAlive())
            {
                return (CurrentHit > 0);
            }
            else
            {
                return false;
            }
            
        }


        public void TakeLevel(int nbLevel)
        {
            //on ajoute à ses attibuts son nouveau niveau
            CurrentHealth += nbLevel;
            MaxHealth += nbLevel;
            Level += nbLevel;
            Console.WriteLine(this.Name + " Take a new level");
            Console.WriteLine("Current health : " + CurrentHealth +"\nMax : " + MaxHealth + "\n" + "Level : " + Level);
            //Son hit maximum dépend dans quel dizaine est son niveau
            if ((Level % 10) >= 1)
            {
                MaxHit = ((int)(Level / 10)) + 1;
            }
        }

        //Méthode pour qu'un soldat prenne un dommage
        public void TakeDamage(int damageTaken)
        {
            CurrentHealth -= damageTaken;
            //Si le soldat meurt au combat
            if (CurrentHealth<=0)
            {
                Console.WriteLine(Name + " fainted \n");
            }
        }

        //Méthode pour que le soldat gagne de la vie
        public void TakeHeal(int healTaken)
        {
            //Si ça dépasse son maximum de vie possible
            if ((CurrentHealth + healTaken) > MaxHealth)
            {
                CurrentHealth = MaxHealth;
            }
            else
            {
                CurrentHealth += healTaken;
            }
        }

        //Méthode pour qu'un soldat attaque un zombie
        public void Attack(Zombie zombieAttacked)
        {
            //le zombie prend le dommage du soldat
            Console.WriteLine(this.Name + "attack " + zombieAttacked.Name);
            zombieAttacked.TakeDamage(this.Damage);
            Console.WriteLine(zombieAttacked.Name + " life :" + zombieAttacked.CurrentHealth);
            //le soldat incrémente son compteur de zombie tués
            if (zombieAttacked.CurrentHealth <= 0 )
            {
                this.ZombieKillesThisTurn += 1;
            }
        }

        //Getter et Setter
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }
        public int CurrentHit { get; set; }
        
        public int MaxHit{ get; set; }
        public int Level { get; set; }
        public int Damage { get; set; }
        public int ZombieKillesThisTurn { get; set; }
        public string Name { get; set; }

        //Méthode pour voir tous les attibuts du soldat
        public override string ToString()
        {
            return "Soldier\nCurrent health : " + CurrentHealth + "\nMax Health : " + MaxHealth + "\nCurrentHit : " + CurrentHit + "\nMax hit : " + MaxHit + "\nLevel : " + Level+ "\nDamage : " + Damage+"\nZombie killes this turn : " +ZombieKillesThisTurn+"\nName : " + Name;
        }

    }




}
