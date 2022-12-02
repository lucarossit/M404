public class cube
{
    public static void drawCube(int count)
    {
        for(int i = 0; i < count; i++)
        {
            Console.Write("* ");
        }
        Console.WriteLine();
        for(int i = 0; i < count-2 ; i++)
        {
            Console.Write("* ");
            for(int j = 0; j <count-2; j++)
            {
                Console.Write("  ");
            }
            Console.WriteLine("*");
        }
        for(int i = 0; i < count; i++)
        {
            Console.Write("* ");
        }
    }
}