using System.Linq;
using UploadFilesServer.DTOs;
using UploadFilesServer.Entities;
using UploadFilesServer.Extensions;
using AutoMapper;

namespace API.Helpers
{
  public class AutoMapperFiles : FileItem
  {
    public AutoMapperFiles()
    {
      // CreateMap<FileItem, FileItemDto>();
    }
  }
}