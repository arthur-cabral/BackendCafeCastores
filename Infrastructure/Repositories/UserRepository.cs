using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        Task<User> IUserRepository.CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        Task IUserRepository.DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        Task<User> IUserRepository.GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<User>> IUserRepository.GetUsers()
        {
            throw new NotImplementedException();
        }

        Task<User> IUserRepository.UpdateUser(int id, User user)
        {
            throw new NotImplementedException();
        }
    }
}
