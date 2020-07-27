using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestOfHeart.IBLL
{
    public interface IMovieManager
    {
        List<Dto.MovieDto> GetAllMovie();
        void WatchMovie(string username, Guid MovieId);
        void AddMovie(string name, string url = "", string brief = "");
        
    }
}
