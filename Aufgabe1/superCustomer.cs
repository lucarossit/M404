namespace superCustomers
{
    public class superCustomers
    {
        public static bool login(string name, string password)
        {
            Console.WriteLine("Geben sie ihren Benutzernamen ein.");
            string tempName = Console.ReadLine();
            Console.WriteLine("Geben sie ihr Passwort ein.");
            string tempPassword = Console.ReadLine();
            if(tempName != name || tempPassword != password)
            {
                Console.WriteLine("Passwort oder Benutzername sind falsch.");
                login(name, password);
            }
            return true;
        }

        public static bool setBuisness()
        {
            Console.WriteLine("Sind sie ein (P)rivat- oder (G)eschäftskunde?");
        char buisness = char.Parse(Console.ReadLine());
        if (buisness == 'P')
        {
            return false;
        }
        else
        {
            if (buisness == 'G')
            {
                return true;
            }
            else
            {
                Console.WriteLine("Falscheingabe!");
                return setBuisness();
            }
        }
        }

        public static void getBuisness(bool buisness)
        {
            if(buisness==true)
            {
                Console.WriteLine("Sie sind ein Geschäftskunde.");
            }
            else
            {
                Console.WriteLine("Sie sind ein Privatkunde");
            }
        }
        public static string placeOrder(string name, string password)
        {
            login(name, password);
            Console.WriteLine("Geben sie ihre Bestellung an.");
            string order = Console.ReadLine();
            Console.WriteLine("Sie haben 1x " + order + " auf den Namen " + name + " bestellt.");
            return order;
        }
    }
}