using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NestOfHeart.Dto;
using NestOfHeart.Model;
using NestOfHeart.IDAL;
using NestOfHeart.DAL;
namespace NestOfHeart.BLL
{
    class MessageManager : IBLL.IMessageManager
    {
        public void CreateMessage(string username, string content, string title = "系统消息")
        {
            using(IUserService userSvc = new UserService())
            {
                //先拿到userid
                Guid userid=userSvc.GetIdByUsername(username);
                using (IMessageService msgSvc = new MessageService())
                {
                    msgSvc.Add(new Message()
                    {
                        UserId= userid,
                        Title=title,
                        Content=content
                    });
                }
            }
        }

        public List<MessageDto> GetUserMessage(string username)
        {
            List<MessageDto> res = new List<MessageDto>(); 
            //先拿到userid
            using (IUserService userSvc = new UserService())
            {
                Guid userid = userSvc.GetIdByUsername(username);
                using (IMessageService msgSvc = new MessageService())
                {
                    //拿到msg的list
                   var m= msgSvc.GetMessagesByUserid(userid);
                    foreach(var i in m)
                    {
                        res.Add(new MessageDto()
                        {
                            Title=i.Title,
                            Content=i.Content,
                            MessageId=i.Id
                        });
                    }
                }
            }
            return res;
        }

        public void ReadMessage(Guid guid)
        {
            using(IMessageService msgSvc=new MessageService())
            {
                Message msg = msgSvc.GetOne(guid);
                msg.IsRead = true;
                msgSvc.Edit(msg);
            }
        }
    }
}
