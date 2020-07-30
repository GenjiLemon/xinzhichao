using System;
using System.Collections.Generic;
using System.Linq;
using NestOfHeart.Model;
namespace NestOfHeart.DAL
{
    public class QuestionnaireDetailService : BaseService<Model.QuestionnaireDetail>, IDAL.IQuestionnaireDetailService
    {
        public QuestionnaireDetailService(dbContext db) : base(db)
        {
        }
        public QuestionnaireDetailService() { }

        public List<QuestionnaireDetail> GetListByStudentId(Guid studentid)
        {
            return GetAllOrder().Where(m => m.StudentId == studentid).ToList();
        }

        public List<QuestionnaireDetail> GetListByStudentIdStatus(Guid studentid,int status)
        {
            return GetAllOrder().Where(m => m.StudentId == studentid&& m.Status==status).ToList();
        }

       

       
    }
}