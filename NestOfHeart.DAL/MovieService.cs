using NestOfHeart.Model;

namespace NestOfHeart.DAL
{
    public class MovieService : BaseService<Movie>, IDAL.IMovieService
    {
        public MovieService(dbContext db) : base(db)
        {
        }
    }
}