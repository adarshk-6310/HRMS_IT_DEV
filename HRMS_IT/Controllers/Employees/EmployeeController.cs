using ApiConnect.Services.Employees;
using Microsoft.AspNetCore.Mvc;
using Models.Employees;

namespace HRMS_IT.Controllers.Employees
{
    public class EmployeeController : Controller
    {
        // View List
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }

        private readonly EmployeeService _service;

        public EmployeeController(EmployeeService service)
        {
            _service = service;
        }

        //// View List
        //public async Task<IActionResult> Index()
        //{
        //    var data = await _service.GetAll();
        //    return View(data);
        //}

        // Add / Edit Page
        public async Task<IActionResult> Create(int? id)
        {
            if (id == null)
                return View(new Employee());

            var emp = await _service.GetById(id.Value);
            return View(emp);
        }

        // Save
        [HttpPost]
        public async Task<IActionResult> Create(Employee emp)
        {
            if (emp.Id == 0)
                await _service.Add(emp);
            else
                await _service.Update(emp);

            return RedirectToAction("Index");
        }

    }
}
