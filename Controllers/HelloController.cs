using Microsoft.AspNetCore.Mvc;

namespace FirstASP.Controllers
{
    public class HelloController : Controller
    {
        // For each route this controller is to handle:
        [HttpGet]  // the type of request
        [Route("")]  // associated route string (exclude leading /)
        public string Index(string newString){
            
            return "Hello world from HelloController!";
        }

        [HttpGet("{name}")]
        public string Person(string name) {
            return $"Hello {name}";
        }

        [HttpGet("users")]
        public string Users(){
            return "Users route should of kept reading.. dummy...";
        }

        [HttpPost("submission")]
        public string FormSubmission(string formInput){
            return "not implemented submitted that form ";
        }

        [HttpGet("user/{name}/{location}/{age}")]
        public string UserInfo(string name, string location, int age){
            return $"{name}, aged {age} is from {location}!";
        }


    }


}