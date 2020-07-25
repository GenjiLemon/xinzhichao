using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestOfHeart.Dto
{
    public class MessageDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public Guid MessageId { get; set; }
        
    }
}
