using System;
using System.ComponentModel.DataAnnotations;

namespace NestOfHeart.Model
{
    public class User:BaseEntity
    {
        [Required,StringLength(30)]
        public string Username { get; set; }
        public string Password { get; set; }
        /// <summary>
        /// 身份，1学生2老师9管理员
        /// </summary>
        public int Identity { get; set; }
        /// <summary>
        /// 如果是学生老师则对应的是表的Id
        /// </summary>
        public Guid DetailId { get; set; }
       
    }
}