using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NestOfHeart.Model
{
    public class QuestionnaireDetail:BaseEntity
    {
        /// <summary>
        /// 试卷id
        /// </summary>
        [ForeignKey(nameof(Questionnaire)),Required]
        public Guid QuestionnaireId { get; set; }
        public Questionnaire Questionnaire { get; set; }

        /// <summary>
        /// 学生id
        /// </summary>
        [ForeignKey(nameof(Student)), Required]
        public Guid StudentId { get; set; }
        public Student Student { get; set; }
        /// <summary>
        /// 教师id
        /// </summary>
        [ForeignKey(nameof(Teacher))]
        public Guid TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        /// <summary>
        /// 问卷状态，1，待做，2进行中 3已完成
        /// </summary>
        [Required]
        public int Status { get; set; }
        /// <summary>
        /// 问卷类型 1教师发放 2学生自主
        /// </summary>
        [Required]
        public int Type { get; set; }
        /// <summary>
        /// 完成时间
        /// </summary>
        public DateTime FinishTime { get; set; }
        /// <summary>
        /// 得分
        /// </summary>
        public float Score { get; set; }
    }
}