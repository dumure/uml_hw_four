using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uml_hw_four
{
    internal interface IUsersDatabase
    {
        public void Create(User user);
        public User Read(int id);
        public void Update(User user);
        public bool Delete(int id);
    }
}
