using Day_4_Assignment.UC10;
using Day_4_Assignment.UC9;
using Day_4_Assignment.UCLast_FinalSolution;
using System;

namespace Day_4_Assignment
{
    class Program
    {
        static int abc;
        static void Main(string[] args)
        {
            //UC1_EmployeeAttendance.GetAttendance();
            //UC2_EmpWage.EmpWage();
            //UC3_PartTimeEmpWage.PartTimeEmpWage();
            //UC4_EmpWageUsingSwitch.EmpWageUsingSwitch();
            //UC5_CalculateWageFor20DaysinMonth.CalculateWagesFor20DaysInMonth();
            //UC6_CalculateWageTill100HrsOr20IsReached.CalculateWageTill100HrsOr20IsReached();

            UC7_ComputeEmpWageUsingClassMethod.ComputeEmpWage();
            abc = UC8_ComputeEmpWageForMultipleCompanies.ComputeEmpWage("d-mart", 20, 10, 20);
            Console.WriteLine(abc);
            Console.ReadKey();

            #region UC9
            EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 20, 2, 10);
            EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 10, 4, 20);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.toString());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.toString());
            #endregion UC9

            #region UC10
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.computeEmpWage();
            #endregion

            #region FinalSolution
            EmpWageBuilder empWageBuild = new EmpWageBuilder();
            empWageBuild.addCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuild.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuild.computeEmpWage();
            #endregion
        }
    }
}
