using System;

public class Conversions
{
	public Conversions()
	{
        //Implicit and Explicit Conversion
        //Implicit - done by the compiler when there would be no loss of data
        int i = 100;
        float f = i;
        Console.WriteLine(f);

        //Explicit - done by using type cast operator or convert class when there would be loss of data
        //Does not throw an exception if the value of the float variable is larger than the int variable
        //type cast operator
        float g = 123.45F;
        int h = (int)g;
        Console.WriteLine(h);

        //Throws an exception if the value of the float variable is larger than the int variable
        //convert class
        float g = 123.45F;
        int h = Convert.ToInt32(g);
        Console.WriteLine(h);
    }
}
