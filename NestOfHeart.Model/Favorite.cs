using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NestOfHeart.Model
{
    public class Favorite:BaseEntity
    {
        [Required]
        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
        public User User { get; set; }
        /// <summary>
        /// 收藏的标题
        /// </summary>
        [StringLength(30)]
        public string Title { get; set; }
        /// <summary>
        /// 收藏的地址
        /// </summary>
        public string Url { get; set; }
        
    }
}