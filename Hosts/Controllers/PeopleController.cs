using Business.Factory;
using Microsoft.AspNetCore.Mvc;

namespace Hosts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly IFactory _businessLayer;
        public PeopleController()
        {
            _businessLayer = Factory.GetInstance();
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_businessLayer.PeopleService.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet(":id")]
        public IActionResult GetbyID(int id)
        {
            try
            {
                return Ok(_businessLayer.PeopleService.GetByID(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("/shuffle")]
        public IActionResult GetbyRandomID()
        {
            var list = _businessLayer.PeopleService.GetAll();
            var random = new Random();
            var index = random.Next(list.Count);
            try
            {
                return Ok(list[index]);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete(":id")]
        public IActionResult DeleteByID(int id)
        {
            try
            {
                _businessLayer.PeopleService.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}