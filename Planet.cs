// using System.Collections;
// namespace Planets
// {
//     public class Planet1 : IPlanet
//     {
//         private double[] plantetStats = new double[2]; //2.c
//         private double distance;
//         private double speed;
//         private string name;
//         private int numbMoons; //2.b
//         public virtual string Name
//         {
//             get
//             {
//                 return name;
//             } 
//             set
//             {
//                 name = value;
//             }
//         }
//         public virtual int NumbMoons //2.b
//         {
//             get
//             {
//                 return numbMoons;
//             } 
//             set
//             {
//                 numbMoons = value;
//             }
//         }
//         public virtual double Speed
//         {
//             get
//             {
//                 return speed;
//             } 
//             set
//             {
//                 speed = value;
//             }
//         }
//         public virtual double Distance 
//         {
//             get
//             {
//                 return distance;
//             } 
//             set
//             {
//                 distance = value;
//             }
//         }
//         public Planet1() //2.a
//         {
//         }
//         public Planet1(string name) //2.a
//         {
//             this.name = name;
//         }
//         public virtual void fillArray() //2.d
//         {
//             plantetStats[0] = Distance;
//             plantetStats[1] = Speed;
//         }

//         public virtual void readArray() //2.d
//         {
//             Console.WriteLine(name + ":");
//             Console.WriteLine("Distance to sun: " + plantetStats[0] + " km");
//             Console.WriteLine("Speed around the sun: " + plantetStats[1] + " km/s");
//         }
//     }
//     public class Erde : Rockplanet
//     {
//         private static Erde instance = null;

//         public static Erde Instance
//         {
//             get
//             {
//                 if(instance == null)
//                 {
//                     instance = new Erde();
//                 }
//                 return instance;
//             }
//         }
//         private Erde()
//         {

//         }

//     }

//     public class Jupiter1 : Gasplanet
//     {
//         private static Jupiter1 instance = null;

//         public static Jupiter1 Instance
//         {
//             get
//             {
//                 if(instance == null)
//                 {
//                     instance = new Jupiter1();
//                 }
//                 return instance;
//             }
//         }
//         private Jupiter1()
//         {

//         }

//     }
//     public class Rockplanet : Planet
//     {
//         private bool canLand = true;
//         public virtual bool Land {get => canLand;}
//     }
//     public class Gasplanet : Planet
//     {
//         private bool canLand = false;
//         public virtual bool Land {get => canLand;}
//     }

//     public class PlanetInventory1
//     {
//         private ArrayList planets = new ArrayList();
//         public PlanetInventory1()
//         {
//             planets.Add(Erde.Instance);
//             // planets.Add(Jupiter.Instance);
//         }
//     }

//     interface IPlanet
//     {
//         double Distance {get; set;}
//     }
// }


