using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HellWorld/

        public string Index()
        {
            return "This is my <b>Default</b> action...";
        }

        //
        // GET: /HelloWorld/Welcome/
        public string Welcome(string name,int numTimes =1)
        {
            return HttpUtility.HtmlEncode("Hello" + name + ", NumTimes is:" + numTimes);
        }
    }
}
