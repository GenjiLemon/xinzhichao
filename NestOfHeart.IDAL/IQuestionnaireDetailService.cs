using System;
using System.Collections.Generic;

namespace NestOfHeart.IDAL
{
    public interface IQuestionnaireDetailService:IBaseService<Model.QuestionnaireDetail>
    {
        List<Model.QuestionnaireDetail> GetListByStudentId(Guid studentid);
        /// <summary>
        /// 根据状态值和学生id获取学生detail
        /// </summary>
        /// <param name="studentid"></param>
        /// <param name="status">问卷状态，1，待做，2进行中 3已完成</param>
        /// <returns></returns>
        List<Model.QuestionnaireDetail> GetListByStudentIdStatus(Guid studentid, int status);
       
        
    }
}
