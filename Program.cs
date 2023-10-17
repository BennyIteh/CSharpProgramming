using OfficeOpenXml;
using System;
using System.Drawing;
using System.Security.Principal;
using PATA = ProjectA.TeamA;
using PATB = ProjectA.TeamB;


class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to C# Training");
        PATA.ClassA.Print();
        PATB.ClassA.Print();
    }
}

namespace ProjectA
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team A Print Method");
            }
        }
      
    }
}

namespace ProjectA
{
    namespace TeamB
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team B Print Method");
            }
        }
      
    }
}
    
