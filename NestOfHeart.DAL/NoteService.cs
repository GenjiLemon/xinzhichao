using System;
using System.Collections.Generic;
using System.Linq;
using NestOfHeart.Model;
namespace NestOfHeart.DAL
{
    public class NoteService : BaseService<Model.Note>, IDAL.INoteService
    {
        public NoteService(dbContext db) : base(db)
        {
        }
        public NoteService() { }

        public List<Note> GetPublicNote()
        {
            return GetAllOrder().Where(m => m.Permission == 1).ToList();
        }

        public List<Note> GetStudentNote(Guid studentid)
        {
            return GetAllOrder().Where(m => m.StudentId == studentid).ToList();
        }
    }
}