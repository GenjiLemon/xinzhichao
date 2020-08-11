using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestOfHeart.IBLL
{
    public interface IQuestionnaireManager
    {

        /// <summary>
        /// 添加问卷
        /// </summary>
        /// <param name="name"></param>
        /// <param name="brief"></param>
        /// <param name="type">类型：1学生自主，2老师选用，3都在</param>
        /// <returns></returns>
        Guid AddQuestionnair(string name, string brief,int type);
        /// <summary>
        /// 问卷添加问题
        /// </summary>
        /// <param name="questionnaireid">问卷id</param>
        /// <param name="order">题号（从1开始）</param>
        /// <param name="title">题干</param>
        /// <param name="choice">选项字符串，选项之间没有间隔符</param>
        /// <param name="type">1标准选择题</param>
        void AddQuestion(Guid questionnaireid, int order, string title, string choice, int type);
        /// <summary>
        /// 根据questionnareid获取问卷dto
        /// </summary>
        /// <param name="QuestionnaireId"></param>
        /// <returns></returns>
        Dto.QuestionnaireDto GetQuestionnaire(Guid QuestionnaireId);
        /// <summary>
        /// 获取教师能看到的问卷库
        /// </summary>
        /// <returns></returns>
        List<Dto.QuestionnaireDto> GetTeacherQuestionnaireList();
        /// <summary>
        /// 获取学生能看到的问卷库
        /// </summary>
        /// <returns></returns>
        List<Dto.QuestionnaireDto> GetStudentQuestionnaireList();
        /// <summary>
        /// 学生自主开始一个问卷
        /// </summary>
        /// <param name="QuestionaireId"></param>
        /// <param name="username">用户名</param>
        /// <returns>开始的问卷详情的id</returns>
        Guid BeginQuestionnaire(Guid QuestionaireId, string username);
        /// <summary>
        /// 学生开始教师派发的问卷
        /// </summary>
        /// <param name="questionnairedetailid"></param>
        void BeginQuestionnaireFromTeacher(Guid questionnairedetailid);
        /// <summary>
        /// 是否正在答卷状态
        /// </summary>
        /// <param name="username">用户名</param>
        /// <returns></returns>
        bool IsInAnswer(string username);
        /// <summary>
        /// 结束当前答卷
        /// </summary>
        /// <param name="QuestionnaireDetaiId"></param>
        /// <param name="score">最终得分，百分制</param>
        void StopQuestionnaire(Guid QuestionnaireDetaiId, float score);
        /// <summary>
        /// 根据详情ID获取详情dto
        /// </summary>
        /// <param name="QuestionnaireDetaiId"></param>
        /// <returns></returns>
        Dto.QuestionnaireDetailDto GetQuestionnaireDetail(Guid QuestionnaireDetaiId);
        /// <summary>
        /// 获取学生的所有答卷（教师专用）
        /// </summary>
        /// <param name="username">用户名</param>
        /// <returns></returns>
        List<Dto.QuestionnaireDetailDto> GetStudentQuestionnaireDetail(string username);
       
        /// <summary>
        /// 根据试卷id获得试卷所有题目dto的List
        /// </summary>
        /// <param name="QuestionnareId"></param>
        /// <returns></returns>
        List<Dto.QuestionDto> GetQuestionnaireQuestions(Guid QuestionnaireId);
        /// <summary>
        /// 获取学生没有做的问卷（来自老师）
        /// </summary>
        /// <param name="studentid"></param>
        /// <returns></returns>
        List<Dto.QuestionnaireDetailDto> GetStudentQuestionnaireDetailNotDone(Guid studentid);
    } // List<Dto.QuestionnaireDetailDto> GetClassQuestionnaireDetail(string classname);
}
