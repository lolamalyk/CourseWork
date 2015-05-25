using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.BOL.Entity;

namespace ToDo.DAL.Abstract
{
    public interface ICaseRepository
    {
        void Create(Case e);

        void Edit(int id);

        void Delete(int id);

        void Save();

        Case GetById(int id);

        IEnumerable<Case> GetAll();
    }
}
