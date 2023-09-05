using System;

public class Syntaxes
{
	public Syntaxes()
	{
        Console.WriteLine("Please enter your first name: ");
        string FirstName = Console.ReadLine();

        Console.WriteLine("Please enter your last name: ");
        string LastName = Console.ReadLine();

        //Placeholder Syntax
        Console.WriteLine("Hello {0} {1}", FirstName, LastName);
    }
}
