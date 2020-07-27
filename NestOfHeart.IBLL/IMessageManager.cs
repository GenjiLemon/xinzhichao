using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NestOfHeart.Dto;
namespace NestOfHeart.IBLL
{
    public interface IMessageManager
    {
        void CreateMessage(string username, string content, string title = "系统消息");
        void ReadMessage(Guid guid);
        List<MessageDto> GetUserMessage(string username);
    }
}
