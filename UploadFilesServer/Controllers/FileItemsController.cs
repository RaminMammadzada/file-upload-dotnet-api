using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UploadFilesServer.Data;
using UploadFilesServer.Entities;

namespace UploadFilesServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileItemsController : ControllerBase
    {

    private readonly DataContext _context;

        public FileItemsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllFiles()
        {
            try
            {
                var files = _context.FileItems.ToList();

                return Ok(files);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }

        [HttpPost]
        public IActionResult CreateFile([FromBody]FileItem fileItem)
        {
            try
            {
                if (fileItem == null)
                {
                    return BadRequest("FileItem object is null");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }

                fileItem.Id = Guid.NewGuid();
                _context.Add(fileItem);
                _context.SaveChanges();

                return StatusCode(201);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }
    }
}
