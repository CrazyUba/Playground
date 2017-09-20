using App_D;
using System.Web.Http;

namespace App_D_WebAPI.Controllers
{
    public class DogController : ApiController
    {
        // GET api/dog
        public Dog Get()
        {
            Dog d = new Dog { Size = 45, Age = 7 };
            return d;
        }
    }
}
