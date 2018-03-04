using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Grassroots.Controllers
{
    public class TestController : Controller
    {
        // 
        // GET: /Test/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}