using System;
using System.ComponentModel.DataAnnotations;

namespace UploadFilesServer.DTOs
{
  public class FileItemDto
  {
    [Required]
    public string FilePath { get; set; }
    [Required]
    public int FileSize { get; set; }
    [Required]
    public string FileName { get; set; }
    [Required]
    public string FileType { get; set; }
    [Required]
    public DateTime UploadDate { get; set; }
  }
}