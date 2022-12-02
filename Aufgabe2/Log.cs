namespace logs;
public class log
{
    public void WriteLog(string filePath)
    {
        int count = 0;
        string message = "";
        string priority = "";
        int files = 0;
        string space = "";
        do
        {
            if (files == 0)
            {
                filePath = filePath + $"Log{files}.txt";
            }
            else
            {
                filePath = filePath.Replace($"Log{files - 1}.txt", $"Log{files}.txt");
            }
            count = 0;
            do
            {
                String timeStamp = GetTimestamp(DateTime.Now);
                Console.WriteLine(timeStamp);

                Random random = new Random();
                int choose = random.Next(0, 5);

                switch (choose)
                {
                    case 0:
                        message = "Everything OK";
                        priority = "Low";
                        break;

                    case 1:
                        message = "Something went wrong";
                        priority = "medium";
                        break;

                    case 2:
                        message = "Pc is going to die";
                        priority = "high";
                        break;

                    case 3:
                        message = "RAM is full";
                        priority = "high";
                        break;

                    case 4:
                        message = "Harddisk is full";
                        priority = "high";
                        break;

                    default:
                        break;
                }
                string temp = timeStamp + "   " + message;
                space = "";
                for (int i = 0; i < 50 - temp.Length; i++)
                {
                    space += " ";
                }

                string line = timeStamp + "   " + message + space + priority;

                if (!File.Exists(filePath))
                {
                    using (StreamWriter sw = File.CreateText(filePath))
                    {
                        sw.WriteLine("Date" + "        " + "Time" + "       " + "Message" + "                    " + "Priority");
                        sw.WriteLine("------------------------------------------------------------");
                        sw.WriteLine(line);
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(filePath))
                    {
                        sw.WriteLine(line);
                    }
                }
                count++;
            } while (count < 20);
            files++;
        } while (files < 5);




    }
    public static String GetTimestamp(DateTime value)
    {
        return value.ToString("dd.MM.yyyy  HH:mm:ss");
    }


}