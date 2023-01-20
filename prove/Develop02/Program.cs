using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal1 = new Journal();
       

        Console.Write (mainmenu);
        Console.Write ("what is your name? ");
        string name = Console.ReadLine();

        Console.Write ("What is your entry?  ");
        string entry = Console.ReadLine();

       Console.Write(string.Format("{0}, {1}", name, entry));


     //   Console.Write(name);
      //  Console.Write(entry);
    
    }
}