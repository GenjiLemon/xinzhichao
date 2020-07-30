using System;
using System.Collections.Generic;
using System.Linq;
using NestOfHeart.IDAL;
using NestOfHeart.Model;
namespace NestOfHeart.DAL
{
    public class QuestionnaireService : BaseService<Model.Questionnaire>, IDAL.IQuestionnaireService
    {
        public QuestionnaireService(dbContext db) : base(db)
        {
        }
        public QuestionnaireService() { }

        Guid IQuestionnaireService.Add(Questionnaire questionnaire)
        {

            db.Set<Questionnaire>().Add(questionnaire);
            db.SaveChanges();
            return questionnaire.Id;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="typeid">1学生自主2教师使用</param>
        /// <returns></returns>
        public List<Questionnaire> GetQuestionnairesByTypeid(int typeid)
        {
            return GetAllOrder().Where(m => m.Type == typeid).ToList();
        }
    }
}