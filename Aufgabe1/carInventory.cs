namespace Cars
{
    public class CarInventory
    {
        private Car[] carArray = new Car[10];

        public void AddCar(Car temp)
        {
            if(carArray.Count(s => s != null) == 10)
            {
                Console.WriteLine("Inventory is full");
            }
            else
            {
                carArray[carArray.Count(s => s != null)] = temp;
                Console.WriteLine("Addition completed");
            }
            
        }

        public void ShowCar()
        {
            for(int i = 0; i < carArray.Count(s => s != null); i++)
            {
                if(carArray[i].IstBenzin)
                {
                    Console.WriteLine(carArray[i].Typ + ", Benzinantrieb, Füllstand: " + carArray[i].Tank * 100 + " %");
                }
                else
                {
                    Console.WriteLine(carArray[i].Typ + ", Elektroantrieb, Ladestand " + carArray[i].Tank * 100 + " %");
                }
                
            }
        }

        public void DeleteLastCar()
        {
            carArray[carArray.Count(s => s != null) - 1] = null;
        }

        public void DeleteCar(Car temp)
        {
            int count = carArray.Count(s => s != null);
            for(int i = 0; i < count; i ++)
            {
                if(carArray[i] == temp)
                {
                    carArray[i] = null;
                    for(int j = i; j < count - 1; j ++)
                    {
                        carArray[j] = carArray[j + 1];
                    }
                    carArray[count - 1] = null;
                }
            }

            
        }
    }
}