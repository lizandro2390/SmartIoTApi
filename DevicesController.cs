using Microsoft.AspNetCore.Mvc;
using SmartIoTApi.Models;

namespace SmartIoTApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DevicesController : ControllerBase
    {
        // Lista en memoria por ahora (más adelante será base de datos)
        private static List<Device> devices = new List<Device>
        {
            new Device { Name = "Luz Sala", Type = "Bombillo", IsOnline = true },
            new Device { Name = "Sensor Humedad", Type = "Sensor", IsOnline = false },
            new Device { Name = "Ventilador", Type = "Ventilador", IsOnline = true }
        };

        // GET: /api/devices
        [HttpGet]
        public ActionResult<IEnumerable<Device>> GetAll()
        {
            return Ok(devices);
        }

        // POST: /api/devices
        [HttpPost]
        public ActionResult<Device> Create(Device device)
        {
            device.Id = Guid.NewGuid(); // asignar ID único
            devices.Add(device);
            return CreatedAtAction(nameof(GetAll), new { id = device.Id }, device);
        }
    }
}
