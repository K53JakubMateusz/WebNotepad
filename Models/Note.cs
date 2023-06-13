using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebNotepad.Models
{
    public class Note
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Content is required.")]
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }

        [DisplayName("Created at")]
        public DateTime CreatedAt { get; set; }

        public string? UserId { get; set; }
    }
}
