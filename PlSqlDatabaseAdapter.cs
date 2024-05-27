using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uml_hw_four
{
    internal class PlSqlDatabaseAdapter : IUsersDatabase
    {
        private readonly PlSqlDatabase _database;
        public PlSqlDatabaseAdapter(PlSqlDatabase database) 
        {
            _database = database;
        }
        public void Create(User user)
        {
            _database.PushUser(user);
        }

        public bool Delete(int id)
        {
            return _database.RemoveUser(id);
        }

        public User Read(int id)
        {
            return _database.GetUser(id);
        }

        public void Update(User user)
        {
            _database.Modify(user);
        }
    }
}
