﻿
using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = null;
            DateTime date2 = date ?? DateTime.Today;  // what this means is date is
                                                      //null then use DateTime.Today

            DateTime date3 = (date != null) ? date.GetValueOrDefault() : DateTime.Today;
                                                     // here GetValuerDefault() is used as date
                                                     //is nullable and date3 is not nullable
                                                     


            Console.WriteLine(date2);



        } 
    }
}


//  ?? Null Colaesing Operator

//Null Conditional Operator  ?