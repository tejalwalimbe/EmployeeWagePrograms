﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWagePrograms
{
    //Compute Employee Wage for Multiple Company in Procedural way using class methods
    class UC8
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
       
      public static int computeEmpWage(string company,int empRatePerHour,int numOfWorkingDays,int maxHoursPerMonth)
        { 
            //variables
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            //Computation
           while(totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)

            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;

                Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs : " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp Wage for company : " + company + " is:" + totalEmpWage);
            return totalEmpWage;
        }
        static void Main(string[]args)
        {
            computeEmpWage("DMART",20,2,10);
            computeEmpWage("Reliance", 20, 2, 10);
        }
    }

}

