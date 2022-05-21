﻿using Domain;
using DomainUser = Domain.User;

namespace infrastructure
{
    public class UserRepository : IUserRepository
    {
        private readonly Context context;

        public UserRepository(Context context)
        {
            this.context = context;
        }
        public void Create(DomainUser user)
        {
            var dbUser = new User(user);
            context.User.Add(dbUser);
            context.SaveChanges();
            
        }

        public DomainUser Find(Guid id)
        {
            User user = context.User.Find(id);
            var domainUser = new DomainUser(user.Username, user.Password, user.Birthday, user.Id);
            return domainUser;

        }
    }
}
