using UploadFilesServer.Entities;
using Microsoft.EntityFrameworkCore;

namespace UploadFilesServer.Data
{
  public class DataContext : DbContext
  {
    public DataContext()
    {
    }

    public DataContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<FileItem> FileItems { get; set; }
  }
}