using Application.DTOs.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<CreateUserDTO>> GetUsers();
        Task<CreateUserDTO> GetUserById(int id);
        Task CreateUser(CreateUserDTO userDTO);
        Task UpdateUser(CreateUserDTO userDTO);
        Task DeleteUser(int id);
    }
}
