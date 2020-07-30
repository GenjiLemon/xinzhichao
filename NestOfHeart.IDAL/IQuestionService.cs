using System;
using System.Collections.Generic;

namespace NestOfHeart.IDAL
{
    public interface IQuestionService:IBaseService<Model.Question>
    {
        List<Model.Question> GetQuestionsByQuestionnaireIdOrder(Guid QuestionnaireId);
    }
}
