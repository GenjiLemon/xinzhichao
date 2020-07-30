using System;
using System.Collections.Generic;

namespace NestOfHeart.IDAL
{
    public interface IQuestionnaireService:IBaseService<Model.Questionnaire>
    {
        new Guid Add(Model.Questionnaire questionnaire);
        List<Model.Questionnaire> GetQuestionnairesByTypeid(int typeid);
    }
}
