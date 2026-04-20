using ApiConnect.Services.Attendance;
using ApiConnect.Services.Employees;
using Microsoft.AspNetCore.Mvc;
using Models.Attendance;

namespace HRMS_IT.Controllers.Attendance
{
    public class AttendanceController : Controller
    {
        private readonly AttendanceService _service;
        private readonly EmployeeService _empService;

        public AttendanceController(AttendanceService service, EmployeeService empService)
        {
            _service = service;
            _empService = empService;
        }

        // List
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }

        // Create
        public async Task<IActionResult> Create()
        {
            ViewBag.Employees = await _empService.GetAll();
            return View(new Attendances { Date = DateTime.Today });
        }

        // Save
        [HttpPost]
        public async Task<IActionResult> Create(Attendances model)
        {
            await _service.Add(model);
            return RedirectToAction("Index");
        }


    }
}
