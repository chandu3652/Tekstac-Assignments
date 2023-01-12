using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO //DO NOT change the namespace name
{
    public class Program //DO NOT change the class name
    {
        public void AppendFile(String fileName, String text)
        {
            using (StreamWriter sw = File.AppendText(fileName))
            {
                sw.WriteLine(text);
            }
        }
        
        public static void Main(string[] args)  //DO NOT change the method signature
        {
            //Implement your code here
             Program programObj = new Program();
             Console.WriteLine("Enter the file name");
             String fileName = Console.ReadLine();

             Console.WriteLine("Enter the text to append");
             String text = Console.ReadLine();

             programObj.AppendFile(fileName, text);
                       
        }
    }
}
	 	  	  		    	  	   	    	 	
