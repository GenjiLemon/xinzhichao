using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestOfHeart.Dto
{
    public class QuestionnaireDto
    {
        public string Name { get; set; }
        public string Brief { get; set; }
        /// <summary>
        /// 使用人数
        /// </summary>
        public int PeopleNum { get; set; }
        public Guid QuestionnaireId { get; set; }
        //public List<QuestionDto> QuestionList { get; set; }
    }
}
