using superCustomers;
namespace electronicShop
{
    public class customer
    {
        private string name;
        private bool buisness;
        private string password;
        private string order;
        public customer(string name, string password)
        {
            this.name = name;
            this.password = password;
            this.buisness = superCustomers.superCustomers.setBuisness();
            Console.WriteLine("Ihr Name ist: "+ name);
        }

        public void setBuisness()
        {
            buisness = superCustomers.superCustomers.setBuisness();
        }
        public void getBuisness()
        {
            superCustomers.superCustomers.getBuisness(buisness);
        }

        public void changePassword()
        {
            Console.WriteLine("Geben sie das neue Passwort ein.");
            password = Console.ReadLine();
        }
        
        
         
        public void placeOrder()
        {
            order = superCustomers.superCustomers.placeOrder(name, password);
        }

        public void getOrder()
        {
            Console.WriteLine(order);
        }
    }
}