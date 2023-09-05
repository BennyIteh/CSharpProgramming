using System;

public class SwitchStatements
{
	public SwitchStatements()
	{
        //Switch Statements
        switch (UserNumber)
        {
            case 10:
                Console.WriteLine("Your number is 10");
                break;
            case 20:
                Console.WriteLine("Your number is 20");
                break;
            case 30:
                Console.WriteLine("Your number is 30");
                break;
            default:
                Console.WriteLine("Your number is not 10, 20 or 30");
                break;
        }

        //Joining multiple switch case statements
        switch (UserNumber)
        {
            case 10:
            case 20:
            case 30:
                Console.WriteLine("Your number is {0}", UserNumber);
                break;
            default:
                Console.WriteLine("Your number is not 10, 20 or 30");
                break;
        }

        //Switch Statements with GoTo
        //int TotalCoffeeCost = 0;

        //Start:
        //Console.WriteLine("Please Select your Coffee size: 1 - Small, 2 - Medium, 3 - Large");
        //int UserChoice = int.Parse(Console.ReadLine());

        //switch (UserChoice)
        //{
        //    case 1:
        //        TotalCoffeeCost += 1;
        //        break;
        //    case 2:
        //        TotalCoffeeCost += 2;
        //        break;
        //    case 3:
        //        TotalCoffeeCost += 3;
        //        break;
        //    default:
        //        Console.WriteLine("Your choice {0} is invalid");
        //        goto Start;
        //}

        //Decide:
        //Console.WriteLine("Do you want to buy another coffee - Yes or No?");
        //string UserDecision = Console.ReadLine();

        //switch (UserDecision.ToUpper())
        //{
        //    case "YES":
        //        goto Start;
        //    case "NO":
        //        break;
        //    default :
        //        Console.WriteLine("Your choice is invalid. Please try again...", UserDecision);
        //        goto Decide;
        //}

        //Console.WriteLine("Thank you for Shopping with us");
        //Console.WriteLine("Bill Amount = {0}", TotalCoffeeCost);
    }
}
