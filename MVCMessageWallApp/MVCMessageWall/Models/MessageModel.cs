using System.ComponentModel.DataAnnotations;

namespace MVCMessageWall.Models
{
	public class MessageModel
	{
        [Required]
        [StringLength(10, MinimumLength = 5)]
        [Display(Name = "Enter a name")]
        public string Message { get; set; }
    }
}
