using NestOfHeart.Model;
using System;
using System.Collections.Generic;

namespace NestOfHeart.IDAL
{
    public interface INoteService:IBaseService<Model.Note>
    {
        List<Note> GetPublicNote();
        List<Note> GetStudentNote(Guid studentid);
    }
}
