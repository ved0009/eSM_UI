using Microsoft.AspNetCore.Http;

namespace SchoolManagement.Model.Model
{
    public class MFileUploader
    {
        public int Id { get; set; }
        public string? FileName { get; set; }
        public int FileSize { get; set; }
        public string? FileType { get; set; }
        public IFormFile formFile { get; set; }
    }
}
