using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    public class Program
    {
        public void WriteOnFile(String fileName, String text)
        {
            File.WriteAllText(fileName, text);
        }
        public void AppendFile(String fileName, String text)
        {
            using (StreamWriter sw = File.AppendText(fileName))
            {
                sw.WriteLine(text);
            }
        }
        public string[] ReadFile(String fileName)
        {
            string[] lines = System.IO.File.ReadAllLines(fileName);
            Console.WriteLine(lines);
            return lines;
        }

        public static void Main(string[] args)
        {
            Program programObj = new Program();

            Console.WriteLine("1.Write on file");
            Console.WriteLine("2.Append file");
            Console.WriteLine("3.Read file");
            Console.WriteLine("Enter your choice:");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {	 	  	  		    	 	     	      	 	
                case 1:
                    {
                        Console.WriteLine("Enter the filename");
                        String fileName = Console.ReadLine();

                        Console.WriteLine("Enter the text to write");
                        String text = Console.ReadLine();

                        programObj.WriteOnFile(fileName, text);
                        
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter the file name");
                        String fileName = Console.ReadLine();

                        Console.WriteLine("Enter the text to append");
                        String text = Console.ReadLine();

                        programObj.AppendFile(fileName, text);
                        
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Enter the file to read");
                        String fileName = Console.ReadLine();

                        String[] result = programObj.ReadFile(fileName);
                        for (int i = 0; i < result.Length; i++)
                        {
                            Console.WriteLine(result[i]);
                        }
                        break;
                    }	 	  	  		    	 	     	      	 	
            }
        }
    }
}
