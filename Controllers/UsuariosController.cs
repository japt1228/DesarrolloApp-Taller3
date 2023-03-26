using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        public static List<Usuarios> ListUsers = new List<Usuarios>()
        {
            new Usuarios()
            {
                Cedula = 12345,
                Nombre = "Juan Perez",
                Direccion = "Calle 123",
                Telefono = "555-5555",
                FechaNacimiento = new DateTime(1990, 1, 1)
            },

            new Usuarios()
            {
                Cedula = 123456789,
                Nombre = "Ana Rodriguez",
                Direccion = "Calle 456",
                Telefono = "555-5556",
                FechaNacimiento = new DateTime(1990, 1, 2)
            },

            new Usuarios()
            {
                Cedula = 987654321,
                Nombre = "Carlos Gonzalez",
                Direccion = "Avenida 456",
                Telefono = "555-5557",
                FechaNacimiento = new DateTime(1985, 5, 10)
            },

            new Usuarios()
            {
                Cedula = 456123789,
                Nombre = "Maria Hernandez",
                Direccion = "Calle 789",
                Telefono = "555-5558",
                FechaNacimiento = new DateTime(2000, 12, 25)
            },


        };


        [HttpGet("Listar")]
        public List<Usuarios> ListarUsuarios()
        {
            return ListUsers;
        }

    }
}
