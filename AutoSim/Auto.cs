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
        int speedatm;
        int gearatm;
        bool engineon;
        public Auto(string brandinput, int hpinput)
        {
            brand = brandinput;
            hp = hpinput;
        }
        public void StartEngine()
        {
            if (engineon == true) { engineon = false; }
            if (engineon == false) { engineon = true; }
        }
        public void TurnOffEngine()
        {

        }
        public void Accelerate()
        {

        }
        public void Break()
        {

        }
        public void Horn()
        {

        }
        public override string ToString()
        {
            return this.brand;
        }
    }
}
