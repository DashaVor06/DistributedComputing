using Microsoft.AspNetCore.Mvc;
using BusinessLogic.Servicies;
using BusinessLogic.DTO.Response;
using BusinessLogic.DTO.Request;

namespace Presentation.Controllers
{
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class CreatorsController : ControllerBase
    {
        private IBaseService<CreatorRequestTo, CreatorResponseTo> _creatorService;
        public CreatorsController(IBaseService<CreatorRequestTo, CreatorResponseTo> creatorService)
        {
            _creatorService = creatorService;
        }

        [HttpGet]
        public ActionResult<List<CreatorResponseTo>> Get()
        {
            return Ok(_creatorService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<CreatorResponseTo> Get(int id)
        {
            CreatorResponseTo? response = _creatorService.GetById(id);
            if (response != null)
            {
                return Ok(response);
            }
            else
            {
                return NotFound();
            }    
        }

        [HttpPost]
        public ActionResult<CreatorResponseTo> Post([FromBody] CreatorRequestTo entity)
        {
            CreatorResponseTo response = _creatorService.Create(entity);
            return Created($"{response.Id}", response);
        }

        [HttpPut]
        public ActionResult<CreatorResponseTo> Put([FromBody] CreatorRequestTo entity)
        {
            CreatorResponseTo? response = _creatorService.Update(entity);
            if (response != null)
            {
                return Ok(response);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            bool wasFound = _creatorService.DeleteById(id);
            if (wasFound)
            {
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
