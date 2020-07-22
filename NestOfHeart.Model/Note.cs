using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NestOfHeart.Model
{
    public class Note:BaseEntity
    {
        /// <summary>
        /// 内容
        /// </summary>
        [Required]
        public string Content { get; set; }
        [Required]
        [ForeignKey(nameof(Student))]
        public Guid StudentId { get; set; }
        public Student Student { get; set; }
        /// <summary>
        /// 浏览权限：1所有人，2仅自己
        /// </summary>
        public int Permission { get; set; }
    }
}