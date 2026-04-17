using ApiConnect.Services.Employees;
using ApiConnect.Services.Payroll;
using Microsoft.AspNetCore.Mvc;
using Models.Payroll;

namespace HRMS_IT.Controllers.Payroll
{
    //[Authorize]
    public class PayrollController : Controller
    {
        private readonly PayrollService _service;
        private readonly EmployeeService _empService;

        public PayrollController(PayrollService service, EmployeeService empService)
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
            return View(new SalaryStructure());
        }

        // Save
        [HttpPost]
        public async Task<IActionResult> Create(SalaryStructure model)
        {
            // Auto Calculation
            model.NetSalary = model.BasicSalary + model.HRA + model.Allowances - model.Deductions;

            await _service.Add(model);

            return RedirectToAction("Index");
        }

        //public async Task<IActionResult> DownloadSlip(int id)
        //{
        //    var data = await _service.GetById(id);

        //    //return new ViewAsPdf("SalarySlip", data)
        //    //{
        //    //    FileName = "SalarySlip.pdf"
        //    //};
        //}


    }
}
