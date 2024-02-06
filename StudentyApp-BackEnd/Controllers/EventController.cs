using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentyApp_BackEnd.Data;

namespace StudentyApp_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Event>>> GetEvents()
        {
            return new List<Event>
            {
                new Event
                {
                    Name = "Event 1",
                    FirstName = "Test_FN 1",
                    LastName = "Test_LN 1",
                    Place = "Place 1"
                }
            };
        }
    }
}
