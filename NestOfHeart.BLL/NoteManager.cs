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
    class NoteManager : IBLL.INoteManager
    {
        public void AddNote(string username, string content, int permission)
        {
            //先获取stu，为了之后的studentid
            StudentDto stu = (StudentDto)new UserManager().GetUser(username);
            using(INoteService ntSvc=new NoteService())
            {
                ntSvc.Add(new Note()
                {
                   Content=content,
                   Permission= permission,
                   StudentId=stu.StudentId
                });
            }
        }

        public List<NoteDto> GetAllNote()
        {
            List<NoteDto> res = new List<NoteDto>();
            using (INoteService ntSvc = new NoteService())
            {
                var n=ntSvc.GetAllOrder(); 
                foreach(var i in n)
                {
                    res.Add(new NoteDto()
                    {
                        Content = i.Content,
                        StudentName = i.Student.Name
                    });
                }
            }
            return res;
        }

        public List<NoteDto> GetPermissionNote(string username)
        {
            List<NoteDto> res = new List<NoteDto>();
            using(INoteService ntSvc=new NoteService())
            {
                var pnote=ntSvc.GetPublicNote();
                foreach(var i in pnote)
                {
                    res.Add(new NoteDto()
                    {
                        Content = i.Content,
                        StudentName = i.Student.Name
                    });
                }
               
            }
            //直接获取user的note就好了。加到末尾
            res.AddRange(GetUserNote(username));
            return res;
        }

        public List<NoteDto> GetUserNote(string username)
        {
            List<NoteDto> res = new List<NoteDto>();
            using (INoteService ntSvc = new NoteService())
            {
               //从UserManage中获取stu的id
                StudentDto stu = (StudentDto)new UserManager().GetUser(username);
                var snote = ntSvc.GetStudentNote(stu.StudentId);
                //一个个添加进去
                foreach (var i in snote)
                {
                    res.Add(new NoteDto()
                    {
                        Content = i.Content,
                        StudentName = i.Student.Name
                    });
                }
            }
            return res;
        }
    }
}
