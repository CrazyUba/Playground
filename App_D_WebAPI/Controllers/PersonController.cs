using App_D;
using System.Web.Http;

namespace App_D_WebAPI.Controllers
{
    public class PersonController : ApiController
    {
        // GET api/person
        public Person Get()
        {
            Person p = new Person("Herbert", 55);
            return p;

        }
    }
}
