using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory
{
    public abstract class EnemyShip
    {
        private string name;
        private double amtDamage;
        public string getName()        {            return name;        }
        public void setName(string newName)        {            name = newName;        }
        public string getDamage()        {            return name;        }
        public void setDamage(double newDamage){         amtDamage = newDamage;   }

        public void followHeroShip()
        {
            Console.WriteLine(getName()+" Following the Hero");
        }
        public void displayEnemyShip()
        {
            Console.WriteLine(getName() + "Is on the screen");
        }
        public void enemyShipShoots()
        {
            Console.WriteLine(getName() + " Attacks and Does " + getDamage());
        }
    }

    public class UFOEnemyShip : EnemyShip
    { 
    public UFOEnemyShip()
    {
        setName("UFO enemyShip");
        setDamage(200);
    }
    }
    
    public class RocketEnemyShip : EnemyShip
    {
        public RocketEnemyShip()
        {
            setName("Rocket enemyShip");
            setDamage(200);
        }
    }

    public class EnemyShipFactory
    {
        public EnemyShip makeEnemyShip(string selectedShip)
        {
            if (selectedShip.Contains("U"))
                return new UFOEnemyShip();
            if (selectedShip.Contains("u"))
                return new UFOEnemyShip();
            
            if (selectedShip.Contains("R"))
                return new RocketEnemyShip();
            if (selectedShip.Contains("r"))
                return new RocketEnemyShip();
            
            return null;
        }
    }
}
