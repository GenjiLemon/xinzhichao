using NestOfHeart.Model;
namespace NestOfHeart.DAL
{
    public class NoteService : BaseService<Model.Note>, IDAL.INoteService
    {
        public NoteService(dbContext db) : base(db)
        {
        }
    }
}