using NestOfHeart.Model;
namespace NestOfHeart.DAL
{
    public class QuestionService : BaseService<Model.Question>, IDAL.IQuestionService
    {
        public QuestionService(dbContext db) : base(db)
        {
        }
        public QuestionService() { }
    }
}