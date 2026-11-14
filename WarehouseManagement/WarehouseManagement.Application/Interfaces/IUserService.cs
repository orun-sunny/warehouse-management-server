using System;
using System.Collections.Generic;
using System.Text;

using WarehouseManagement.Application.Dtos;
namespace WarehouseManagement.Application.Interfaces
{
    public interface IUserService
    {
        UserDto CreateUser(CreateUserDto  createUserDto);
        UserDto UpdateUser(UpdateUserDto updateUserDto);
        UserDto DeleteUser(Guid userId);
        UserDto GetUser(Guid id);
        List<UserDto> GetAllUsers(List<Guid>? userIds);
    }
}
