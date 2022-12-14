using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSim
{
    
    public class Auto
    {
        string brand;
        int hp;
        int currentspeed = 0;
        int currentgear;
        bool engineon = false;
        int maxspeed;

        public int CurrentGear 
        { 
            set { currentgear = value;  } 
            get { return currentgear;   }
        }
        public bool IsEngineOn
        {
            get { return engineon; }
        }
        public int CurrentSpeed
        {
            set { currentspeed = value; }
            get { return currentspeed;  }
        }

        public Auto(string brandinput, int hpinput)
        {
            brand = brandinput;
            hp = hpinput;
        }

        /// <summary>
        /// Startet den Motor.
        /// </summary>
        public void StartEngine()
        {
             engineon = true;
        }

        public void TurnOffEngine()
        {
            engineon = false;
        }

        public void Accelerate()
        {
            maxspeed = hp+39;

            if (currentspeed <= maxspeed)
            {
                currentspeed += hp / 45;
            }
            else if(currentspeed > maxspeed) 
            {
                currentspeed = maxspeed+1; 
            }
        }
        public void Break()
        {
            currentspeed -= 5;
        }
        public void Horn()
        {

        }
        public override string ToString()
        {
            return this.brand;
        }
        public string GetHorsepower()
        {
            return Convert.ToString(this.hp) + " PS";
        }
        public void CalculateCurrentGear()
        {
            if (currentspeed < 1)
            {
                currentgear = 0;
            }
            if(currentspeed <= 10 && currentspeed>0)
            {
                currentgear = 1;
            }
            else if(currentspeed <= 20 && currentspeed>10)
            {
                currentgear = 2;
            }
            else if(currentspeed <= 40 && currentspeed > 20)
            {
                currentgear = 3;
            }
            else if(currentspeed <= 70 && currentspeed > 40)
            {
                currentgear = 4;
            }
            else if (currentspeed <= 100 && currentspeed > 70)
            {
                currentgear = 5;
            }
            else if (currentspeed > 100)
            {
                currentgear = 6;
            }
        }
    }
}
