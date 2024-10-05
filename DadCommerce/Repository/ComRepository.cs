using DadCommerce.Models;
using DadCommerce.IRepositorys;
using DadCommerce.Data;
using Dapper;
using DadCommerce.DTOs;
namespace DadCommerce.Repository
{
    public class ComRepository : IComRepository
    {
        private readonly AppDbContext _dbContext;
        public ComRepository(AppDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }
        public Company AddCompany(Company company)
        {
            _dbContext.Companies.Add(company);
            _dbContext.SaveChanges();
            return company;
        }

        public Company Find(int id)
        {
            return _dbContext.Companies.FirstOrDefault(f => f.Id == id);
        }

        public List<Company> GetAll()
        {
            return _dbContext.Companies.ToList();
        }

        public int Remove(int id)
        {
            Company company = _dbContext.Companies.FirstOrDefault(f => f.Id == id);
            _dbContext.Companies.Remove(company);
            _dbContext.SaveChanges();
            return id;
        }

        public Company Update(Company company)
        {
            _dbContext.Companies.Update(company);
            _dbContext.SaveChanges();
            return company;
        }
    }
}
