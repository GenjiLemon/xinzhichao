using NestOfHeart.Model;
namespace NestOfHeart.DAL
{
    public class QuestionnaireDetialService : BaseService<Model.QuestionnaireDetail>, IDAL.IQuestionnaireDetailService
    {
        public QuestionnaireDetialService(dbContext db) : base(db)
        {
        }
    }
}