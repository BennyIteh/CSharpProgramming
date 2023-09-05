using OfficeOpenXml;
using System;
using System.Drawing;
using System.Security.Principal;
using Excel = Microsoft.Office.Interop.Excel;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to C# Training");

        //Static Method
        //Program.Samples();

        ////Instance Method
        //Program p = new Program();
        //p.EvenNumber();

        ////
        //int Sum = Add(10,20);

        //Console.WriteLine("Sum = {0}", Sum);

        //int i = 0;
        //SimpleMethod(ref i);

        //Console.WriteLine(i);

        //int Total = 0;
        //int Product = 0;
        //Calculate(10, 20, out Total, out Product);

        //Console.WriteLine("Sum = {0} && Product = {1}", Total, Product);

        ParamsMethod(1,2,3,4,5,6);

        //ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        //using (ExcelPackage excelPackage = new ExcelPackage())
        //{
        //    // Add a worksheet to the package
        //    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

        //    // Add data to cells
        //    worksheet.Cells["A1"].Value = "Hello";
        //    worksheet.Cells["B1"].Value = "World";

        //    // Save the Excel package to a file
        //    FileInfo excelFile = new FileInfo("C:\\Users\\BIteh\\Documents\\TestProfile.xlsx");
        //    excelPackage.SaveAs(excelFile);

        //    Console.WriteLine("Excel file created successfully.");
        //}
    }
    //static void Samples()
    //{


        //Parse and Try Parse
        //Parse
        //string strNumber = "100";
        //int i = int.Parse(strNumber);
        //Console.WriteLine(i);

        //Try Parse
        //string strNumber1 = "123";
        //int Result = 0;
        //bool IsConversionSuccessful = int.TryParse(strNumber1, out Result);
        //if (IsConversionSuccessful)
        //{
        //    Console.WriteLine(Result);
        //}
        //else
        //{
        //    Console.WriteLine("Please enter a valid number");
        //}

        //Arrays
        //Initailize and Assign values on different lines
        //int[] EvenNumbers = new int[6];
        //EvenNumbers[0] = 0;
        //EvenNumbers[1] = 2;
        //EvenNumbers[2] = 4;
        //EvenNumbers[3] = 6;
        //EvenNumbers[4] = 8;
        //EvenNumbers[5] = 10;

        //Console.WriteLine(EvenNumbers[4]);

        //Initailize and Assign values on same line
        //int[] OddNumbers = { 1, 3, 5, 7, 9 };

        //Console.WriteLine(OddNumbers[2]);


        //Comments
        // - Single Line
        /* 
         Multi 
        Line
        */

        //If Statements
        //Console.WriteLine("Please enter a number");

        //int UserNumber = int.Parse(Console.ReadLine());

        //if (UserNumber == 1)
        //{
        //    Console.WriteLine("Your Number is one");
        //}

        //else if (UserNumber == 2)
        //{
        //    Console.WriteLine("Your Number is two");
        //}

        //else if (UserNumber == 3)
        //{
        //    Console.WriteLine("Your Number is three");
        //}

        //else
        //{
        //    Console.WriteLine("Your Number is not between 1 and 3");
        //}

        //if (UserNumber == 10 || UserNumber == 20)
        //{
        //    Console.WriteLine("Your number is either 10 or 20");
        //}
        //else
        //{
        //    Console.WriteLine("Your number is invalid");
        //}

        //Switch Statements
        //switch (UserNumber)
        //{
        //    case 10: Console.WriteLine("Your number is 10");
        //        break;
        //    case 20: Console.WriteLine("Your number is 20");
        //        break;
        //    case 30: Console.WriteLine("Your number is 30");
        //        break;
        //    default: Console.WriteLine("Your number is not 10, 20 or 30");
        //        break;
        //}

        //Joining multiple switch case statements
        //switch (UserNumber)
        //{
        //    case 10:
        //    case 20:                
        //    case 30:
        //        Console.WriteLine("Your number is {0}", UserNumber);
        //        break;
        //    default:
        //        Console.WriteLine("Your number is not 10, 20 or 30");
        //        break;
        //}

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



        //Loops

        //While Loop
        //Console.WriteLine("Please enter your target number?");
        //int UserTarget = int.Parse(Console.ReadLine());

        //int Start = 0;

        //while(Start <= UserTarget)
        //{
        //    Console.Write(Start + " ");
        //    Start = Start + 2;
        //}

        //Do While Loop
        //int TotalCoffeeCost = 0;
        //string UserDecision = string.Empty;

        //do
        //{
        //    int UserChoice = -1;
        //    do
        //    {
        //        Console.WriteLine("Please Select your Coffee size: 1 - Small, 2 - Medium, 3 - Large");
        //        UserChoice = int.Parse(Console.ReadLine());

        //        switch (UserChoice)
        //        {
        //            case 1:
        //                TotalCoffeeCost += 1;
        //                break;
        //            case 2:
        //                TotalCoffeeCost += 2;
        //                break;
        //            case 3:
        //                TotalCoffeeCost += 3;
        //                break;
        //            default:
        //                Console.WriteLine("Your choice {0} is invalid", UserChoice);
        //                break;
        //        }
        //    } while (UserChoice != 1 && UserChoice != 2 && UserChoice != 3);

        //    do
        //    {
        //        Console.WriteLine("Do you want to continue - Yes or No?");
        //        UserDecision = Console.ReadLine().ToUpper();

        //        if (UserDecision != "YES" && UserDecision != "NO")
        //        {
        //            Console.WriteLine("Your choice {0} is invalid. Please try again...", UserDecision);
        //        }
        //    } while (UserDecision != "YES" && UserDecision != "NO");
        //} while (UserDecision == "YES");

        //Console.WriteLine("Thank you for Shopping with us");
        //Console.WriteLine("Bill Amount = {0}", TotalCoffeeCost);

        //For and Foreach Loops
        //int[] Numbers = new int[3];

        //Numbers[0] = 101;
        //Numbers[1] = 102;
        //Numbers[2] = 103;

        //while loop
        //int i = 0;
        //while (i < Numbers.Length)
        //{
        //    Console.WriteLine(Numbers[i]);
        //    i++;
        //}

        ////For Loop
        //for (int j = 0; j < Numbers.Length; j++)
        //{
        //    Console.WriteLine(Numbers[j]);
        //}

        ////Foreach Loop
        //foreach(int k in Numbers)
        //{
        //    Console.WriteLine(k);
        //}

        //for (int i = 0; i <= 20; i++)
        //{
        //    //if (i == 10)
        //    //    break;
        //    if (i % 2 == 1)
        //    continue;

        //    Console.WriteLine(i);
        //}
    //}

    //Instance Method
    //public void EvenNumber()
    //{
    //    int Start = 0;

    //    while(Start <= 30)
    //    {
    //        Console.WriteLine(Start);
    //        Start = Start + 2;
    //    }
    //}

    ////Static Method
    //public static int Add(int FN, int SN)
    //{
    //    return FN + SN;
    //}

    //public static void SimpleMethod(ref int j)
    //{
    //    j = 101;
    //}

    //Parameters
    //Output Paramaters
    //public static void Calculate(int FN, int SN, out int Sum, out int Product)
    //{
    //    Sum = FN + SN;
    //    Product = FN * SN;
    //}

    //Parameter Arrays
    //public static void ParamsMethod(params int[] Numbers)
    //{
    //    Console.WriteLine("There are {0} elements", Numbers.Length);

    //    foreach (int i in Numbers)
    //    {
    //        Console.WriteLine(i);
    //    }
    //}

    /// <summary>
    /// This is a sample class and a sample documentation
    /// </summary>
    //public class SampleClass
    //{

    //}
}
    
