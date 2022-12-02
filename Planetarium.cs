namespace Planetarium;

using System.Collections;

interface IPlanet
{
    double Distance
    {
        get;
        set;
    }
   
}
class Planet : IPlanet
{
    private double DistanceToSun, OrbitalSpeed, Diameter;
    public virtual double Distance
    {
        get {return DistanceToSun;}
        set {DistanceToSun = value;}
    }

    public virtual double Speed { get => OrbitalSpeed; set => OrbitalSpeed = value;}
    public virtual double Diam {get => Diameter; set => Diameter = value;}

    public static void Do() {Console.WriteLine("Do");}
}

class RockPlanet : Planet
{
    public bool CanLand = true;
    public virtual bool Land {get => CanLand;}
}

class GasPlanet : Planet
{
    public bool CanLand = false;
    public virtual bool Land {get => CanLand;}
}

class Earth : RockPlanet
{
    private static Earth? instance = null;

    private double DistanceToSun = 123456;
    public override double Distance {get => DistanceToSun;}

    public static Earth Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Earth();
            }
            return instance;
        }
    }
    private Earth()
    {
        Console.WriteLine("I am Earth");
    }
}

class Venus : RockPlanet
{
    private static Venus instance = null;

    public static Venus Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Venus();
            }
            return instance;
        }
    }

    private Venus()
    {
        Console.WriteLine("I am Venus");
    }
}

class Jupiter : GasPlanet
{
    private static Jupiter instance = null;

    public static Jupiter Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Jupiter();
            }
            return instance;
        }
    }
    private Jupiter()
    {
        Console.WriteLine("I am Jupiter");
    }
}

class PlanetInventory : IEnumerator, IEnumerable
{
    private ArrayList planets = new ArrayList(); // Composition

    public PlanetInventory()
    {
        planets.Add(Venus.Instance);
        planets.Add(Earth.Instance);
        planets.Add(Jupiter.Instance);
    }
    public void ListPlanets()
    {
        foreach(Planet p in planets)
            Console.WriteLine(p.GetType() + " " + p.Diam);
    }

    #region iterable
    int position = -1;
    public IEnumerator GetEnumerator()
    {
        return (IEnumerator)this;
    }

    public bool MoveNext()
    {
        position++;
        if(planets[position] == null)
            return false;
        return (position <= planets.Count-1);
    }
    public void Reset()
    {
        position = -1;
    }

    public object Current
    {
        get { return planets[position]; }
    }
    #endregion   

    
}
