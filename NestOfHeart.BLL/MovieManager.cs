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
    public class MovieManager : IBLL.IMovieManager
    {
        public void AddMovie(string name, string url = "", string brief = "")
        {
            using(IMovieService mvSvc=new MovieService())
            {
                mvSvc.Add(new Movie()
                {
                    Name=name,
                    Url=url,
                    Brief=brief
                });
            }
        }

        public List<MovieDto> GetAllMovie()
        {
            List<MovieDto> res = new List<MovieDto>();
            using (IMovieService mvSvc = new MovieService())
            {
                var m = mvSvc.GetAllOrder();
                foreach(var i in m)
                {
                    res.Add(new MovieDto()
                    {
                        Name=i.Name,
                        Brief=i.Brief,
                        MovieId=i.Id,
                        PeopleNum=i.Count,
                        Url=i.Url
                    });
                }
            }
            return res;
        }

        public void WatchMovie(string username, Guid MovieId)
        {
            //先获取student的id
            StudentDto stu = (StudentDto)new UserManager().GetUser(username);
            //使用的是StudentMovieService
            using (IStudentMovieService smvSvc = new StudentMovieService())
            {
                smvSvc.Add(new StudentMovie()
                {
                    StudentId=stu.StudentId,
                    MovieId=MovieId
                });
            }
        }
    }
}
