using System;
using System.Collections.Generic;
using System.Linq;
using NestOfHeart.Model;

namespace NestOfHeart.DAL
{
    public class MessageService : BaseService<Message>, IDAL.IMessageService
    {
        public MessageService(dbContext db) : base(db)
        {
        }
        public MessageService() { }

        public List<Message> GetMessagesByUserid(Guid userid)
        {
            return GetAllOrder().Where(m => m.UserId == userid).ToList();
        }
    }
}