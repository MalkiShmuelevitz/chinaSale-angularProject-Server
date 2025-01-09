using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace sale123.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadController : ControllerBase
    {
        // GET: api/<UploadController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<UploadController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}
        //private readonly string _uploadPath;

        //public UploadController(IWebHostEnvironment env)
        //{
        //    // מיקום התיקייה לשמירת הקבצים
        //    _uploadPath = Path.Combine(env.WebRootPath, "assets", "uploads");

        //    if (!Directory.Exists(_uploadPath))
        //    {
        //        Directory.CreateDirectory(_uploadPath);
        //    }
        //}

        //[HttpPost]
        //[Route("upload")]
        //public async Task<IActionResult> UploadFile(IFormFile file)
        //{
        //    if (file == null || file.Length == 0)
        //    {
        //        return BadRequest("No file uploaded.");
        //    }

        //    try
        //    {
        //        var fileName = $"{DateTime.Now.Ticks}_{file.FileName}";
        //        var filePath = Path.Combine(_uploadPath, fileName);

        //        // שמירת הקובץ בתיקייה
        //        using (var stream = new FileStream(filePath, FileMode.Create))
        //        {
        //            await file.CopyToAsync(stream);
        //        }

        //        return Ok(new { FilePath = $"/assets/uploads/{fileName}" });
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, $"Internal server error: {ex.Message}");
        //    }
        //}
        // POST api/<UploadController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        // PUT api/<UploadController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<UploadController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
