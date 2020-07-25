using NestOfHeart.Model;

namespace NestOfHeart.DAL
{
    public class WeeklyService : BaseService<Model.Weekly>, IDAL.IWeeklyService
    {
        public WeeklyService(dbContext db) : base(db)
        {
        }
        public WeeklyService() { }
    }
}