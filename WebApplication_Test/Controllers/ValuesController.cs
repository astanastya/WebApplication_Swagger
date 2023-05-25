using Microsoft.AspNetCore.Mvc;

namespace WebApplication_Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // GET api
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var users = UserService.Get();
                return Ok(users);
            }
            catch (Exception ex)
            {
                return StatusCode(404, ex.Message);
            }
        }

        // GET api by Id
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var user = UserService.Get(id);
                if (user == null)
                    return NotFound();

                return Ok(user);
            }
            catch (Exception ex)
            {
                return StatusCode(404, ex.Message);
            }
        }

        // POST 
        [HttpPost]
        public void Post([FromBody] User value)
        {
            UserService.Add(value);
        }

        // PUT 
        [HttpPut]
        public IActionResult Put([FromBody] User value)
        {
            try
            {
                var user = UserService.Update(value);
                if (user == false)
                    return NotFound();

                return Ok(user);
            }
            catch (Exception ex)
            {
                return StatusCode(404, ex.Message);
            }
        }

        // DELETE 
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                var user = UserService.Delete(id);
                if (user == false)
                    return NotFound();

                return Ok(user);
            }
            catch (Exception ex)
            {
                return StatusCode(404, ex.Message);
            }
        }
    }
}
