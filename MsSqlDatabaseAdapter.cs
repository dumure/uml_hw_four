using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uml_hw_four
{
    internal class MsSqlDatabaseAdapter : IUsersDatabase
    {
        private readonly MsSqlDatabase _database;
        public MsSqlDatabaseAdapter(MsSqlDatabase database)
        {
            _database = database;
        }
        public void Create(User user)
        {
            _database.InsertUser(user);
        }

        public bool Delete(int id)
        {
            return _database.DeleteUser(id);
        }

        public User Read(int id)
        {
            return _database.FetchUser(id);
        }

        public void Update(User user)
        {
            _database.Modify(user);
        }
    }
}
