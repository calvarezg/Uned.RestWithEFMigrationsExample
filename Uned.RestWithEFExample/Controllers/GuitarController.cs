using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Uned.RestWithEFExample.Data;
using Uned.RestWithEFExample.Models;

namespace Uned.RestWithEFExample.Controllers
{
    [ApiController]
    [Route("api/guitars")]
    public class GuitarController : Controller
    {
        private GuitarRepository guitars;

        public GuitarController(GuitarRepository guitars)
        {
            this.guitars = guitars;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return Ok(guitars.ToList());
        }

        [HttpGet("{id}")]
        public ActionResult Details(int id)
        {
            var guitar = guitars.Find(id);
            if (guitar == null)
                return NotFound();
            return Ok(guitar);
        }

        [HttpPost]
        public ActionResult Create(Guitar guitar)
        {
            guitars.Add(guitar);
            return Created(nameof(Details), guitar);
        }

        [HttpPut]
        public ActionResult Edit(int id, Guitar guitar)
        {
            if (guitars.NotExists(id))
                return NotFound();

            guitars.Update(guitar);
            return Ok(guitar);
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            if (guitars.NotExists(id))
                return NotFound();
            guitars.Delete(id);
            return Ok();
        }
    }
}
