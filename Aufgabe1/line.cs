namespace lines
{
    public class line
    {
        public static void lineVertical(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write("-");
            }
        }

        public static void lineHorizontal(int count)
        {
            for (int j = 0; j < count; j++)
            {
                for (int i = 0; i < 50; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("|");
            }

        }
    }
}