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

        //Constructeur par défaut
        public Zombie()
        { }

        //Constructeur avec tous les attributs d'un zombie
        public Zombie(int newCurrentHealth, int newMaxHealth, int newCurrentHit, int newMaxHit, int newLevel, int newDamage, string newNameZombie)
        {
            CurrentHealth = newCurrentHealth;
            MaxHealth = newMaxHealth;
            CurrentHit = newCurrentHit;
            MaxHit = newMaxHit;
            Damage = newDamage;
            Name = newNameZombie;
        }

        //Fonction pour savoir si le zombie est en vie
        public bool IsAlive()
        {
            return (CurrentHealth > 0);
        }

        //Méthode pour que le zombie prenne des dégats
        public void TakeDamage(int damageTaken)
        {
            CurrentHealth -= damageTaken;
            //Si le zombie est battu
            
            if (CurrentHealth <=0)
            {
                Console.WriteLine(Name + " fainted \n");
            }
        }

        //Fonction pour savoir si le zombie peut attaquer (si il lui reste des coups à donner)
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

        //Méthode pour que le zombie attaque
        public void Attack(Soldier soldierAttacked, Wall protectionWall)
        {
            //Le zombie attaque en priorité le mur (si il est encore debout)
            if (protectionWall.IsDown())
            {
                Console.WriteLine(this.Name + " Attack " + soldierAttacked.Name);
                soldierAttacked.TakeDamage(this.Damage);
                Console.WriteLine(soldierAttacked.Name +" life : " + soldierAttacked.CurrentHealth);

            }
            else
            {
                Console.WriteLine(this.Name +" Attack the wall");
                protectionWall.TakeDamage(this.Damage);
                Console.WriteLine("Wall life : " + protectionWall.CurrentHealth);
            }
        }

        //Getter et Setter
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }
        public int CurrentHit { get; set; }
        public int MaxHit { get; set; }
        public int Damage { get; set; }
        public string Name { get; set; }

        //Méthode pour voir tous les attributs du zombie
        public override string ToString()
        {
            return "Zombie\nCurrent health : " + CurrentHealth + "\nMax Health : " + MaxHealth + "\nCurrentHit : " + CurrentHit + "\nMax hit : " + MaxHit + "\nDamage : " + Damage + "\nName : " + Name+"\n";
        }
    }
}
