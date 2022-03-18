using System;

namespace Payslip_App
{
    public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public string Fullname => $"{Name} {Surname}";
        
        public decimal AnnualSalary { get; set; }
        
        public DateTime PaymentStartDate { get; set; }
        
        public DateTime PaymentEndDate { get; set; }
        
        public decimal SuperRate { get; set; }
    }
}