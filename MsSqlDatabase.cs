using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uml_hw_four
{
    internal class MsSqlDatabase
    {
        public void InsertUser(User user)
        {
            Console.WriteLine("MsSqlDatabase::InsertUser(User user)");
        }
        public User FetchUser(int id)
        {
            Console.WriteLine("MsSqlDatabase::InsertUser(User user)");
            return new User() { Id = id };
        }
        public void Modify(User user)
        {
            Console.WriteLine("MsSqlDatabase::Modify(User user)");
        }
        public bool DeleteUser(int id)
        {
            Console.WriteLine("MsSqlDatabase::DeleteUser(int id)");
            return true;
        }
    };
}
