// See https://aka.ms/new-console-template for more information

using System;
using SpaceX_C_SHARP;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Samin");

        SpaceX space = new SpaceX();

        Console.WriteLine(space.Play());

    }


    
}
