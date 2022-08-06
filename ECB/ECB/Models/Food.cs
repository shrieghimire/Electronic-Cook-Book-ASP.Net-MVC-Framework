using System.ComponentModel.DataAnnotations;

namespace ECB.Models
{
    public class Food
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Description { get; set; }


    }
}
