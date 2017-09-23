using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.Models;
namespace WebApplication2.Controllers
{
    public class TheatersController : ApiController
    {
        List<Theater> theaters = new List<Theater>()
        {
            new Theater()
            {
                Id= "1",
                Name = "Inox City Centre",
                Location = "Salt Lake",
                Movies = new List<String>(){"1", "2"}
            },
            new Theater()
            {
                Id= "2",
                Name = "PVR Diamond Plaza",
                Location = "Jessore Road",
                Movies = new List<String>(){"2"}
            },
            new Theater()
            {
                Id= "3",
                Name = "Cinemax",
                Location = "Mani Square",
                Movies = new List<String>(){"2", "3"}
            }
        };
        // GET api/theaters/
        public System.Web.Http.Results.JsonResult< List<Theater> > Get()
        {  
            return Json(theaters);
        }

        // GET api/theaters/{id}
        public System.Web.Http.Results.JsonResult<Theater> Get(string id)
        {
            return Json(theaters.Find(t => { return t.Id == id; }));
        }


    }
}