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
        ///  类型：1学生自主，2老师选用，3都在
        /// </summary>
        /// <param name="type">
       
        Guid AddQuestionnair(string name, string brief,int type);
        void AddQuestion(Guid questionnaireid, int order, string title, string choice, int type);
        Dto.QuestionnaireDto GetQuestionnaire(Guid QuestionnaireId);
        List<Dto.QuestionnaireDto> GetTeacherQuestionnaireList();
        List<Dto.QuestionnaireDto> GetStudentQuestionnaireList();
        Guid BeginQuestionnaire(Guid QuestionaireId, string username);//返回QuestionnaireDetaiId
        void BeginQuestionnaireFromTeacher(Guid questionnairedetailid);
        bool IsInAnswer(string username);
        void StopQuestionnaire(Guid QuestionnaireDetaiId, float score);
        Dto.QuestionnaireDetailDto GetQuestionnaireDetail(Guid QuestionnaireDetaiId);
        List<Dto.QuestionnaireDetailDto> GetStudentQuestionnaireDetail(string username);
       // List<Dto.QuestionnaireDetailDto> GetClassQuestionnaireDetail(string classname);
    }
}
