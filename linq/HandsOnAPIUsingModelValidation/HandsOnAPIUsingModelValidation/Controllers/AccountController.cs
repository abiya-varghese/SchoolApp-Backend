using HandsOnAPIUsingModelValidation.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnAPIUsingModelValidation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        List<Login> logins = new List<Login>()
        {
            new Login(){UserName="Ann",Password="123"},
            new Login(){UserName="Anna",Password="123"},
            new Login(){UserName="Celin",Password="123"},
            new Login(){UserName="Anu",Password="123"},
            new Login(){UserName="Appu",Password="123"},


        };
        List<User> users = new List<User>() {
        new User(){Id=1,Name="Ann",Email="Ann@gmail.com",Mobile="34546572",UserName="Ann",Password="123"}
        };
        [HttpPost]
        public IActionResult Validate(Login login)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    //var user = logins.SingleOrDefault(u => u.UserName == login.UserName && u.Password == login.Password);
                    //var user=(from u in logins
                    //          where u.UserName == login.UserName&& u.Password == login.Password
                    //          select u).SingleOrDefault();
                    var user=(from l in logins
                              join u in users
                              on  l.UserName equals u.UserName
                              where u.UserName==login.UserName&&u.Password==login.Password
                              select u);
                    if (user != null)
                    {
                        //return StatusCode(200, new JsonResult("Valid User"));
                        return StatusCode(200, user);
                    }
                    else
                        return StatusCode(501, new JsonResult("Invalid User"));
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception  ex)
            {

                return StatusCode(400, ex); 
            }
        }
        [HttpPost,Route("Register")]
        public IActionResult Register([FromBody]User user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    user.Id=new Random().Next(100,1000);
                    users.Add(user);
                    return Ok(user);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex);
            }
        }
    }
}
