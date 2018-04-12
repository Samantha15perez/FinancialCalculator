using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortgageCalculator
{
    class MortgageCalculator
    {
        public static double MortgageMonthlyPayment(double Interest, double ProgramLength, double P, bool Percent, double DP)
        {
            try
            {
                

                if (Percent == true)
                {
                     DP = (DP / 100) * P;
                }
                else if (Percent == false)
                {
                   //DP is equal to its face value
                }




                double n = (ProgramLength * 12); //number of payments
                double M = (P - DP);

                double R1 = (Interest + 1);
                double R1n = Math.Pow(R1, n);
                double Numerator = (Interest * R1n);
                double Denominator = (R1n - 1);
                double Fraction = (Numerator / Denominator);
                double FullEquation = (M * Fraction);

                return FullEquation;
                
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

    }
}
