using System;
using System.Collections.Generic;

namespace NestOfHeart.IDAL
{
    public interface IMessageService:IBaseService<Model.Message>
    {
        List<Model.Message> GetMessagesByUserid(Guid userid);
    }
}