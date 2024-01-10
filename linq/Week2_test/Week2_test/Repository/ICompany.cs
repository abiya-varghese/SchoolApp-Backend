using Week2_test.Model;

namespace Week2_test.Repository
{
    public interface ICompany
    {
        public void AddCompany(Company company);
        List<Company> GetAllCompany();
        Company GetCompanyById(int id);
        List<Company> GetCompanyByCity(string city);
        void DeleteCompany(int id);
    }
}
