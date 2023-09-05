using System;

public class Datatypes
{
	public Datatypes()
	{
        //Boolean Datatype
        bool B = true;

        //Integer Datatype
        int i = 0;
        Console.WriteLine("Min {0}", int.MinValue);
        Console.WriteLine("Max {0}", int.MaxValue);

        //Float/Double Datatype
        float f = 12;
        Console.WriteLine(f);

        //double d = 123.3434556;
        Console.WriteLine(d);

        //String Datatype
        string Name = "\"Benny\"";
        Console.WriteLine(Name);

        //String Datatype - Escape Sequence
        string EscapeSeqName = "One\nTwo\nThree";
        Console.WriteLine(EscapeSeqName);

        //String Datatype - Verbatim Literal
        string VerbatimLitName = @"C:\Users\Desktop\Directory";
        Console.WriteLine(VerbatimLitName);
    }
}
