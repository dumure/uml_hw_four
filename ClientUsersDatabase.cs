using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uml_hw_four
{
    internal class ClientUsersDatabase
    {
        private IUsersDatabase _database;
        public ClientUsersDatabase(IUsersDatabase database)
        {
            _database = database;
        }
        public void Create(User user)
        {
            _database.Create(user);
        }
        public User Read(int id)
        {
            return _database.Read(id);
        }
        public void Update(User user)
        {
            _database.Update(user);
        }
        public bool Delete(int id)
        {
            return _database.Delete(id);
        }
    }
}
