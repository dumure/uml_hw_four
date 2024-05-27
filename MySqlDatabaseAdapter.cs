using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uml_hw_four
{
    internal class MySqlDatabaseAdapter : IUsersDatabase
    {
        private readonly MySqlDatabase _database;
        public MySqlDatabaseAdapter(MySqlDatabase database)
        {
            _database = database;
        }
        public void Create(User user)
        {
            _database.InsertUser(user);
        }

        public bool Delete(int id)
        {
            return _database.RemoveUser(id);
        }

        public User Read(int id)
        {
            return _database.GetUserById(id);
        }

        public void Update(User user)
        {
            _database.Update(user);
        }
    }
}
