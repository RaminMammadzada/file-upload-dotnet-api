using System;
using System.Collections.Generic;
using UploadFilesServer.Extensions;

namespace UploadFilesServer.Entities
{
  public class FileItem
  {
    public Guid Id { get; set; }
    public string FilePath { get; set; }
    public int FileSize { get; set; }
    public string FileName { get; set; }
    public string FileType{ get; set; }
    public DateTime UploadDate { get; set; }
  }
}