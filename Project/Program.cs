//Clément Simon & Florian Allermoz - C# Project - 2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Project.Entity;
using Project.TimeEntity;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {

            //Création des joueur de la partie
            List<Soldier> ListOfSoldier = InitSoldier(3);
            Wall DefenseWall = new Wall(10, 10);
            Wave vagueTest = new Wave(1, 10);
            vagueTest.Play(ListOfSoldier, DefenseWall);
            vagueTest.UpdateLevel(ListOfSoldier);
            Console.ReadLine();
            

        }



        public static List<Soldier> InitSoldier(int NbSoldiers)
        {
            //initialisation des soldats
            List<Soldier> ListOfSoldier = new List<Soldier>();
            for(int i = 0; i < NbSoldiers; i ++)
            {

                Soldier NewSoldier = new Soldier(3, 3, 1, 1, 1, 1, 0,"Soldier "+(i+1));

                ListOfSoldier.Add(NewSoldier);
            }
            return ListOfSoldier;
        }
    }
}
