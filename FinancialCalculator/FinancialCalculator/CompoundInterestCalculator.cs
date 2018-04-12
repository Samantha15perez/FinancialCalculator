using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialCalculator
{
    class CompoundInterestCalculator
    {

        public static double CompoundInterestFV(double P, double i, double n, double c, double r)
        {
            
        
            try
            {   //Each radio button changes the value of the variables needed.
                //c is how many times a year you would compound
                //R is how many months are within the period you specify for compounding. 

                double R = 0;
                

                if (c == 365)
                {
                     R = ((r * 12) / 365);

                }
                else if (c == 12)
                {
                     R = r;

                }
                else if (c == 4)
                {
                     R = (r * 3);
                }
                else if (c == 2)
                {
                     R = (r * 6);

                }
                else if (c == 1)
                {
                     R = (r * 12);

                }

                //these variables break down the formula in a way that forces C# to use the proper order of operations.

                double NxC = (n * c);
                double IdC = (i / c);
                double IdC1 = (1 + IdC);
                double EQP1 = Math.Pow(IdC1, NxC);
                double EQSide1 = (P * EQP1);
                double EQP2 = (EQP1 - 1);
                double EQP3 = (R * EQP2);
                double EQSide2 = (EQP3 / IdC);

                //these variables calculate the Future Value, Interest Earned, and Yearly Additions.
                //FV is the entire amount by the end of the time period.
                //IE is the money you've earned by interest only by the end of the time period. 
                //YA is the money you've put in the account through monthly deposit ALONE by the end of the time period. 
                double FV = (EQSide1 + EQSide2);
                double IE = ((i * P) * n);
                double YA = (r * 12);

                return FV;

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public static double CompoundInterestIE(double P, double i, double n, double c, double r)
        {


            try
            {   //Each radio button changes the value of the variables needed.
                //c is how many times a year you would compound
                //R is how many months are within the period you specify for compounding. 

                double R = 0;


                if (c == 365)
                {
                    R = ((r * 12) / 365);

                }
                else if (c == 12)
                {
                    R = r;

                }
                else if (c == 4)
                {
                    R = (r * 3);
                }
                else if (c == 2)
                {
                    R = (r * 6);

                }
                else if (c == 1)
                {
                    R = (r * 12);

                }

                //these variables break down the formula in a way that forces C# to use the proper order of operations.

                double NxC = (n * c);
                double IdC = (i / c);
                double IdC1 = (1 + IdC);
                double EQP1 = Math.Pow(IdC1, NxC);
                double EQSide1 = (P * EQP1);
                double EQP2 = (EQP1 - 1);
                double EQP3 = (R * EQP2);
                double EQSide2 = (EQP3 / IdC);

                //these variables calculate the Future Value, Interest Earned, and Yearly Additions.
                //FV is the entire amount by the end of the time period.
                //IE is the money you've earned by interest only by the end of the time period. 
                //YA is the money you've put in the account through monthly deposit ALONE by the end of the time period. 
                double FV = (EQSide1 + EQSide2);
                double IE = ((i * P) * n);
                double YA = (r * 12);

                return IE;

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public static double CompoundInterestYA(double P, double i, double n, double c, double r)
        {


            try
            {   //Each radio button changes the value of the variables needed.
                //c is how many times a year you would compound
                //R is how many months are within the period you specify for compounding. 

                double R = 0;


                if (c == 365)
                {
                    R = ((r * 12) / 365);

                }
                else if (c == 12)
                {
                    R = r;

                }
                else if (c == 4)
                {
                    R = (r * 3);
                }
                else if (c == 2)
                {
                    R = (r * 6);

                }
                else if (c == 1)
                {
                    R = (r * 12);

                }

                //these variables break down the formula in a way that forces C# to use the proper order of operations.

                double NxC = (n * c);
                double IdC = (i / c);
                double IdC1 = (1 + IdC);
                double EQP1 = Math.Pow(IdC1, NxC);
                double EQSide1 = (P * EQP1);
                double EQP2 = (EQP1 - 1);
                double EQP3 = (R * EQP2);
                double EQSide2 = (EQP3 / IdC);

                //these variables calculate the Future Value, Interest Earned, and Yearly Additions.
                //FV is the entire amount by the end of the time period.
                //IE is the money you've earned by interest only by the end of the time period. 
                //YA is the money you've put in the account through monthly deposit ALONE by the end of the time period. 
                double FV = (EQSide1 + EQSide2);
                double IE = ((i * P) * n);
                double YA = (r * 12);

                return YA;

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public static double MortgageMonthly(double Interest, double ProgramLength, double P, double DP)
        {
            try
            {

           
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

        public static double MortgageTotalPaid(double Interest, double ProgramLength, double P, double DP)
        {
            try
            {


                double n = (ProgramLength * 12); //number of payments
                double M = (P - DP);

                double R1 = (Interest + 1);
                double R1n = Math.Pow(R1, n);
                double Numerator = (Interest * R1n);
                double Denominator = (R1n - 1);
                double Fraction = (Numerator / Denominator);
                double FullEquation = (M * Fraction);


                
                double TotalPaid = (FullEquation * n);

                return TotalPaid;

                // FIX THIS USING TOTAL PRINCIPAL PAID AND TOTAL INTEREST PAID
                //bankrate.com/calculators/mortgages/mortgage-calculator.aspx#testid=10413875559_control
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public static double MortgageTotalInterest(double Interest, double ProgramLength, double P, double DP)
        {
            try
            {


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
