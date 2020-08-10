using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NestOfHeart.DAL;
using NestOfHeart.Dto;
using NestOfHeart.IDAL;

namespace NestOfHeart.BLL
{
    public class ClassManger : IBLL.IClassManager
    {
        public List<ClassDto> GetTeacherClasses(Guid teacherid)
        {
            List<ClassDto> res = new List<ClassDto>();
            using (IClassService classSvc = new ClassService())
            {   //循环把每个class的name方到classnames里面
                foreach (Model.Class t in classSvc.GetClassesByTeacherid(teacherid))
                {
                    res.Add(new ClassDto()
                    {
                        Name = t.Name,
                        ClassId = t.Id
                   });
                }
            }
        return res;
        }
    }
}
