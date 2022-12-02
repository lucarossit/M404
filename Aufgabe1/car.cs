namespace Cars
{
    public class Car
    {
        public string Typ {get; set;}
        public bool IstBenzin {get; set;}
        public double Tank {get; set;}
        public Car(string typ, bool istBenzin, double tank)
        {
            Typ = typ;
            Tank = tank;
            IstBenzin = istBenzin;
        }
        public Car(string typ, bool istBenzin)
        {
            Typ = typ;
            Tank = 0.5;
            IstBenzin = istBenzin;
        }
        public Car(string typ)
        {
            Typ = typ;
            Tank = 0.5;
            IstBenzin = true;
        }

        public double GetTank()
        {
            return Tank * 100;
        }
    }
}