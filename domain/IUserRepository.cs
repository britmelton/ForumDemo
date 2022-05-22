using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IUserRepository
    {
        public void Create(User user);
        public User Find(Guid id);
    }
}
