using NestOfHeart.Model;

namespace NestOfHeart.DAL
{
    public class MessageService : BaseService<Message>, IDAL.IMessageService
    {
        public MessageService(dbContext db) : base(db)
        {
        }
    }
}