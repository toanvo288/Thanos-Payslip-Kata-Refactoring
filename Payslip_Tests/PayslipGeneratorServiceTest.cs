using System;
using Payslip_App;
using Xunit;

namespace Payslip_Tests
{
    public class PayslipGeneratorServiceTest
    {
        
        [Fact]
        public void When_Employee_Is_Null_Payslip_Is_Null()
        {
            var paySlipGeneratorService = new PayslipGeneratorService();
        }
    }
}