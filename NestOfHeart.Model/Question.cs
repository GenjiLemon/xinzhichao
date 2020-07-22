using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NestOfHeart.Model
{
    public class Question:BaseEntity
    {
        /// <summary>
        /// 问卷Id
        /// </summary>
        [ForeignKey(nameof(Questionnaire))]
        public Guid QuestionnaireId { get; set; }
        public Questionnaire Questionnaire { get; set; }
        /// <summary>
        /// 题号
        /// </summary>
        [Required]
        public int Order { get; set; }
        /// <summary>
        /// 题干
        /// </summary>
        [Required]
        public string Title { get; set; }
        /// <summary>
        /// 选项
        /// </summary>
        [Required]
        public string Choice { get; set; }
        /// <summary>
        /// 类别 1标准选择题
        /// </summary>
        [Required]
        public int Type { get; set; }
    }
}