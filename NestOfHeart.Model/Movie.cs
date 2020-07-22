using System.ComponentModel.DataAnnotations;

namespace NestOfHeart.Model
{
    public class Movie:BaseEntity
    {
        /// <summary>
        /// 名称
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// 电影地址
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// 电影简介
        /// </summary>
        public string Brief { get; set; }
        /// <summary>
        /// 观看次数
        /// </summary>
        public int Count { get; set; } = 0;
    }
}