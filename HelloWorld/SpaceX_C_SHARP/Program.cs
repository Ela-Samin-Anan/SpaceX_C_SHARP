// See https://aka.ms/new-console-template for more information



/* Reference of .Net Framework*/
using System;
using SpaceX_C_SHARP;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

class Program
{   //Method name -> Main
    // Datatype
    static void Main(string[] args)
    {
        Console.WriteLine("Hello I am Samin");

        //Datatype String, Variable name ->bride , Value of Variable -> "Hello, I am Ela"
        string bride = "Hello I am Ela";

        SpaceX space = new SpaceX();

        Console.WriteLine(space.Play());
        //Method to display value on Console->WriteLine
        Console.WriteLine(bride);


    }


    
}
