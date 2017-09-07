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

        //Constructeur par défaut
        public Wave()
        { }

        //Constructeur avec les attributs
        public Wave(int NewIdWave, int NewNumberZombies)
        {
            IdWave = NewIdWave;
            NumberZombies = NewNumberZombies;
        }

<<<<<<< HEAD
        //Méthode pour commencer la vague
=======
>>>>>>> 227166f808e65f16fda2e9e45ec99480bfdcc921
        public void Play(List<Soldier> ListOfSoldier, Wall DefenseWall)
        {
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

        //Méthode pour voir tous les attributs de la vague
        public string ToString()
        {
            return ("Wave : \nIdWave : " + this.IdWave+"\nNumber Zombie : " +this.NumberZombies);
        }
    }
}
