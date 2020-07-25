using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestOfHeart.Dto
{
    public class UserDto
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// 1学生2老师9管理员
        /// </summary>
        public int Identity { get; set; }
        public string SchoolName { get; set; }
    }
}
