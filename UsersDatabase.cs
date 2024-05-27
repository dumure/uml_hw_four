using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uml_hw_four
{
    internal class UsersDatabase : IUsersDatabase
    {
        public void Create(User user)
        {
            Console.WriteLine("UsersDatabase::Create(User user)");
        }
        public User Read(int id)
        {
            Console.WriteLine("UsersDatabase::Read(int id)");
            return new User() { Id = id };
        }
        public void Update(User user)
        {
            Console.WriteLine("UsersDatabase::Update(User user)");
        }
        public bool Delete(int id)
        {
            Console.WriteLine("UsersDatabase::Delete(int id)");
            return true;
        }
    }
}
