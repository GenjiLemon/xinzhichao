using NestOfHeart.Model;
using NestOfHeart.Dto;
namespace NestOfHeart.IBLL
{
    public interface IUserManager
    {
        void Register(string username, string password, int identity, string name = null, string tel = null, string email = null,string classname=null);
        bool Login(string username,string password);
        void ChangePassword(string username, string newpwd, string oldpwd);
        void StuBindClass(string username, string classname);
        void TeaAddclass(string username, string classname);
        Class GetClass(string classname);
        UserDto GetUser(string username);
    }
}
