﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWagePrograms
{
    class UC1
    {
   // CheckEmployeePresence
        
            public static void Main(string[] args)
            {
                int isPresent = 1;

                Random employee = new Random();
                int randomInput = employee.Next(0, 2);

                if (randomInput == isPresent)
                    Console.WriteLine("Employee is Present");
                else
                    Console.WriteLine("Employee is Absent");
                Console.ReadLine();




            }
        }
    }




