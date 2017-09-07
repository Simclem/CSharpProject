using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Entity;
namespace Project.TimeEntity
{
    class Turn
    {
        private int idTurn;





        public void AttackPhase(List<Soldier> ListOfSoldier, List<Zombie>ListOfZombie)
        {
            for (int i = 0; i < ListOfSoldier.Count; i++)
            {

            }
        }








        public void DisplayAllZombies(List<Zombie> ListOfZombie)
        {
            for ( int i = 0; i < ListOfZombie.Count; i ++)
            {
                ListOfZombie[i].ToString();
            }
        }


        public Zombie FindFirstZombieAlive(List<Zombie> ListOfZombie)
        {
            int i = 0;
            while ((!ListOfZombie[i].IsAlive()) && (i< ListOfZombie.Count))
            {
                if (ListOfZombie[i].IsAlive())
                {
                    return (ListOfZombie[i]);
                }
                i++;
            }
            return null;
        }








        public int IdTurn
        {
            get
            {
                return this.idTurn;
            }
            set
            {
                this.idTurn = value;
            }
        }
        private string ToString()
        {
            return "";
        }
    }
}
