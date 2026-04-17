using Models.Payroll;

namespace ApiConnect.Services.Payroll
{
    public class PayrollService
    {

        private readonly HttpClient _http;

        public PayrollService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<SalaryStructure>> GetAll()
        {
            //return await _http.GetFromJsonAsync<List<SalaryStructure>>("api/payroll");
            return new List<SalaryStructure>()
            {
                new() {
                    Id = 1,
                    EmployeeName = "as",
                     Allowances = 2000,
                      BasicSalary = 1000,
                       Deductions = 100,
                        EmployeeId = 1 ,
                        HRA = 100,
                },

                new SalaryStructure
                {

                    Id = 2,
                    EmployeeName = "as",
                    Allowances = 2000,
                    BasicSalary = 10000
                      ,
                    Deductions = 100,
                    EmployeeId = 1,
                    HRA = 100,

                },
                new SalaryStructure
                {
                    Id = 3,
                    EmployeeName = "as",
                    Allowances = 2000,
                    BasicSalary = 10000
                      ,
                    Deductions = 100,
                    EmployeeId = 1,
                    HRA = 100,

                }

            };
        }

        public async Task<SalaryStructure> GetById(int id)
        {
            //return await _http.GetFromJsonAsync<SalaryStructure>($"api/payroll/{id}");
            return new SalaryStructure
            {
                Id = id,
                EmployeeName = "as",
                Allowances = 2000,
                BasicSalary = 10000
                      ,
                Deductions = 100,
                EmployeeId = 1,
                HRA = 100,

            };
        }

        public async Task Add(SalaryStructure payroll)
        {
            //await _http.PostAsJsonAsync("api/payroll", payroll);
            return;
        }
    }
}


