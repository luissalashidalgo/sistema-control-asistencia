using ControlAsistencia.Api.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ControlAsistencia.Api.Interfaces
{
    public interface IRepositorioEmpleados
    {
        ActionResult InsertarEmpleado(Empleado empleado);
        IEnumerable<Empleado> ObtenerEmpleados();
        ActionResult<Empleado> ObtenerEmpleado(int id);
        ActionResult ActualizarEmpleado(int id, Empleado empleado);
        ActionResult EliminarEmpleado(int id);

    }
}
