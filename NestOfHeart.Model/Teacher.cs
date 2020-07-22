using System.ComponentModel.DataAnnotations;

namespace NestOfHeart.Model
{
    public class Teacher:BaseEntity
    {
        [Required]
        public string Name { get; set; }
    }
}