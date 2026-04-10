using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            #endregion
        }
    }
}
