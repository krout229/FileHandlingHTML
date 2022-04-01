using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileHandlingHTML
{
    class FileHandlingInput
    {
        public void ReadFile()
        {
            FileStream fileStream = new FileStream(@"C:\Training\mydata.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fileStream);
            int count = 0;
            while (reader.Peek() > 0)
            {
                string line = reader.ReadLine();
                if (line.Contains("input"))
                    count++;
            }
            Console.WriteLine("Count of  input " + count);
            reader.Close();
            fileStream.Close();
        }
    }
}
