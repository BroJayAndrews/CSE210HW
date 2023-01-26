using System;
using System.IO;
using System.Text;
using System;  
using System.Collections.Generic;  
using System.ComponentModel;  
using System.Data;  
using System.Drawing;  
using System.Linq;  
using System.Threading.Tasks;  

class Journal
{
    string filePath = "c:\\temp\\csvtet.csv";

    public void writeToCSV()
    {
    StringBuilder builder = new StringBuilder();

    string text1 = "text1";
    string text2 = "text2";
    builder.AppendLine(string.Format("{0}|{1}", text1, text2));

    File.WriteAllText(filePath, builder.ToString());
    }

    public void readFromCSV()
    {
        StreamReader StreamReader = new StreamReader(filePath);

        while (!StreamReader.EndOfStream);
        {

            var line = StreamReader.ReadLine();
            var values = line.Split();

            Console.WriteLine("{0}", values[0]);
        }
    }
}   
namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an optionj:");
            Console.WriteLine("1) Add Entry");
            Console.WriteLine("2) Display Entry");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nSelect an option: ");
 
            switch (Console.ReadLine())
            {
                case "1":
                    ReverseString();
                    return true;
                case "2":
                    RemoveWhitespace();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }
 
        private static string CaptureInput()
        {
            Console.Write("Enter the string you want to modify: ");
            return Console.ReadLine();
        }
 
        private static void ReverseString()
        {
            Console.Clear();
            Console.WriteLine("Reverse String");
 
            char[] charArray = CaptureInput().ToCharArray();
            Array.Reverse(charArray);
            DisplayResult(String.Concat(charArray));
        }
 
        private static void RemoveWhitespace()
        {
            Console.Clear();
            Console.WriteLine("Remove Whitespace");
 
            DisplayResult(CaptureInput().Replace(" ", ""));
        }
 
        private static void DisplayResult(string message)
        {
            Console.WriteLine($"\r\nYour modified string is: {message}");
            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();
        }
    }
}

