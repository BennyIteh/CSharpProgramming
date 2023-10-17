using System;

public class Arrays
{
	public Arrays()
	{
        //Arrays
        //Initailize and Assign values on different lines
        int[] EvenNumbers = new int[6];
        EvenNumbers[0] = 0;
        EvenNumbers[1] = 2;
        EvenNumbers[2] = 4;
        EvenNumbers[3] = 6;
        EvenNumbers[4] = 8;
        EvenNumbers[5] = 10;

        Console.WriteLine(EvenNumbers[4]);

        //Initailize and Assign values on same line
        int[] OddNumbers = { 1, 3, 5, 7, 9 };

        Console.WriteLine(OddNumbers[2]);
    }
}
