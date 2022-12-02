namespace textColors
{
    public class textColor
    {
        private char textColour;
        private char backgroundColor;
        public textColor(char textColor ,char backgroundColor)
        {
            this.textColour = textColor;
            this.backgroundColor = backgroundColor;
        }
        public void writeColor(string text)
        {
            if(backgroundColor=='B')
            {
                Console.BackgroundColor = ConsoleColor.Blue;
            }
            else
            {
                if(backgroundColor=='R')
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                }
                else
                {
                    if(backgroundColor=='G')
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        if(backgroundColor=='S')
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                        }
                        
                    }
                }
            }
            if(textColour=='B')
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else
            {
                if(textColour=='R')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    if(textColour=='G')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        if(textColour=='S')
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        
                    }
                }
            }
            
            Console.WriteLine(text);
        }
    }
}