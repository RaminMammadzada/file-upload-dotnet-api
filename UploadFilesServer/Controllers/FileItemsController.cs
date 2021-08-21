using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UploadFilesServer.Models;
using UploadFilesServer.Data;

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
        public IActionResult CreateFile([FromBody]File file)
        {
            try
            {
                if (file == null)
                {
                    return BadRequest("File object is null");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }

                file.Id = Guid.NewGuid();
                _context.Add(file);
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
