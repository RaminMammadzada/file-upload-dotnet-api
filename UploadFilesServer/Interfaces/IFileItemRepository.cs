using System.Collections.Generic;
using System.Threading.Tasks;
using UploadFilesServer.DTOs;
using UploadFilesServer.Entities;

namespace UploadFilesServer.Interfaces
{
  public interface IFileItemRepository
  {
    Task<bool> SaveAllAsync();
    // Task<IEnumerable<FileItemDto>> GetFileItemsAsync();
  }
}