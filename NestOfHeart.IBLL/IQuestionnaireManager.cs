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
        List<Dto.QuestionDto> GetQuestionList(int type);
        void AddQuestionnair(Dto.QuestionnaireDto questionnair);
        Dto.QuestionnaireDto Questionnaire(Guid QuestionId);
        Guid BeginQuestionnaire(Guid QuestionId);//返回QuestionnaireDetaiId
        bool IsInAnswer(string username);
        void StartQuestionnaire(Guid QuestionnaireDetaiId);
        Dto.QuestionnaireDetailDto GetQuestionnaireDetail(Guid QuestionnaireDetaiId);
        List<Dto.QuestionnaireDetailDto> GetStudentQuestionnaireDetail(string username);
        List<Dto.QuestionnaireDetailDto> GetClassQuestionnaireDetail(string classname);
    }
}
