using System;
using System.Collections.Generic;

namespace NestOfHeart.IDAL
{
    public interface IQuestionnaireDetailService:IBaseService<Model.QuestionnaireDetail>
    {
        List<Model.QuestionnaireDetail> GetListByStudentId(Guid studentid);
        List<Model.QuestionnaireDetail> GetListByStudentIdStatus(Guid studentid, int status);
       
        
    }
}
