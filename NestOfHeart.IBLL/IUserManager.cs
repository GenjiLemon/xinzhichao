
using NestOfHeart.Dto;
using System;

namespace NestOfHeart.IBLL
{
    public interface IUserManager
    {
        void Register(string username, string password, int identity, string name = null, string tel = null, string email = null,string classname=null);
        bool Login(string username,string password);
        void ChangePassword(string username, string newpwd, string oldpwd);
        void StuBindClass(string username, string classname);
        void TeaAddclass(string username, string classname);
        /// <summary>
        /// 根据username获取Userdto
        /// </summary>
        /// <param name="username"></param>
        /// <returns>userdto（多态转换）</returns>
        UserDto GetUser(string username);
        /// <summary>
        /// 根据UserId获取userdto
        /// </summary>
        /// <param name="userid"></param>
        /// <returns>userdto（多态转换）</returns>
        UserDto GetUser(Guid userid);
    }
}
