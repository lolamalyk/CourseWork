using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.BOL.Entity;

namespace ToDo.DAL.Abstract
{
    public interface IUserRepository
    {
        void Create(User e);

        void Edit(int id);

        void Delete(int id);

        void Save();

        User GetById(int id);

        IEnumerable<User> GetAll();
    }
}
