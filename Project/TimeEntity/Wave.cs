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
        private int idWave;
        private int numberZombies;


        public Wave()
        { }

        public Wave(int NewIdWave, int NewNumberZombies)
        {
            IdWave = NewIdWave;
            NumberZombies = NewNumberZombies;
        }
        public void Play(List<Soldier> ListOfSoldier, Wall DefenseWall)
        {

        }

        public void UpdateLevel(List<Soldier> ListOfSoldier)
        {
            for (int i = 0; i < ListOfSoldier.Count; i ++)
            {
                if (ListOfSoldier[i].ZombieKillesThisTurn > 0)
                {
                    ListOfSoldier[i].TakeLevel(ListOfSoldier[i].ZombieKillesThisTurn);
                }
            }
        }
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
        public string ToString()
        {
            return ("Wave : \nIdWave : " + this.IdWave+"\nNumber Zombie : " +this.NumberZombies);
        }
    }
}
