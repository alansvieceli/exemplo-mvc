using Microsoft.AspNetCore.Mvc;

namespace testeMVC.Controllers
{
    //https://docs.microsoft.com/pt-br/aspnet/core/fundamentals/routing?view=aspnetcore-3.0
    [Route("api/product")]
    public class ProductController : Controller
    {

      [HttpGet("{id:int}")]
      public int Get(int id){
        return id;
      }
        
    }
}