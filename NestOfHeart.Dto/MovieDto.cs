using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestOfHeart.Dto
{
    public class MovieDto
    {
        public string Name { get; set; }
        public string Brief { get; set; }
        public int PeopleNum { get; set; }
        public string Url { get; set; }
        public Guid MovieId { get; set; }
    }
}
