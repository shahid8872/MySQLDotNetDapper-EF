using DadCommerce.Models;

namespace DadCommerce.IRepositorys
{
    public interface IEmpRepository
    {
        public Task<Employee> CreateEmployee(Employee employee);
        public string CreateEmployeeList(List<Employee> employee);
    }
}
