using ApiConnect.Services.Employees;
using ApiConnect.Services.Payroll;

namespace Businesslogiclayer.Pdf
{
    public class SalarySlip
    {
        private readonly PayrollService _service;
        private readonly EmployeeService _empService;

        public SalarySlip(PayrollService payrollService)
        {
            _service = payrollService;
        }
        public async Task GetSalarySlip(int id)
        {
            var payroll = await _service.GetById(id);
            if (payroll == null)
            {



            }
        }
    }
}
