using System;
using System.Collections.Generic;

namespace NestOfHeart.IDAL
{
    public interface IClassService:IBaseService<Model.Class>
    {
        Guid GetIdByName(string classname);
        Model.Class GetOneByName(string classname);
        List<Model.Class> GetClassesByTeacherid(Guid teacherid);
    }
}