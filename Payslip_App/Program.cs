using System;

namespace Payslip_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the payslip generator!");
            var inputEmployee = GetEmployeeInfo();
            var payslipGeneratorService = new PayslipGeneratorService();
            var paySlip = payslipGeneratorService.Generate(inputEmployee);
            PrintPayslip(paySlip);
            Console.WriteLine("Thank you for using MYOB!");
        }

        private static Employee GetEmployeeInfo()
        {
            return null;
        }

        private static void PrintPayslip(Payslip payslip)
        {
            
        }
    }
}