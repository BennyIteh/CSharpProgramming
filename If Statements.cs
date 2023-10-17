using System;

public class IfStatements
{
	public IfStatements()
	{
        //If Statements
        Console.WriteLine("Please enter a number");

        int UserNumber = int.Parse(Console.ReadLine());

        if (UserNumber == 1)
        {
            Console.WriteLine("Your Number is one");
        }

        else if (UserNumber == 2)
        {
            Console.WriteLine("Your Number is two");
        }

        else if (UserNumber == 3)
        {
            Console.WriteLine("Your Number is three");
        }

        else
        {
            Console.WriteLine("Your Number is not between 1 and 3");
        }

        //
        if (UserNumber == 10 || UserNumber == 20)
        {
            Console.WriteLine("Your number is either 10 or 20");
        }
        else
        {
            Console.WriteLine("Your number is invalid");
        }
    }
}
