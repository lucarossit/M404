using lines;
using textColors;
using customers;
using electronicShop;
using FileIOs;
using logs;
using Cars;
using Instruments;

using Planetarium;
class HelloProgramm
{

    static void Main(String[] args)
    {
        InstrInventory invent = new InstrInventory();
        invent.ListInstruments();
        var piano1 = new Piano();
        var piano2 = new Piano();
        var violin1 = new Violin();
        var violin2 = new Violin();
        var drum1 = new Drum();
        var drum2 = new Drum();

        invent.AddInstrument(piano1);
        invent.AddInstrument(piano2);
        invent.AddInstrument(violin1);
        invent.AddInstrument(violin2);
        invent.AddInstrument(drum1);
        invent.AddInstrument(drum2);

        invent.ListInstruments();
        // var earth = Earth.Instance;
        // var earth2 = Earth.Instance;
        // Console.WriteLine(earth.GetHashCode());
        // Console.WriteLine(earth2.GetHashCode());
        // earth.Distance = 149.6;
        // earth.Speed = 29.8;
        // earth.Diam = 12756;
        // var venus = Venus.Instance;
        // venus.Distance = 108.2;
        // venus.Speed = 35.0;
        // venus.Diam = 12104;
        // var jupiter = Jupiter.Instance;
        // jupiter.Distance = 778.5;
        // jupiter.Speed = 13.1;
        // jupiter.Diam = 142984;

        // Console.WriteLine("Planet\t\tDistance from sun (10^6km)\tOrbital Speed (km/s)\tDiameter (km)");
        // Console.WriteLine($"Earth:\t\t{earth.Distance}\t\t\t\t{earth.Speed}\t\t\t{earth.Diam}");
        // Console.WriteLine($"Venus:\t\t{venus.Distance}\t\t\t\t{venus.Speed}\t\t\t{venus.Diam}");
        // Console.WriteLine($"Jupiter:\t{jupiter.Distance}\t\t\t\t{jupiter.Speed}\t\t\t{jupiter.Diam}");

        // Console.WriteLine("\n\n");
        // Console.WriteLine($"Jupiter {jupiter.GetType()}");
        // Console.WriteLine($"Earth {earth.GetType()}");

        // Console.WriteLine($"\nEarth can be landed {earth.Land: \"yes\" : \"no\"}");
        // Console.WriteLine($"Venus can be landed {venus.Land: \"yes\" : \"no\"}");
        // Console.WriteLine($"Jupiter can be landed {jupiter.Land: \"yes\" : \"no\"}");

        // var pl = new Planet();
        // Planet.Do();
        // Console.WriteLine(pl.Distance);
        // Earth.Do();

        // var planetInventory = new PlanetInventory();
        // planetInventory.ListPlanets();

        // Console.WriteLine("\n");
        // foreach (Planet p in planetInventory)
        // {
        //     Console.WriteLine($"Planet {p.GetType()}");
        // }



        // var erde = Erde.Instance;
        // var jupiter = Jupiter.Instance;
        // erde.Distance = 5;
        // jupiter.Distance = 10;
        // erde.NumbMoons = 1;
        // jupiter.NumbMoons = 20;
        // Console.WriteLine(erde.NumbMoons);
        // PlanetInventory planets = new PlanetInventory();

        // Car car1 = new Car("Sportwagen");
        // Car car2 = new Car("Personenwagen", false, 0.7);
        // Car car3 = new Car("Transportwagen", true, 0.9);
        // Car car4 = new Car("Transportwagen", false, 0.9);
        // Car car5 = new Car("Transportwagen", true, 0.3);
        // CarInventory test = new CarInventory();
        // test.AddCar(car1);
        // test.AddCar(car2);
        // test.AddCar(car3);
        // test.AddCar(car4);
        // test.AddCar(car5);
        // test.ShowCar();
        // Console.WriteLine();
        // test.DeleteLastCar();
        // test.ShowCar();
        // Console.WriteLine();
        // test.DeleteCar(car1);
        // test.ShowCar();


        // string bFQuote = "Tell me and I forget.";
        // string filePath1 = "C:\\projects\\M404\\Data\\";
        // string filePath2 = "C:\\projects\\M404\\Data\\text2.txt";
        // string filePath3 = "C:\\projects\\M404\\Data\\text3.txt";
        // string filePath4 = "C:\\projects\\M404\\Data\\text4.txt";
        // string filePath5 = "C:\\projects\\M404\\Data\\text5.txt";
        // string path = "C:\\projects";

        // log test = new log();
        // test.WriteLog(filePath1);
        // FileIO file1 = new FileIO();
        // FileIO file2 = new FileIO();

        // file1.GetDirectory(path);

        // file1.moveFile(filePath1, filePath5);
        // file1.WriteToFile(filePath1, bFQuote);
        // file2.WriteToFile(filePath2);

        // file1.DeleteLine(filePath1, "Hello");

        // file2.DeleteLine(filePath2, 1);

        // file1.SearchString(filePath1,"Tell me and I forget.");
        // file1.SearchString(filePath1,"Hi");

        // Console.WriteLine("Geben sie ihren Namen ein.");
        // string name = Console.ReadLine();
        // Console.WriteLine("Geben sie ein Passwort ein.");
        // string password = Console.ReadLine();

        // var customer1 = new electronicShop.customer(name, password);
        // customer1.getBuisness();
        // customer1.setBuisness();
        // customer1.getBuisness();
        // customer1.placeOrder();
        // customer1.getOrder();

        // Console.WriteLine("Wie ist ihr Name?");
        // string name = Console.ReadLine();
        // var customer1 = new customers.customer(name);
        // customer1.placeOrder();
        // Console.WriteLine("Wie ist ihr neuer Name?");
        // name = Console.ReadLine();
        // customer1.setName(name);
        // customer1.setOrder();



        // Console.WriteLine("Was möchten sie schreiben?");
        // string text = Console.ReadLine();
        // Console.WriteLine("Welche Farbe soll der Text haben?(B)lau, (R)ot, (G)rün ,(S)chwarz, (W)eiss");
        // char textColour = char.Parse(Console.ReadLine());
        // Console.WriteLine("Welche Farbe soll der Hintergrund haben?(B)lau, (R)ot, (G)rün ,(S)chwarz, (W)eiss");
        // char backgroundColor = char.Parse(Console.ReadLine());

        // var test = new textColor(textColour, backgroundColor);
        // test.writeColor(text);


        // Console.WriteLine("Wie lang soll eine Würfelseite sein?");
        // int count = int.Parse(Console.ReadLine());
        // cube.drawCube(count);


        // Console.WriteLine("Wie viele Zeichen möchten sie ausgeben?");
        // line.lineHorizontal(count);
        // line.lineVertical(count);



        // AirCon ac1 = new AirCon();
        // string menu = ac1.menuAC();
        // if(menu=="o"){
        //     ac1.turnOnAC();
        // }else{
        //     ac1.turnOffAC();
        // }
        // ac1.checkAC();



        /*
        Blinds b1 = new Blinds();

        string menu = b1.menuBlinds();
        if (menu == "o")
        {
            b1.openBlinds();
        }
        else
        {
            b1.closeBlinds();
        }

        b1.checkBlinds();*/





        /*
        Console.WriteLine("Geben sie die Temperatur ein");
        float Temperatur = float.Parse(Console.ReadLine());

        int[] iArr = {3, 5, 9, 6};
        Console.WriteLine(iArr.Max());

        Heating h1 = new Heating("Room 1");
        Heating h2 = new Heating("Room2");

        int max_room = 10;
        Heating [] hArr = new Heating[max_room];
        for(int i =0; i< max_room; i++){
            hArr[i] = new Heating("Room" + i);
        }

        foreach(Heating h in hArr){
            Console.WriteLine("Room: " + h.getroom());
        }

        bool heat=false;
        h1.setTemp();
        Console.WriteLine(h1.getTemp());
        //Console.WriteLine(h1.getroom());
        heat = h1.checkHeating(Temperatur);

        Console.WriteLine(heat);*/
    }
}