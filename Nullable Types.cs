using System;

public class NullableTypes
{
	public NullableTypes()
	{
        //Nullable Types
        string Name = null; //Reference Type - can be nullable
        int i = null; //Value Type - cannot be nullable

        int? j = null; //Value Type - cannot be nullable

        bool? AreYouAMajor = null;

        if (AreYouAMajor == true)
        {
            Console.WriteLine("User is a Major");
        }
        else if (AreYouAMajor == false)
        {
            Console.WriteLine("User is not a Major");
        }
        else
        {
            Console.WriteLine("User did not answer question");
        }
    }
}
