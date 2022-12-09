namespace AutoLibrary
{
    public class Auto
    {
        string brand;
        int hp;
        int speedatm;
        int gearatm;
        bool engineon = false;


        public bool IsEngineOn
        {
            get { return engineon; }
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
        public string GetHorsepower()
        {
            return Convert.ToString(this.hp) + " PS";
        }
    }
}