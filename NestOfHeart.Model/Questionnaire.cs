using System.ComponentModel.DataAnnotations;

namespace NestOfHeart.Model
{
    public class Questionnaire:BaseEntity
    {
        /// <summary>
        /// 问卷名称
        /// </summary>
        [Required,StringLength(20)]
        public string Name { get; set; }
        /// <summary>
        /// 简介
        /// </summary>
        [StringLength(50)]
        public string Brief { get; set; }
        /// <summary>
        /// 类型：1学生自主，2老师选用
        /// </summary>
        [Required]
        public int Type { get; set; }
        /// <summary>
        /// 使用人次
        /// </summary>
        public int Count { get; set; } = 0;
    }
}