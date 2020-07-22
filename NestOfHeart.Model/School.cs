using System.ComponentModel.DataAnnotations;

namespace NestOfHeart.Model
{
    public class School:BaseEntity
    {
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// 省份Code
        /// </summary>
        public string ProvinceCode  { get; set; }
    }
}