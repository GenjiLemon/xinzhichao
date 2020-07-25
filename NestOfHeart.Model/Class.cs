using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NestOfHeart.Model
{
    public class Class : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        /// <summary>
        ///毕业年
        /// </summary>
        public int GraduationYear { get; set; }
        [ForeignKey(nameof(School))]
        public Guid SchoolId { get; set; }
        public School School { get; set; }
        [ForeignKey(nameof(Teacher))]
        public Guid TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        [NotMapped]
        public bool IsGraduated
        {
            get
            {
                return DateTime.Now.Year > GraduationYear;
            }
        }
    }
}