using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UploadFilesServer.Models
{
    public class File
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string FilePath { get; set; }

        [Required]
        public int FileSize { get; set; }

        [Required]
        public string FileName { get; set; }

        [Required]
        public string FileType{ get; set; }

        [Required]
        public DateTime UploadDate { get; set; }
    }
}
