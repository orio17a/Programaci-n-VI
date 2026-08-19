using Microsoft.AspNetCore.Mvc;
using WebApi2026.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi2026.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComputadoraController : ControllerBase
    {
        // GET: api/<ComputadoraController>
        [HttpGet]
        public List<Computadora> Get()
        {
            List<Computadora> listita= new List<Computadora>();
            Computadora compu = new Computadora();

            compu.marca = "Apple";
            compu.modelo = "Macbook Pro";
            compu.ram = 16;
            compu.procesador = "M5 Pro";

            List<string> programitas = new List<string>();
            programitas.Add("Safari");
            programitas.Add("Chrome");
            programitas.Add("Visual Studio");

            compu.programasInstalados = programitas;

            Computadora compu2 = new Computadora();

            compu2.marca = "Msi";
            compu2.modelo = "Cyborg 14";
            compu2.ram = 32;
            compu2.procesador = "i7";

            List<string> programitas2 = new List<string>();
            programitas2.Add("Safari");
            programitas2.Add("Chrome");
            programitas2.Add("Visual Studio");

            compu2.programasInstalados = programitas2;

            listita.Add(compu);
            listita.Add(compu2);
            return listita;
        }

        // GET api/<ComputadoraController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            if (id == 0)
            {
                return "ERROR";
            }
            return "Ok";
        }

        // POST api/<ComputadoraController>
        [HttpPost]
        public string Post(Computadora compu)
        {
            return compu.modelo;
        }

        // PUT api/<ComputadoraController>/5
        [HttpPut("{id}")]
        public void Put(int id, Computadora compu)
        {
        }

        // DELETE api/<ComputadoraController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
