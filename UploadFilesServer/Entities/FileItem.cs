using System;
using System.Collections.Generic;
using UploadFilesServer.Extensions;
using System.ComponentModel.DataAnnotations;

namespace UploadFilesServer.Entities
{
  public class FileItem
  {
    public Guid Id { get; set; }
    [Required]
    public string FilePath { get; set; }
    [Required]
    public int FileSize { get; set; }
    [Required]
    public string FileName { get; set; }
    [Required]
    public string FileType{ get; set; }
    public DateTime UploadDate { get; set; }
  }
}