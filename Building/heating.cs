public class Heating{
    private float temp = 0;
    private string room = "";
    public Heating(string room){
        this.room = room;
    }
    public string getroom(){
        return this.room;
    }
    public float getTemp(){
        return this.temp;
    }
    public bool turnOnHeating(){
        return true;
    }
    public bool turnOffheating(){
        return false;
    }
    public bool setTemp(){
        Console.WriteLine("Set Temperature:");
        float Temp = float.Parse(Console.ReadLine());
        temp = Temp;
        return true;
    }
    public bool checkHeating(float Temperature){
        if(Temperature<= this.temp){
            return turnOnHeating();
        }else{
            return turnOffheating();
        }
    }

}
