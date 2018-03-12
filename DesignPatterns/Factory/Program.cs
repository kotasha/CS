using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            EnemyShip theEnemy = null;
            EnemyShipFactory shipFactory = new EnemyShipFactory();
            Console.WriteLine("What type of ship? Enter ( U / R )");
            string userInput = Console.ReadLine() ;
            
            theEnemy= shipFactory.makeEnemyShip(userInput);
            doStuffEnemy(theEnemy);
            Console.ReadLine();
        }

        public static void doStuffEnemy(EnemyShip anEnemyShip)
        {
            anEnemyShip.displayEnemyShip();
            anEnemyShip.followHeroShip();
            anEnemyShip.enemyShipShoots();
        }
    }
}
