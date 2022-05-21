using Domain;
using DomainUser = Domain.User;

namespace infrastructure
{
    public class UserRepository : IUserRepository
    {
        public void Create(DomainUser user)
        {
            throw new NotImplementedException();
        }

        public DomainUser Find(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
