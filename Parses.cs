using System;

public class Parses
{
	public Parses()
	{
        //Parse and Try Parse
        //Parse
        string strNumber = "100";
        int i = int.Parse(strNumber);
        Console.WriteLine(i);

        //Try Parse
        string strNumber1 = "123";
        int Result = 0;
        bool IsConversionSuccessful = int.TryParse(strNumber1, out Result);
        if (IsConversionSuccessful)
        {
            Console.WriteLine(Result);
        }
        else
        {
            Console.WriteLine("Please enter a valid number");
        }
    }
}
