namespace customers
{
    public class customer
    {
        private string name;
        private string order;
        public customer(string name)
        {
            this.name = name;
            Console.WriteLine(this.name);
        }

        public void setName(string newName)
        {
            name = newName;
            Console.WriteLine(name);
        }

        public void placeOrder()
        {
            Console.WriteLine("Was möchten sie bestellen?");
            string order = Console.ReadLine();
            Console.WriteLine("Sie haben 1x " + order + " auf den Namen: "+ name + " bestellt.");
        }

        public void setOrder()
        {
            Console.WriteLine("Wie lautet ihre neue Bestellung?");
            order = Console.ReadLine();
            Console.WriteLine("Sie haben 1x " + order + " auf den Namen: "+ name + " bestellt.");

        }

    }
}