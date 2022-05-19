using System.ComponentModel.DataAnnotations;

namespace project_tracker.Models
{
    public class Issue
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;
    }
}
