using System;

namespace NestOfHeart.IDAL
{
    public interface ITeacherService:IBaseService<Model.Teacher>
    {
        new  Guid Add(Model.Teacher t);
    }
}
