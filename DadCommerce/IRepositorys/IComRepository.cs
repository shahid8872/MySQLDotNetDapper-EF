using DadCommerce.Models;

namespace DadCommerce.IRepositorys
{
    public interface IComRepository
    {
        Company Find(int id);
        List<Company> GetAll();
        Company AddCompany(Company company);
        Company Update(Company company);
        int Remove(int id);
    }
}
