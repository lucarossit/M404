namespace FileIOs
{
    public class FileIO
    {

        public void WriteToFile(string filePath, string line)
        {
            if (!File.Exists(filePath))
            {
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    sw.WriteLine(line);
                }
            }
            else
            {
                AppendToFile(filePath, line);
            }
        }
        public void WriteToFile(string filePath)
        {
            Console.WriteLine("What do you want to write to the File?");
            string line = Console.ReadLine();
            if (!File.Exists(filePath))
            {
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    sw.WriteLine(line);
                }
            }
            else
            {
                AppendToFile(filePath, line);
            }
        }

        public void AppendToFile(string filePath, string line)
        {
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(line);
            }
        }

        public void ReadFile(string filePath)
        {
            using (StreamReader sr = File.OpenText(filePath))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
        public void SearchString(string filePath, string search)
        {
            string line = null;
            bool found = false;
            using (StreamReader reader = new StreamReader(filePath))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    if (String.Compare(line, search) == 0)
                    {
                        found = true;
                    }
                }
                if (found == true)
                {
                    Console.WriteLine(search + " was found in the File.");
                }
                else
                {
                    Console.WriteLine(search + " was not found in the File.");
                }
            }
        }

        public void DeleteLine(string filePathOld, string remove)
        {
            string line = null;
            FileIO temp = new FileIO();
            string filePathNew = "C:\\projects\\M404\\Data\\temp\\textTemp.txt";

            using (StreamReader reader = new StreamReader(filePathOld))
            {
                using (StreamWriter writer = new StreamWriter(filePathNew))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (String.Compare(line, remove) == 0)
                            continue;
                        writer.WriteLine(line);
                    }
                }
            }
            File.Delete(filePathOld);
            temp.moveFile(filePathNew, filePathOld);
        }

        public void DeleteLine(string filePathOld, int line)
        {
            FileIO temp = new FileIO();
            string tempLine = null;
            string filePathNew = "C:\\projects\\M404\\Data\\temp\\textTemp.txt";
            int line_number = 0;

            using (StreamReader reader = new StreamReader(filePathOld))
            {
                using (StreamWriter writer = new StreamWriter(filePathNew))
                {
                    while ((tempLine = reader.ReadLine()) != null)
                    {
                        line_number++;

                        if (line_number == line)
                            continue;

                        writer.WriteLine(tempLine);
                    }
                }
            }
            File.Delete(filePathOld);
            temp.moveFile(filePathNew, filePathOld);


        }

        public void moveFile(string filePathOld, string filePathNew)
        {
            string tempLine = null;

            using (StreamReader reader = new StreamReader(filePathOld))
            {
                using (StreamWriter writer = new StreamWriter(filePathNew))
                {
                    while ((tempLine = reader.ReadLine()) != null)
                    {
                        writer.WriteLine(tempLine);
                    }
                }
            }
            File.Delete(filePathOld);
        }

        public void GetDirectory(string path)
        {
            string[] entries = Directory.GetFileSystemEntries(path, "*", SearchOption.AllDirectories);
            using (StreamWriter sw = new StreamWriter("C:\\projects\\M404\\Data\\temp\\directory.txt"))
            {
                foreach(string a in entries)
            {
                sw.WriteLine(a);
            }
            }
            
        }
    }
}