using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Week2_test.Model;
using Week2_test.Repository;

namespace Week2_test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompany companyRepository;
        private readonly IStudent studentRepository;
        public CompanyController(ICompany companyRepository,IStudent studentRepository)
        {
            this.companyRepository = companyRepository;
            this.studentRepository = studentRepository;
        }
        //for Company
       
        [HttpGet, Route("GetAllCompany")]
        public IActionResult GetAll()
        {
            try
            {
                List<Company> companys = companyRepository.GetAllCompany();
                return StatusCode(200, companys);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpGet, Route("GetCompanybyCity/{cit}")]
        public IActionResult GetCompanyCCity(string cit)
        {
            try
            {
                return StatusCode(200, companyRepository.GetCompanyByCity(cit));
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }

        [HttpPost, Route("AddCompany")]
        public IActionResult Add(Company company)
        {
            try
            {
                companyRepository.AddCompany(company);
                return StatusCode(200, company);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpDelete, Route("DeleteCompany")]
        public IActionResult Delete(int id)
        {
            try
            {
                companyRepository.DeleteCompany(id);
                return StatusCode(200, "deleted");
            }catch (Exception ex)
            {
                return StatusCode(501, ex);

            }
        }
        [HttpGet, Route("GetCompanyById/{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                Company company = companyRepository.GetCompanyById(id);
                if (company != null)
                {
                    return StatusCode(200, company);
                }
                else
                {
                    return StatusCode(404, new JsonResult("Invalid Company Id"));
                }
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        //For Student
        [HttpPost, Route("AddStudent")]
        public IActionResult AddS(Student student)
        {
            try
            {
                studentRepository.AddStudents(student);
                return StatusCode(200, student);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpGet, Route("GetStudentbyQualification/{qua}")]
        public IActionResult GetQualifi(string qua)
        {
            try
            {
                return StatusCode(200, studentRepository.GetStudentByQualification(qua));
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpGet, Route("GetStudentbySkill/{skill}")]
        public IActionResult GetSkill(string skill)
        {
            try
            {
                return StatusCode(200, studentRepository.GetStudentBySkill(skill));
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpGet, Route("GetStudentById/{id}")]
        public IActionResult GetStudntId(int id)
        {
            try
            {
                Student student = studentRepository.GetStudentById(id);
                if (student != null)
                {
                    return StatusCode(200, student);
                }
                else
                {
                    return StatusCode(404, new JsonResult("Invalid student Id"));
                }
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpPut, Route("UpdateStudent")]
        public IActionResult Update(Student student)
        {
            try
            {
                studentRepository.Update(student);
                return StatusCode(200, student);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpDelete, Route("DeleteStudent")]
        public IActionResult DeleteStud(int id)
        {
            try
            {
                studentRepository.Delete(id);
                return StatusCode(200, "deleted");
            }
            catch(Exception ex)
            {
                return StatusCode(501, ex);

            }
        }
       

    }

}

