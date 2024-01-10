using Week2_test.Model;

namespace Week2_test.Repository
{
    public class CompanyRepository : ICompany
    {
        public List<Company> companys = new List<Company>();
        public void AddCompany(Company company)
        {
            try
            {
                companys.Add(company);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteCompany(int id)
        {
            try
            {
                foreach (var item in companys)
                {
                    if (item.CompanyId == id)
                    {
                        companys.Remove(item);
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }
        }

        public List<Company> GetAllCompany()
        {
            try
            {
                return companys;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Company> GetCompanyByCity(string city)
        {
            try
            {
                List<Company> CompanyWithCity = new List<Company>();
                foreach (var item in companys)
                {
                    if (item.City == city)
                        CompanyWithCity.Add(item);
                }
                return CompanyWithCity;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Company GetCompanyById(int id)
        {
            try
            {
                foreach (var k in companys)
                {
                    if (k.CompanyId == id)
                    {
                        return k;
                    }
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
