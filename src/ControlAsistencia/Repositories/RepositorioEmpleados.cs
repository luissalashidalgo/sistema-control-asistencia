using ControlAsistencia.Api.Entities;
using ControlAsistencia.Api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ControlAsistencia.Api.Repositories
{
    public class RepositorioEmpleados : IRepositorioEmpleados
    {
        private List<Empleado> _empleados;

        public RepositorioEmpleados()
        {
            _empleados = new List<Empleado>
            {
                new Empleado
                {
                    Id = 1,
                    Persona = new Persona
                    {
                        Id = 1,
                        Cedula = "123456789",
                        Nombre = "Juan Pérez",
                        Correo = "juan.perez@example.com"
                    },
                    CodigoInterno = "EMP001",
                    Estado = true
                },
                new Empleado
                {
                    Id = 2,
                    Persona = new Persona
                    {
                        Id = 2,
                        Cedula = "987654321",
                        Nombre = "María Gómez"
                    },
                    CodigoInterno = "EMP002",
                    Estado = false
                }
            };
        }

        public IEnumerable<Empleado> ObtenerEmpleados()
        {
            if (_empleados is null)
            {
                return new List<Empleado>();

            }
            else
            {
                return _empleados;
            }
        }

        public ActionResult<Empleado> ObtenerEmpleado(int id)
        {
            Empleado? empleado = _empleados.FirstOrDefault(e => e.Id == id);
            if (empleado is null)
            {
                return new NotFoundResult();
            }
            else
            {
                return new OkObjectResult(empleado);
            }
        }

        public ActionResult InsertarEmpleado(Empleado empleado)
        {
            if (empleado is null)
            {
                return new BadRequestObjectResult("La información del empleado no puede ser nula");
            }
            else
            {
                _empleados.Add(empleado);
                return new OkResult();
            }
        }

        public ActionResult ActualizarEmpleado(int id, Empleado empleado)
        {
            if(empleado is null)
                return new BadRequestObjectResult("La infomación del empleado no puede ser nula");

            if (id != empleado.Id)
                return new BadRequestObjectResult("Los ids deben de coincidir");

            Empleado? empleadoExistente = _empleados.FirstOrDefault(e => e.Id == id);
            if (empleadoExistente is null)
                return new NotFoundResult();
            else
            {
                _empleados.Remove(empleadoExistente);
                _empleados.Add(empleado);
                return new OkResult();
            }
        }

        public ActionResult EliminarEmpleado(int id)
        {
            Empleado? empleado = _empleados.FirstOrDefault(e => e.Id == id);
            if (empleado is null)
            { 
                return new NotFoundResult(); 
            }
            else
            {
                _empleados.Remove(empleado);
                return new OkResult();
            }
        }
    }
}
