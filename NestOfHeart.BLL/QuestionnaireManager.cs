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
    public class QuestionnaireManager : IBLL.IQuestionnaireManager
    {
        //返回questionnaireid,type1是给学生自主用2是老师用
        public Guid AddQuestionnair(string name,string brief,int type)
        {
            using(IQuestionnaireService qstnSvc=new QuestionnaireService())
            {
                return qstnSvc.Add(new Questionnaire()
                {
                   Name=name,
                   Brief=brief,
                   Type=type,
                   Count=0
                });
            }
        }
        //添加完试卷后再一道一道添加题
        public void AddQuestion(Guid questionnaireid ,int order,string title,string choice,int type)
        {
            using(IQuestionService qstSvc=new QuestionService())
            {
                qstSvc.Add(new Question()
                {
                    QuestionnaireId=questionnaireid,
                    Order=order,
                    Title=title,
                    Choice=choice,
                    Type=type
                });
            }
        }

        public QuestionnaireDto GetQuestionnaire(Guid QuestionnaireId)
        {
            using(IQuestionnaireService qstnSvc=new QuestionnaireService())
            {
                //先获取其他信息
                Questionnaire qstn = qstnSvc.GetOne(QuestionnaireId);
                QuestionnaireDto res=new QuestionnaireDto()
                {
                    Name=qstn.Name,
                    Brief=qstn.Brief,
                    PeopleNum=qstn.Count,
                    QuestionnaireId=qstn.Id
                };
                //获取每个question
                using(IQuestionService qstSvc=new QuestionService())
                {
                    var list=qstSvc.GetQuestionsByQuestionnaireIdOrder(QuestionnaireId);
                    foreach(var i in list)
                    {
                        //获取到的就是按照顺序的question
                        res.QuestionList.Add(new QuestionDto()
                        {
                            Order=i.Order,
                            Title=i.Title,
                            Choice = i.Choice,
                            Type=i.Type
                        });
                    }
                }
                return res;
                
            }
        }

      //获取老师看到的试卷列表
        public List<QuestionnaireDto> GetTeacherQuestionnaireList()
        {
            using (IQuestionnaireService qstnSvc = new QuestionnaireService())
            {
                //只获取基本信息，如果需要获取question再使用id传
                List<QuestionnaireDto> res = new List<QuestionnaireDto>();
                var list=qstnSvc.GetQuestionnairesByTypeid(2);
                foreach(var i in list)
                {
                    res.Add(new QuestionnaireDto()
                    {
                        Name=i.Name,
                        Brief=i.Brief,
                        PeopleNum=i.Count,
                        QuestionnaireId=i.Id
                    });
                }
                return res;
            }
        }

        //和teacher就差一个type
        public List<QuestionnaireDto> GetStudentQuestionnaireList()
        {
            using (IQuestionnaireService qstnSvc = new QuestionnaireService())
            {
                List<QuestionnaireDto> res = new List<QuestionnaireDto>();
                var list = qstnSvc.GetQuestionnairesByTypeid(1);
                foreach (var i in list)
                {
                    res.Add(new QuestionnaireDto()
                    {
                        Name = i.Name,
                        Brief = i.Brief,
                        PeopleNum = i.Count,
                        QuestionnaireId = i.Id
                    });
                }
                return res;
            }
        }
        //返回QuestionnaireDetailId
        public Guid BeginQuestionnaire(Guid QuestionaireId,string username)
        {
            //获取Studentid而获取dto
            StudentDto stu = (StudentDto)new UserManager().GetUser(username);
            //需要创建一个新的detail
            using (IQuestionnaireDetailService qstndSvc = new QuestionnaireDetailService())
            {
                QuestionnaireDetail questionnairedetail = new QuestionnaireDetail()
                {
                    StudentId = stu.StudentId,
                    QuestionnaireId = QuestionaireId,
                    Status = 2,
                    Type = 1
                };
               qstndSvc.Add(questionnairedetail);
                return questionnairedetail.Id;
            }
        }
        public void BeginQuestionnaireFromTeacher(Guid questionnairedetailid)
        {
            using(IQuestionnaireDetailService qstndSvc=new QuestionnaireDetailService())
            {
                QuestionnaireDetail qstnd=qstndSvc.GetOne(questionnairedetailid);
                qstnd.Status = 2;
                qstndSvc.Edit(qstnd);
            }
        }
        //注意接口的实现还没写
        public bool IsInAnswer(string username)
        {
            StudentDto stu = (StudentDto)new UserManager().GetUser(username);
            using (IQuestionnaireDetailService qstndSvc = new QuestionnaireDetailService())
            {
                if (qstndSvc.GetListByStudentIdStatus(stu.StudentId,status:2) != null) return true;
                else return false;
            }
        }

        public void StopQuestionnaire(Guid QuestionnaireDetaiId,float score)
        {
            using (IQuestionnaireDetailService qstndSvc = new QuestionnaireDetailService())
            {
                QuestionnaireDetail qstnd=qstndSvc.GetOne(QuestionnaireDetaiId);
                qstnd.FinishTime = DateTime.Now;
                qstnd.Status = 3;
                qstnd.Score = score;
                qstndSvc.Edit(qstnd);
            }
        }
        //获得已完成的答卷的详细信息
        public QuestionnaireDetailDto GetQuestionnaireDetail(Guid QuestionnaireDetaiId)
        {
            using (IQuestionnaireDetailService qstndSvc = new QuestionnaireDetailService())
            {
                QuestionnaireDetail qstnd = qstndSvc.GetOne(QuestionnaireDetaiId);
                //返回dto注意拿到所有的数据
                return new QuestionnaireDetailDto()
                {
                    FinishTime=qstnd.FinishTime,
                    Score=qstnd.Score,
                    StudentId=qstnd.StudentId,
                    StudentName=qstnd.Student.Name,
                    QuestionnaireId= qstnd.QuestionnaireId//通过bll的函数来获得dto
                };
            }
        }
        //获得student所有的答卷
        public List<QuestionnaireDetailDto> GetStudentQuestionnaireDetail(string username)
        {
            StudentDto stu = (StudentDto)new UserManager().GetUser(username);
            using (IQuestionnaireDetailService qstndSvc = new QuestionnaireDetailService())
            {
                List<QuestionnaireDetailDto> res = new List<QuestionnaireDetailDto>();
                var list = qstndSvc.GetListByStudentId(stu.StudentId);
                foreach(var i in list)
                {
                    res.Add(new QuestionnaireDetailDto()
                    {
                        Score = i.Score,
                        StudentId = stu.StudentId,
                        StudentName = stu.Name,
                        FinishTime = i.FinishTime,
                        QuestionnaireId = i.QuestionnaireId
                    });
                }
            return res;
            }
        }

        //public List<QuestionnaireDetailDto> GetClassQuestionnaireDetail(string classname)
        //{
        //    using (IClassService clsSvc = new ClassService())
        //    {
        //        //先获得id
        //        Guid classid=clsSvc.GetIdByName(classname);
        //        using(IQuestionnaireDetailService qstndSvc=new QuestionnaireDetailService())
        //        {
        //            List<QuestionnaireDetailDto> res = new List<QuestionnaireDetailDto>();
        //            //根据classid获得列表转化为dto
        //            var list = qstndSvc.GetListByClassId(classid);
        //            foreach (var i in list)
        //            {
        //                res.Add(new QuestionnaireDetailDto()
        //                {
        //                    Score = i.Score,
        //                    StudentId = i.StudentId,
        //                    StudentName = i.Student.Name,
        //                    FinishTime = i.FinishTime,
        //                    Questionnaire = GetQuestionnaire(i.QuestionnaireId)
        //                });
        //            }
        //            return res;
        //        }
               
        //    } 
        //}

        
    }
}
