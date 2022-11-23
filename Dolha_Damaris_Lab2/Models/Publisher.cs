using System.ComponentModel.DataAnnotations;

namespace LibraryModel.Models
{
    public class Publisher
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Publisher name")]
        [StringLength(50)]
        public string? PublisherName { get; set; }
        [StringLength(70)]
        public string? Adress { get; set; }
        public ICollection<PublishedBook>? PublishedBooks { get; set; }
    }
}
