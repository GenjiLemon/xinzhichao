using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NestOfHeart.Dto;
using NestOfHeart.IDAL;
using NestOfHeart.DAL;

namespace NestOfHeart.BLL
{
    public class UserManager : IBLL.IUserManager
    {
        public void ChangePassword(string username, string newpwd, string oldpwd)
        {
            using(IUserService userSvc= new UserService())
            {

                Model.User user = userSvc.GetOneByUsername(username);
                user.Password = newpwd;
                userSvc.Edit(user);
            }
        }
       
        public UserDto GetUser(string username)
        {
            using (IUserService userSvc = new UserService())
            {
                Model.User u = userSvc.GetOne(userSvc.GetIdByUsername(username));
                UserDto user=null;
                //根据类型创建对应的dto
                if (u.Identity == 1)
                {
                    using (IStudentService stuSvc = new StudentService())
                    {
                        ///创建dto
                        StudentDto temp_stu = new StudentDto()
                        {
                            Identity = u.Identity,
                            UserId = u.Id
                        };
                        //获得更多信息
                        Model.Student stu = stuSvc.GetOne(u.DetailId);
                        temp_stu.Name = stu.Name;
                        temp_stu.StudentId = stu.Id;
                        using(IClassService classSvc=new ClassService())
                        {
                            temp_stu.ClassName = classSvc.GetOne(stu.ClassId).Name;
                        }
                        //多态赋
                        user = temp_stu;
                    }
                }
                else if (u.Identity == 2)
                {
                    using (ITeacherService teaSvc = new TeacherService())
                    {
                        TeacherDto temp_tea = new TeacherDto()
                        {
                            Identity = u.Identity,
                            UserId = u.Id
                        };
                        //根据DetailedId找到对应的teacher实体
                        Model.Teacher tea=teaSvc.GetOne(u.DetailId);
                        temp_tea.Name = tea.Name;
                        temp_tea.TeacherId = tea.Id;
                        
                        user = temp_tea;
                    }
                }
                return user;
            }
            
        }

        

        public bool Login(string username, string password)
        {
            using(IUserService userSvc=new UserService())
            {
                //如果没有找到也是账号密码错误
                try
                {
                    Model.User u = userSvc.GetOneByUsername(username);
                    if (u.Password == password) return true;
                    else return false;
                }
                catch
                {
                    return false;
                }   
                
            }
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="identity">1学生2老师</param>
        /// <param name="name"></param>
        /// <param name="tel"></param>
        /// <param name="email"></param>
        /// <param name="classname"></param>
        public void Register(string username, string password, int identity, string name = null, string tel = null, string email = null, string classname = null)
        {
            Model.User u = new Model.User()
            {
                Username = username,
                Password = password,
                Identity = identity
            };
            //添加student或者teacher信息
            if (name != null)
            {
                switch (identity)
                {
                    case 1://学生就先创建student
                        Model.Student stu = new Model.Student() { Name = name };
                        if (classname != null)
                        {
                            using (IClassService classSvc = new ClassService())
                            {
                                stu.ClassId=classSvc.GetIdByName(classname);
                            }
                        }
                        using (IStudentService stuSvc = new StudentService())
                        {
                            //改Add重写了，是返回Id值
                            u.DetailId=stuSvc.Add(stu);
                        }
                        break;
                    case 2:
                        Model.Teacher tea = new Model.Teacher()
                        {
                            Name = name,
                            Tel = tel,
                            Email = email
                        };
                        using(ITeacherService teaSvc=new TeacherService())
                        {
                            u.DetailId=teaSvc.Add(tea);
                        }
                        break;
                }
            }
            using(IUserService userSvc= new UserService())
            {
                userSvc.Add(u);
            }
            
        }

        public void StuBindClass(string username, string classname)
        {
          
            using (IUserService userSvc=new UserService())
            {
                //先获得user再获得student
                Model.User u = userSvc.GetOneByUsername(username);
                using (IStudentService stuSvc = new StudentService())
                {
                    Model.Student stu = stuSvc.GetOne(u.DetailId);
                    using (IClassService classSvc = new ClassService())
                    {
                        stu.ClassId = classSvc.GetIdByName(classname);
                    }
                    stuSvc.Edit(stu);
                }
                
            }
        }

        public void TeaAddclass(string username, string classname)
        {
            //实际上是给class绑定teacherid
            using (IClassService classSvc = new ClassService())
            {
                Model.Class cls = classSvc.GetOneByName(classname);
                TeacherDto tea = (TeacherDto)(GetUser(username));
                cls.TeacherId = tea.TeacherId;
                classSvc.Edit(cls);
            }
        }
    }
}
