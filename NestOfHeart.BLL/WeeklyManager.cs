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
    public class WeeklyManager : IBLL.IWeeklyManager
    {
        //暂时全是全体
        public void AddWeekly(string title, string content,int type=1)
        {
            using(IWeeklyService weeklySvc=new WeeklyService())
            {
                weeklySvc.Add(new Weekly()
                {
                    Title = title,
                    Content= content,
                    ReceiverType=type
                });
            }
        }
        
        //暂时不分全体个体都获取所有周报
        public List<WeeklyDto> GetUserWeekly(string username)
        {
            List<WeeklyDto> res = new List<WeeklyDto>();
            using (IWeeklyService weeklySvc=new WeeklyService())
            {
                //获取所有的weekly
                var w = weeklySvc.GetAllOrder();
                foreach(var i in w)
                {
                    //转化成一个个Dto，日期部分只要日期
                    res.Add(new WeeklyDto()
                    {
                        Title=i.Title,
                        Content=i.Content,
                        Date=i.CreateTime.Date
                    });
                }
            }
            return res;
            
        }
    }
}
