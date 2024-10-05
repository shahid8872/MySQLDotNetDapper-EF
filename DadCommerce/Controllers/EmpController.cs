using DadCommerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DadCommerce.IRepositorys;
using DadCommerce.DTOs;
namespace DadCommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpController : ControllerBase
    {
        private readonly IEmpRepository _employeeRepo;
        public EmpController(IEmpRepository employeeRep)
        {
            _employeeRepo = employeeRep;
        }

        [HttpPost]
        public string CreateCompanyList(List<Employee> employee)
        {

            try
            {
                return _employeeRepo.CreateEmployeeList(employee);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
