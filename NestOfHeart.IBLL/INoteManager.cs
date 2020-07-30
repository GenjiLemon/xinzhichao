using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestOfHeart.IBLL
{
    public interface INoteManager
    {
        void AddNote(string username, string content, int permission);
        List<Dto.NoteDto> GetAllNote();
        List<Dto.NoteDto> GetUserNote(string username);
        List<Dto.NoteDto> GetPermissionNote(string username);
        
    }
}
