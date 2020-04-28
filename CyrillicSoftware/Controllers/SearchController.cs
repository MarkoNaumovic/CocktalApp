using CyrillicSoftware.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace CyrillicSoftware.Controllers
{
    [RoutePrefix("Coctail")]
    public class SearchController : ApiController
    {
        [Route("Save")]
        [HttpGet]
        public void SaveSerch(string term, string email)
        {
            //var user = HttpContext.User.Identity;
            var context = new ApplicationDbContext();
            context.CoctailModel.Add(new CoctailModel() { Email = email, UserSearch = term, Time = DateTime.Now });
            context.SaveChanges();
        }
    }
}