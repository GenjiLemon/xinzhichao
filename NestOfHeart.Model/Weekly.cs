using System.ComponentModel.DataAnnotations;

namespace NestOfHeart.Model
{
    public class Weekly:BaseEntity
    {
        [Required,StringLength(30)]
        public string Title { get; set; }
        public string Content { get; set; }
        /// <summary>
        /// 接收人：1全体，2个体(个体的表还没写）
        /// </summary>
        public int ReceiverType { get; set; } = 1;

    }
}