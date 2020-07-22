using System;

namespace NestOfHeart.Model
{
    public class BaseEntity
    {
        /// <summary>
        /// 全局GUID
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; } = DateTime.Now;
        /// <summary>
        /// 软删除
        /// </summary>
        public bool IsRemove { get; set; }
    }
}