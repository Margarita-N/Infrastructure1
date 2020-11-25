using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure1.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http.Internal;

namespace Infrastructure1.Controllers
{
    public class VideoPlatform : Controller
    {
        public IActionResult Get(Response response = null)
        {
            return View(response);
        }
        
   
        public IActionResult Admin()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Post(Response response)
        {
            //ruajtja e uploaded file
            FormFile file = System.Web.HttpContext.Current.Request.Files[""]
            // rujtja json
            var currentFile = System.IO.File.ReadAllText("./Data/information.json");
            var resultList = JsonConvert.DeserializeObject<List<UserResponse>>(currentFile);
            resultList.Add( );
            var convertedJson = JsonConvert.SerializeObject(resultList, Formatting.Indented);
            System.IO.File.WriteAllText("./Data/information.json", convertedJson);
           
            // rujta e file 
            var video=

            //var j = JsonConvert.SerializeObject(response);
            //var a = System.IO.File.ReadAllText(@"C://");
            //var b = JsonConvert.DeserializeObject<Response>(a);
            return RedirectToAction(nameof(Admin), response);
        }
    }
}
