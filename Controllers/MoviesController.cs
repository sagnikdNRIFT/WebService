using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.Models;
namespace WebApplication2.Controllers
{
    public class MoviesController : ApiController
    {
        List<Movie> movies = new List<Movie>()
        {
                new Movie()
                {
                    Id= "1",
                    Name = "Avengers",
                    Description = "Awesome"
                },
                new Movie()
                {
                    Id= "2",
                    Name = "The Dark Knight",
                    Description = "Awesomer"
                },
                new Movie()
                {
                    Id= "3",
                    Name = "Sharknado",
                    Description = "Awesomest"
                }
        };
        // GET api/movies/
        public System.Web.Http.Results.JsonResult< List<Movie> > Get()
        {
            return Json(movies);
        }

        // GET api/movies/{id}
        public System.Web.Http.Results.JsonResult<Movie> Get(string id)
        {
            return Json(movies.Find(m => { return m.Id == id; }));
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
