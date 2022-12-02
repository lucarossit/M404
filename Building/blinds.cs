public class Blinds
{
    bool open = true;


    public void closeBlinds()
    {
        Console.WriteLine("Closing the Blinds now.");
        open = false;
    }
    public void openBlinds()
    {
        Console.WriteLine("Opening the Blinds now.");
        open = true;
    }

    public string menuBlinds()
    {
        Console.WriteLine("What do you wanna do?");
        Console.WriteLine("Open the Blinds      press o");
        Console.WriteLine("Close the Blinds     press c");
        string menu = Console.ReadLine();
        if (menu != "o" && menu != "c")
        {
            Console.WriteLine("Error. Please try again!");
            menuBlinds();
        }
        return menu;

    }

    public void checkBlinds()
    {
        if (open == true)
        {
            Console.WriteLine("The Blinds are open");
        }
        else
        {
            Console.WriteLine("The Blinds are closed");
        }

    }
}
