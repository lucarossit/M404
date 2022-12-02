public class AirCon{

    bool statusAC = true;
    public void turnOnAC(){
        statusAC = true;
        Console.WriteLine("AC is getting turned on");
    }

    public void turnOffAC(){
        statusAC = false;
        Console.WriteLine("AC is getting turned off");
    }

    public void checkAC(){
        if(statusAC==true){
            Console.WriteLine("The AC is on");
        }else{
            Console.WriteLine("The AC is off");
        }
    }

    public string menuAC(){
        Console.WriteLine("What do you wanna do?");
        Console.WriteLine("Turn On AC           Press o");
        Console.WriteLine("Turn Off AC          Press f");
        string menu = Console.ReadLine();
        if(menu!="o" && menu != "f"){
            Console.WriteLine("Error. Please Try again.");
            menuAC();
        }
        return menu;
    }
}