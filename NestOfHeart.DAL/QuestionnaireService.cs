using NestOfHeart.Model;
namespace NestOfHeart.DAL
{
    public class QuestionnaireService : BaseService<Model.Questionnaire>, IDAL.IQuestionnaireService
    {
        public QuestionnaireService(dbContext db) : base(db)
        {
        }
    }
}