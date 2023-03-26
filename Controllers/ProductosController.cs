using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        public static List<Productos> ListProd = new List<Productos>()
        {
            new Productos()
            {
                Nombre = "Televisor",
                Codigo = "123",
                Precio = 799.99,
                Estado = true
            },

            new Productos()
            {
                Nombre = "Laptop",
                Codigo = "456",
                Precio = 1299.99,
                Estado = true
            },

            new Productos()
            {
                Nombre = "Celular",
                Codigo = "789",
                Precio = 599.99,
                Estado = false
            },

        };

        [HttpGet("Listar")]
        public List<Productos> ListarProductos()
        {
            return ListProd;
        }

    }
}
