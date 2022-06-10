using Microsoft.AspNetCore.Mvc;

namespace TacoApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TacoController : ControllerBase
{
    private readonly ILogger<TacoController> _logger;
    private readonly Random _random;

    private static readonly string[] _shells = new[]
    {
        "flour", "corn"
    };
    private static readonly string[] _baseLayer = new[]
    {
        "Beef", "Chicken", "Pork", "Fish", "Corn & Black beans"
    };
    private static readonly string[] _mixins = new[]
    {
        "Cheese", "Tomatoes", "Lettuce", "Salsa"
    };

    public TacoController(ILogger<TacoController> logger)
    {
        _logger = logger;
        _random = new Random();
    }

    [HttpGet(Name = "GetTacos")]
    public IEnumerable<Taco> Get()
    {
        return Enumerable.Range(0, 5).Select(index => new Taco
        {
            Shell = new Ingredient{Name = _shells[_random.Next(_shells.Length)]},
            BaseLayer = new Ingredient{Name = _baseLayer[_random.Next(_baseLayer.Length)]},
            Mixins = new Ingredient{Name = _mixins[_random.Next(_mixins.Length)]}
        })
        .ToArray();
    }
}
