using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.BOL.Entity;

namespace ToDo.DAL.Abstract
{
    public interface INoteRepository
    {
        void Create(Note e);

        void Edit(int id);

        void Delete(int id);

        void Save();

        Note GetById(int id);

        IEnumerable<Note> GetAll();
    }
}
