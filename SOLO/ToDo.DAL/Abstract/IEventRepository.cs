using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.BOL.Entity;

namespace ToDo.DAL.Abstract
{
    public interface IEventRepository
    {
        void Create(Event e);

        void Edit(int id);

        void Delete(int id);

        void Save();

        Event GetById(int id);

        IEnumerable<Event> GetAll();
    }
}