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
    class FavoriteManager : IBLL.IFavoriteManager
    {
        public void AddFavorite(string username, string title, string url)
        {
            StudentDto stu = (StudentDto)new UserManager().GetUser(username);
            using(IFavoriteService fvrtSvc=new FavoriteService())
            {
                //注意这里是userid不是studentid
                fvrtSvc.Add(new Favorite()
                {
                    Url = url,
                    Title = title,
                    UserId = stu.UserId
                });
            }
        }

        public List<FavoriteDto> GetUserFavorite(string username)
        {
            List<FavoriteDto> res = new List<FavoriteDto>();
            using(IUserService userSvc=new UserService())
            {
                Guid userid=userSvc.GetIdByUsername(username);
                using (IFavoriteService fvrtSvc = new FavoriteService())
                {
                    var f=fvrtSvc.GetUserFavorite(userid);
                    foreach(var i in f)
                    {
                        res.Add(new FavoriteDto()
                        {
                            Title=i.Title,
                            Url=i.Url
                        });
                    }
                }
            }
            return res;
        }
    }
}
