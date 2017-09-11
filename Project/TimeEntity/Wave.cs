//Clément Simon & Florian Allermoz - C# Project - 2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Entity;
namespace Project.TimeEntity
{
    class Wave
    {

        //Attributs de la vague 
        private int idWave;
        private int numberZombies;
        private List<Zombie> listOfZombie;
        //Constructeur par défaut
        public Wave()
        { }

        //Constructeur avec les attributs
        public Wave(int NewIdWave, int NewNumberZombies)
        {
            IdWave = NewIdWave;
            NumberZombies = NewNumberZombies;
            ListOfZombie = InitZombie(NumberZombies);

        }

        //Méthode pour commencer la vague
        public void Play(List<Soldier> ListOfSoldier, Wall DefenseWall)
        {
            int i = 1;
            while ((AreSoldierAlive(ListOfSoldier) == true) && (AreZombieAlive(ListOfZombie)))
            {
                Turn NewTurn = new Turn(i);
                NewTurn.AttackPhase(ListOfSoldier, ListOfZombie, DefenseWall);
                i++;
            }
            Console.WriteLine("End Wave");
            //TODO Créer le nombre de zombie qui vont attaquer

        }

        //Méthode pour augmenter les niveaux des soldats
        public void UpdateLevel(List<Soldier> ListOfSoldier)
        {
            for (int i = 0; i < ListOfSoldier.Count; i ++)
            {
                //si un soldat a tué au moins un zombie, on lui augmente son niveau
                if (ListOfSoldier[i].ZombieKillesThisTurn > 0)
                {
                    ListOfSoldier[i].TakeLevel(ListOfSoldier[i].ZombieKillesThisTurn);
                }
            }
        }
        public bool AreSoldierAlive(List<Soldier> ListOfSoldier)
        {
            for (int i = 0; i < ListOfSoldier.Count; i++)
            {
                if (ListOfSoldier[i].IsAlive())
                {
                    return true;
                }
            }
            return false;
        }

        public bool AreZombieAlive(List<Zombie> ListOfZombie)
        {
            for (int i = 0; i < ListOfZombie.Count; i++)
            {
                if (ListOfZombie[i].IsAlive())
                {
                    return true;
                }
            }
            return false;
        }

        public static List<Zombie> InitZombie(int NZombie)
        {
            //initialisation des zombies
            List<Zombie> ListZombie = new List<Zombie>();
            for (int i = 0; i < NZombie; i++)
            {

                Zombie NewZombie = new Zombie(3, 3, 1, 1, 1, 1,"Zombie " + (i + 1));

                ListZombie.Add(NewZombie);
            }
            Console.WriteLine("Pause");
            return ListZombie;
        }

        //Getter et Setter
        public int IdWave
        {
            get
            {
                return this.idWave;
            }
            set
            {
                this.idWave = value;
            }
        }
        public int NumberZombies
        {
            get
            {
                return this.numberZombies;
            }
            set
            {
                this.numberZombies = value;
            }
        }
        public List<Zombie> ListOfZombie
        {
            get
            {
                return this.listOfZombie;
            }
            set
            {
                this.listOfZombie = value;
            }
        }

        //Méthode pour voir tous les attributs de la vague
        public string ToString()
        {
            return ("Wave : \nIdWave : " + this.IdWave+"\nNumber Zombie : " +this.NumberZombies);
        }
    }
}
