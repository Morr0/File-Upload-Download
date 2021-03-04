using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FileUploadDownload.Api.Controllers
{
    [Route("")]
    [ApiController]
    public class FilesController : Controller
    {
        [HttpPost("upload")]
        public IActionResult Upload([FromForm] IFormFile file)
        {
            return File(file.OpenReadStream(), "text/plain");
        }
    }
}