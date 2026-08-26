using ControlAsistencia.Api.Entities;
using ControlAsistencia.Api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ControlAsistencia.Api.Controllers
{
    [ApiController]
    [Route("api/Empleados")]
    public class EmpleadosController : ControllerBase
    {
        private readonly IRepositorioEmpleados repositorioEmpleados;

        public EmpleadosController(IRepositorioEmpleados repositorioEmpleados)
        {
            this.repositorioEmpleados = repositorioEmpleados;
        }

        [HttpGet]
        public IEnumerable<Empleado> Get()
        {
            return repositorioEmpleados.ObtenerEmpleados();
        }

        [HttpGet("{id:int}")]
        public ActionResult<Empleado> Get(int id)
        {
            return repositorioEmpleados.ObtenerEmpleado(id);
        }

        [HttpPost]
        public ActionResult Post(Empleado empleado)
        {
            return repositorioEmpleados.InsertarEmpleado(empleado);
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Empleado empleado)
        {
            return repositorioEmpleados.ActualizarEmpleado(id, empleado);
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)  
        {
            return repositorioEmpleados.EliminarEmpleado(id);
        }
    }
}
