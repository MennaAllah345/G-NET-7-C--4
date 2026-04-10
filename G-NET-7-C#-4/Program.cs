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

            #region 
            #endregion
        }
    }
}
