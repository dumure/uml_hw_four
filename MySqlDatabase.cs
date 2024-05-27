using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uml_hw_four
{
    internal class MySqlDatabase
    {
        public void InsertUser(User user)
        {
            Console.WriteLine("MySqlDatabase::InsertUser(User user)");
        }
        public User GetUserById(int id)
        {
            Console.WriteLine("MySqlDatabase::GetUserById(int id)");
            return new User() { Id = id };
        }
        public void Update(User user)
        {
            Console.WriteLine("MySqlDatabase::Update(User user)");
        }
        public bool RemoveUser(int id)
        {
            Console.WriteLine("MySqlDatabase::RemoveUser(int id)");
            return true;
        }
    }
}
