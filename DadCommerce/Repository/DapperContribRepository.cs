using Dapper.Contrib.Extensions;
using DadCommerce.Models;
using System.Data;
using Dapper;
using DadCommerce.Data;
namespace DadCommerce.Repository
{
    public class DapperContribRepository
    {
        private readonly AppDbContext _dbContext;
        private readonly DapperContext _context;

        public DapperContribRepository(AppDbContext applicationDbContext, DapperContext context)
        {
            _dbContext = applicationDbContext;
            _context = context;

        }
        public Company AddCompany(Company company)
        {
            using (var connection = _context.CreateConnection())
            {
                var id = connection.Insert(company);
                company.Id = (int)id;
                return company;
            }
        }
        public Company Find(int id)
        {
            using (var connection = _context.CreateConnection())
            {
                return connection.Get<Company>(id);
            }
        }

        public List<Company> GetAll()
        {
            using (var connection = _context.CreateConnection())
            {
                return connection.GetAll<Company>().ToList();
            }
        }

        public void Remove(int id)
        {
            using (var connection = _context.CreateConnection())
            {
                connection.Delete(new Company { Id = id });
            }
        }

        public Company Update(Company company)
        {
            using (var connection = _context.CreateConnection())
            {
                connection.Update(company);
                return company;
            }
        }
    }
}
