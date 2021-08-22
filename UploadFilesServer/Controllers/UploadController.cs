using System;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;

namespace UploadFilesServer.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class UploadController : ControllerBase
  {
    [HttpPost, DisableRequestSizeLimit]
    public IActionResult Upload()
    {
      try
      {
        var file = Request.Form.Files[0];
        var folderName = Path.Combine("StaticFiles", "Files");
        var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);

        Console.WriteLine(file);
        if (file.Length > 0)
        {
          var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');

          // File type validation
          var supportedTypes = new[] { "png", "jpg", "html", "jpeg", "txt", "pdf" };
          var fileExt = System.IO.Path.GetExtension(file.FileName).Substring(1);
          if (!supportedTypes.Contains(fileExt))
          {
            var ErrorMessage = "File Extension Is InValid - Only Upload JPEG/WORD/PDF/EXCEL/TXT File";
            return BadRequest(ErrorMessage);
          }

          // File size validation
          var fileSizeLimit = 5 * 1024 * 1024;
          var fileSize = file.Length;
          if (fileSize > fileSizeLimit)
          {
            var ErrorMessage = "File size can be at most 5 Mb";
            return BadRequest(ErrorMessage);
          }

          var fullPath = Path.Combine(pathToSave, fileName);
          var filePath = Path.Combine(folderName, fileName);


          using (var stream = new FileStream(fullPath, FileMode.Create))
          {
            file.CopyTo(stream);
          }

          return Ok(new { filePath, file });
        }
        else
        {
          return BadRequest();
        }
      }
      catch (Exception ex)
      {
        return StatusCode(500, $"Internal server error: {ex}");
      }
    }
  }
}