using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestOfHeart.Dto
{
    public class StudentDto:UserDto
    {

        public Guid StudentId { get; set; }
        public string ClassName { get; set; }
        
    }
}
