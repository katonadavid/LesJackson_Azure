using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace SimpleApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PizzaController : ControllerBase
    {
        private static readonly Pizza[] Pizzas = new Pizza[]
        {
            new Pizza 
            {
                Name = "Bologna",
                Price = 11.0
            },
            new Pizza 
            {
                Name = "Piedone",
                Price = 11.0
            },
            new Pizza 
            {
                Name = "Hawaii",
                Price = 11.0
            },
            new Pizza 
            {
                Name = "Margarita",
                Price = 11.0
            },
            new Pizza 
            {
                Name = "Hungarian",
                Price = 11.0
            },
            new Pizza 
            {
                Name = "Pesto",
                Price = 11.0
            },
            new Pizza 
            {
                Name = "Tonno",
                Price = 11.0
            },
            new Pizza 
            {
                Name = "Diavolo",
                Price = 11.0
            },
            new Pizza 
            {
                Name = "Mexicana",
                Price = 11.0
            }
        };

        [HttpGet]
        public IEnumerable<Pizza> Get()
        {
            return Pizzas.ToArray();            
        }

        [HttpGet("{id}")]
        public Pizza GetPizza(int id)
        {
            return Pizzas[id -1 ];
        }
    }
}
