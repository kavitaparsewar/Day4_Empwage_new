using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4_Assignment.UCLast_FinalSolution
{
    
        public class UC14_EmpWageBuilder : UC11_Interface_ComputeEmpWage
        {
            public const int IS_PART_TIME = 1;
            public const int IS_FULL_TIME = 2;

            private LinkedList<UC13_CompanyEmpWage> companyEmpWagesList;
            private Dictionary<string, UC13_CompanyEmpWage> companyToEmpWageMap;

            public UC14_EmpWageBuilder()
            {
                this.companyEmpWagesList = new LinkedList<UC13_CompanyEmpWage>();
                this.companyToEmpWageMap = new Dictionary<string, UC13_CompanyEmpWage>();
            }
            public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMnth)
            {
                UC13_CompanyEmpWage companyEmpWage = new UC13_CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMnth);
                this.companyEmpWagesList.AddLast(companyEmpWage);
                this.companyToEmpWageMap.Add(company, companyEmpWage);
            }

            public void computeEmpWage()
            {
                foreach (var companyEmpWage in this.companyEmpWagesList)
                {
                    companyEmpWage.setTotalEmpWage(this.computeEmpWage(companyEmpWage));
                    Console.WriteLine(companyEmpWage.toString());
                }
            }

            private int computeEmpWage(UC13_CompanyEmpWage companyEmpWage)
            {
                //variables
                int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

                //computation
                while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
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
                    Console.WriteLine("Days#: " + totalWorkingDays + " Emp Hrs : " + empHrs);

                }
                return totalEmpHrs * companyEmpWage.empRatePerHour;
            }

            public int getTotalWage(string company)
            {
                return this.companyToEmpWageMap[company].totalEmpWage;
            }
        }


    }

