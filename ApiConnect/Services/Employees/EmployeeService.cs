using Models.Employees;

namespace ApiConnect.Services.Employees
{
    public class EmployeeService
    {
        private readonly HttpClient _http;

        public EmployeeService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Employee>> GetAll()
        {
            //return await _http.GetFromJsonAsync<List<Employee>>("api/employee");

            return new List<Employee>() { new Employee
            {
                Name = "a",
                Email = "a@gmail.com",
                Mobile = "9876543210",
                Id =1
            },
            new Employee
            {
                Name = "B",
                Email = "b@gmail.com",
                Mobile = "9876543210",
                Id =2
            },
            new Employee
            {
                Name = "C",
                Email = "C@gmail.com",
                Mobile = "9876543210",
                Id =3
            },
            new Employee
            {
                Name = "d",
                Email = "a@gmail.com",
                Mobile = "9876543210",
                Id =4
            }};
        }

        public async Task<Employee> GetById(int id)
        {
            return new Employee
            {
                Name = "d",
                Email = "a@gmail.com",
                Mobile = "9876543210",
                Id = id
            };
            //return await _http.GetFromJsonAsync<Employee>($"api/employee/{id}");
        }

        public async Task Add(Employee emp)
        {
            //await _http.PostAsJsonAsync("api/employee", emp);
            return;
        }

        public async Task Update(Employee emp)
        {
            //await _http.PutAsJsonAsync("api/employee", emp);
            return;
        }
    }

}
