using Microsoft.AspNetCore.Mvc;

namespace TestDocker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<object> Get()
        {
            var response = new List<object>
            {
                new { Id = 1, Nome = "Cliente 1", Email = "example1@gmail.com" },
                new { Id = 2, Nome = "Cliente 2", Email = "example1@gmail.com" },
                new { Id = 3, Nome = "Cliente 3", Email = "example1@gmail.com" },
                new { Id = 4, Nome = "Cliente 4", Email = "example1@gmail.com" },
                new { Id = 5, Nome = "Cliente 5", Email = "example1@gmail.com" },
                new { Id = 6, Nome = "Cliente 6", Email = "example1@gmail.com" },
                new { Id = 7, Nome = "Cliente 7", Email = "example1@gmail.com" },
                new { Id = 8, Nome = "Cliente 8", Email = "example1@gmail.com" },
                new { Id = 9, Nome = "Cliente 9", Email = "example1@gmail.com" },
            };

            return response;
        }
    }
}
