using ProductApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        public Task CreateAsync(User entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAync(int id)
        {
            throw new NotImplementedException();
        }

        public User? Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<User?> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IList<User?>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public IList<User> GetAllWithPredicate(Expression<Func<User, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<User?> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
