using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestOfHeart.IBLL
{
    public interface IWeeklyManager
    {
        void AddWeekly(string title, string content,int type);
        List<Dto.WeeklyDto> GetUserWeekly(string username);
    }
}
