using Microsoft.AspNetCore.Mvc;
using PrimeiraAPI.Model;
using PrimeiraAPI.ViewModel;
using System;

namespace PrimeiraAPI.Controllers
{
    [ApiController]
    [Route("api/v1/employee")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository ?? throw new ArgumentNullException(nameof(employeeRepository));
        }

        [HttpPost]
        public IActionResult Add([FromForm] EmployeeViewModel employeeView)

        {
            var filePath = Path.Combine("storage", employeeView.Photo.FileName);

            var employee = new Employee(employeeView.Name, employeeView.Age, filePath);

            using Stream fileStream = new FileStream(filePath, FileMode.Create);
            employeeView.Photo.CopyTo(fileStream);

            _employeeRepository.Add(employee);

            return Ok();
        }

        [HttpPost]
        [Route("{id}/download")]

        public IActionResult DonwloadPhoto(int id)
        {
            var employee = _employeeRepository.Get(id);

            var dataBytes = System.IO.File.ReadAllBytes(employee.photo);

            return File(dataBytes, "image/png");
        }

        [HttpGet]
        public IActionResult Get()
        {
            var employees = _employeeRepository.Get();
            return Ok(employees);
        }
    }
}
