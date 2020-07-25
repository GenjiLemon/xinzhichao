using NestOfHeart.Model;
using System;

namespace NestOfHeart.IDAL
{
    public interface IStudentService:IBaseService<Model.Student>
    {
        new Guid Add(Student t);
    }
}
