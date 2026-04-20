using Models.Attendance;

namespace ApiConnect.Services.Attendance
{
    public class AttendanceService
    {
        private readonly HttpClient _http;

        public AttendanceService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Attendances>> GetAll()
        {
            //return await _http.GetFromJsonAsync<List<Attendances>>("api/attendance");
            var a = new List<Attendances>
            {
                new Attendances
                {
                    Id = 1,  EmployeeId = 2,  EmployeeName = "ABC",
                                       Remarks = "abc",     Status = "Present",   Date = DateTime.Now,
                                   },     new Attendances
                                   {   Id = 1,       EmployeeId = 2,      EmployeeName = "ABC",
                                       Remarks = "abc",      Status = "Present",     Date = DateTime.Now,
                                   },  new Attendances      {    Id = 1,   EmployeeId = 2,
                                       EmployeeName = "ABC",     Remarks = "abc",   Status = "Present",
                                       Date = DateTime.Now,
                                   }};
            return a;
        }

        public async Task Add(Attendances model)
        {
            //await _http.PostAsJsonAsync("api/attendance", model);
            return;
        }

    }
}
