using System.ComponentModel.DataAnnotations.Schema;
namespace CloudApp.Models
{
    public class Files
    {
        public int Id { get; set; }

        public string FileUrl { get; set; }

        [NotMapped]
        public IFormFile FileData { get; set; }


        public string FileDataUrl { get; set; }

       
    }
}
