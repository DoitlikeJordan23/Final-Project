using Microsoft.AspNetCore.Mvc;

namespace MyWebAPI.Controllers
{
    [ApiController]
    [Route("postInfo")]
    
    public class SitePostController : ControllerBase
    {
      [HttpGet, Route("GetpostInfo")]
       public string GetpostInfo()
       {
         var htmlContent = "_";

         htmlContent = System.IO.File.ReadAllText(@"C:\Users\gstar\OneDrive - University of East London\Desktop\Software Developer\Final project\index.html");

         return htmlContent;
       }

       [HttpPost, Route("SignupToNewsletter")]
       public string SignupToNewsletter()
       {
         var htmlContentText = "_";

         htmlContentText = System.IO.File.ReadAllText(@"C:\Users\gstar\OneDrive - University of East London\Desktop\Software Developer\Final project\index.html");

         return htmlContentText;
       }

       [HttpGet, Route("GetSocialMediaDetailsById")]
       public string GetSocialMediaDetailsById()
       {
         var htmlContentTxt = "_";

         htmlContentTxt = System.IO.File.ReadAllText(@"C:\Users\gstar\OneDrive - University of East London\Desktop\Software Developer\Final project\index.html");

         return htmlContentTxt;
       }
    }
}