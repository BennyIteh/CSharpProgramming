using System;

public class Operators
{
	public Operators()
	{
        //Operators - Assignment
        int i = 0;
        bool b = false;

        //Operators - Arithmetic
        int Numerator = 10;
        int Denominator = 2;

        int Result = Numerator / Denominator;
        Console.WriteLine("Result = {0}", Result);

        //Operators - Comparison
        int i = 10;

        if (i == 10)//Not equals to - !=, >, >=, <=
        {
            Console.WriteLine("This is ok");
        }

        //Operators - Conditional
        int Number = 10;
        int AnotherNumber = 20;

        if (Number == 10 && AnotherNumber == 20)// And - &&, Or - ||
        {
            Console.WriteLine("Hello World");
        }

        //Operators - Tenary 
        int Number = 15;
        bool IsNumber10 = Number == 10 ? true : false;

        bool IsNumber10;

        if (Number == 10)
        {
            IsNumber10 = true;
        }
        else
        {
            IsNumber10 = false;
        }

        Console.WriteLine("Number == 10 is {0}", IsNumber10);

        //Operator - Null Coalescing
        //Instead of this...
        int? TicketsOnSale = 26;

        int AvailableTickets;

        if (TicketsOnSale == null)
        {
            AvailableTickets = 0;
        }
        else
        {
            AvailableTickets = TicketsOnSale.Value;
        }

        //... try this
        int? TicketsOnSale = null;

        int AvailableTickets = TicketsOnSale ?? 0;

        Console.WriteLine("Available Tickets = {0}", AvailableTickets);
    }
}
