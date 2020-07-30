using System;
using System.Collections.Generic;
using System.Linq;
using NestOfHeart.Model;
namespace NestOfHeart.DAL
{
    public class QuestionService : BaseService<Model.Question>, IDAL.IQuestionService
    {
        public QuestionService(dbContext db) : base(db)
        {
        }
        public QuestionService() { }

        public List<Question> GetQuestionsByQuestionnaireIdOrder(Guid QuestionnaireId)
        {
            List<Question> list = GetAllOrder().ToList();
            list.Sort(new OrderComparer());
            return list;

        }
        class OrderComparer : IComparer<Question>
        {
            
            //升序排列
            public int Compare(Question x, Question y)
            {
                return x.Order - y.Order;
            }
        }
    }
}