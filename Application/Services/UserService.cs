using Application.DTOs.Users;
using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class UserService : IUserService
    {
        Task IUserService.CreateUser(CreateUserDTO userDTO)
        {
            throw new NotImplementedException();
        }

        Task IUserService.DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        Task<CreateUserDTO> IUserService.GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<CreateUserDTO>> IUserService.GetUsers()
        {
            throw new NotImplementedException();
        }

        Task IUserService.UpdateUser(CreateUserDTO userDTO)
        {
            throw new NotImplementedException();
        }
    }
}
