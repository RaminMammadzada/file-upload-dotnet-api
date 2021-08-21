using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UploadFilesServer.DTOs;
using UploadFilesServer.Entities;
using UploadFilesServer.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace UploadFilesServer.Data
{
  public class FileItemRepository : IFileItemRepository
  {
    private readonly DataContext _context;
    private readonly IMapper _mapper;
    public FileItemRepository(DataContext context, IMapper mapper)
    {
      _mapper = mapper;
      _context = context;
    }

    // public async Task<FileItemDto> GetFileItemAsync(string username)
    // {
    //   return await _context.FileItems
    //           .Where(x => x.UserName == username)
    //           .ProjectTo<FileItemDto>(_mapper.ConfigurationProvider)
    //           .SingleOrDefaultAsync();
    // }

    // public async Task<IEnumerable<FileItemDto>> GetFileItemsAsync()
    // {
    //   return await _context.FileItems
    //             .ProjectTo<FileItemDto>(_mapper.ConfigurationProvider)
    //             .ToListAsync();
    // }

    // public async Task<FileItemDto> GetFileItemByIdAsync(int id)
    // {
    //   return await _context.FileItems.FindAsync(id);
    // }

    // public async Task<bool> SaveAllAsync()
    // {
    //   return await _context.SaveChangesAsync() > 0;
    // }

    // public void Update(FileItem fileItem)
    // {
    //   _context.Entry(user).State = EntityState.Modified;
    // }
  }
}