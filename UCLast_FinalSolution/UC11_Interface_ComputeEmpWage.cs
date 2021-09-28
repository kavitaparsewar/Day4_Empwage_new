using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4_Assignment.UCLast_FinalSolution
{
    public interface UC11_Interface_ComputeEmpWage
    {
        void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMnth);
        void computeEmpWage();

        int getTotalWage(string company);
    }
}
