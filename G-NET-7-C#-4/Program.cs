using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace G_NET_7_C__4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01 :
            //(a)Explain why this code is inefficient.Reference what happens in memory.
            //In C#, strings are immutable. This means that every time the following line is executed:
            //productList += "PROD-" + i + ",";
            //a new string object is created in memory instead of modifying the existing one.

            //The previous string becomes unused and is later cleaned up by the Garbage Collector.
            //When this operation is repeated 5000 times, it results in:

            //Creating thousands of temporary string objects
            //Increased memory usage
            //Slower performance due to repeated allocations

            //(b)Rewrite this code using StringBuilder to be more efficient.
            //A more efficient approach is to use StringBuilder, which allows modifying the same object without creating new ones.

            //using System.Text;
            //StringBuilder productList = new StringBuilder();
            //for (int i = 1; i <= 5000; i++)
            //{
            //    productList.Append("PROD-" + i + ",");
            //}
            //string result = productList.ToString();
            //Console.WriteLine(result);

            //Advantages:
            //Better performance
            //Lower memory consumption
            //No unnecessary object creation

            //(c) Add timing code (using Stopwatch) to both versions and report the time difference.
            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            //string productList = "";
            //for (int i = 1; i <= 5000; i++)
            //{
            //    productList += "PROD-" + i + ",";
            //}
            //sw.Stop();
            //Console.WriteLine("String Time: " + sw.ElapsedMilliseconds + " ms");
            //sw.Reset();
            //sw.Start();
            //StringBuilder sb = new StringBuilder();
            //for (int i = 1; i <= 5000; i++)
            //{
            //    sb.Append("PROD-" + i + ",");
            //}
            //sw.Stop();
            //Console.WriteLine("StringBuilder Time: " + sw.ElapsedMilliseconds + " ms");
            #endregion

            #region Question 02:
            //(a)Implement using if-else if-else statements
            //Console.Write("Enter Age: ");
            //int age = int.Parse(Console.ReadLine());

            //Console.Write("Is it weekend? (yes/no): ");
            //string isWeekend = Console.ReadLine().ToLower();

            //Console.Write("Do you have a student ID? (yes/no): ");
            //string isStudent = Console.ReadLine().ToLower();

            //double price = 0;

            //// Base price
            //if (age < 5)
            //    price = 0;
            //else if (age <= 12)
            //    price = 30;
            //else if (age <= 60)
            //    price = 50;
            //else
            //    price = 25;

            //// Weekend addition
            //if (isWeekend == "yes" && price > 0)
            //    price += 10;

            //// Student discount
            //if (isStudent == "yes" && age <= 60)
            //    price *= 0.8;

            //Console.WriteLine("Final Ticket Price: " + price + " LE");

            //(b)The program should ask for: age, day of week(1 - 7, where 6 = Fri, 7 = Sat), and whether they have a student ID(yes / no)
            //double price = age switch
            //{
            //    < 5 => 0,
            //    <= 12 => 30,
            //    <= 60 => 50,
            //    _ => 25
            //};

            //(c) Display the final price with a breakdown of how it was calculated
            //Console.WriteLine($"Base Price: {price} LE");

            //if (isWeekend == "yes" && price > 0)
            //    Console.WriteLine("Weekend Extra: +10 LE");

            //if (isStudent == "yes" && age <= 60)
            //    Console.WriteLine("Student Discount: 20% off");

            //Console.WriteLine($"Final Price: {price} LE");

            #endregion

            #region Question 03:
            //(a)A traditional switch statement
            //string fileExtension = ".pdf";
            //string fileType;

            //switch (fileExtension)
            //{
            //    case ".pdf":
            //        fileType = "PDF Document";
            //        break;

            //    case ".doc":
            //    case ".docx":
            //        fileType = "Word Document";
            //        break;

            //    case ".xls":
            //    case ".xlsx":
            //        fileType = "Excel Spreadsheet";
            //        break;

            //    case ".jpg":
            //    case ".png":
            //    case ".gif":
            //        fileType = "Image File";
            //        break;

            //    default:
            //        fileType = "Unknown File Type";
            //        break;
            //}

            //(b) A switch expression 
            //string fileType = fileExtension switch
            //{
            //    ".pdf" => "PDF Document",
            //    ".doc" or ".docx" => "Word Document",
            //    ".xls" or ".xlsx" => "Excel Spreadsheet",
            //    ".jpg" or ".png" or ".gif" => "Image File",
            //     => "Unknown File Type"
            //};
            #endregion

            #region Question 04:
            //Is the ternary version more readable? When would you choose one over the other?
            //int temperature = 35;

            //string weatherAdvice =
            //    temperature < 0 ? "Freezing! Stay indoors." :
            //    temperature < 15 ? "Wear a jacket." :
            //    temperature < 25 ? "Pleasant weather." :
            //    temperature < 35 ? "Warm. Stay hydrated." :
            //    "Hot! Avoid sun exposure.";

            //Console.WriteLine(weatherAdvice);
            #endregion

            #region Question 05:

            //int attempts = 0;
            //bool isValid = false;

            //do
            //{
            //    Console.Write("Enter password: ");
            //    string password = Console.ReadLine();

            //    bool hasUpper = false;
            //    bool hasDigit = false;
            //    bool hasSpace = false;

            //    // Check each character using foreach
            //    foreach (char c in password)
            //    {
            //        if (char.IsUpper(c))
            //            hasUpper = true;

            //        if (char.IsDigit(c))
            //            hasDigit = true;

            //        if (char.IsWhiteSpace(c))
            //            hasSpace = true;
            //    }

            //    // Validation flags
            //    bool lengthValid = password.Length >= 8;

            //    if (lengthValid && hasUpper && hasDigit && !hasSpace)
            //    {
            //        isValid = true;
            //        Console.WriteLine("Password accepted!");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid password. Issues:");

            //        if (!lengthValid)
            //            Console.WriteLine("- Must be at least 8 characters");

            //        if (!hasUpper)
            //            Console.WriteLine("- Must contain at least one uppercase letter");

            //        if (!hasDigit)
            //            Console.WriteLine("- Must contain at least one digit");

            //        if (hasSpace)
            //            Console.WriteLine("- Must not contain spaces");
            //    }

            //    attempts++;

            //} while (attempts < 5);

            //if (!isValid)
            //{
            //    Console.WriteLine("Account locked");
            //}

            #endregion
        }
    }
}
