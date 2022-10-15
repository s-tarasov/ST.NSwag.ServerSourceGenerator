using Microsoft.AspNetCore.Mvc;
using MyNamespace2;

namespace ST.NSwag.ServerSourceGenerator.Example.Controllers
{
    [ApiController]
    public class PetsController : ControllerBase
    {
        [HttpGet]
        [Route(Routes.ListPets)]
        public IEnumerable<Pet> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Pet
            {
                Id = index,
                Name = $"Pet{index}",
                Tag = "pet"
            })
            .ToArray();
        }
    }
}
