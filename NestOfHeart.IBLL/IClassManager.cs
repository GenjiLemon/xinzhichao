using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestOfHeart.IBLL
{
    public interface IClassManager
    {
        List<Dto.ClassDto> GetTeacherClasses(Guid teacherid);
    }
}
