using Microsoft.AspNetCore.Mvc;

namespace testeMVC.Controllers
{
    //
    [Route("api/product")]
    public class ProductController : Controller
    {

      [HttpGet("{id:int}")]
      public int Get(int id){
        return id;
      }

      [HttpGet("path")]
      public string Path(){
        //HttpContext.Response.StatusCode = 404
        //HttpContext.Request.Query['param'] = 404
        return HttpContext.Request.Path;
      }

      [HttpGet("image")]
      public IActionResult Image(){
      const string img = "images/001.jpg";
      return File(img, "image/jpg+xml");
      }
        
    }
}