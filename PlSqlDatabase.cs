using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uml_hw_four
{
    internal class PlSqlDatabase
    {
        public void PushUser(User user)
        {
            Console.WriteLine("PlSqlDatabase::PushUser(User user)");
        }
        public User GetUser(int id)
        {
            Console.WriteLine("PlSqlDatabase::User GetUser(int id)");
            return new User() { Id = id };
        }
        public void Modify(object user)
        {
            Console.WriteLine("PlSqlDatabase::Modify(object user)");
        }
        public bool RemoveUser(int id)
        {
            Console.WriteLine("PlSqlDatabase::RemoveUser(int id)");
            return true;
        }
    }
}
