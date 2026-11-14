using System;
using System.Collections.Generic;
using System.Text;
using WarehouseManagement.Application.Dtos;
using WarehouseManagement.Application.Interfaces;
using WarehouseManagement.Domain.Entities;

namespace WarehouseManagement.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public UserDto CreateUser(CreateUserDto createUserDto)
        {
            var user = new User
            {
                Id = Guid.NewGuid(),
                UserName = createUserDto.UserName,
                Email = createUserDto.Email,
                CreatedAt = DateTime.UtcNow,
            };
           var createdUser = _userRepository.AddUser(user);
            return new UserDto
            {
                UserName = user.UserName,
                Email = user.Email,
            };
        }

        public UserDto DeleteUser(Guid userId)
        {
            throw new NotImplementedException();
        }

        public List<UserDto> GetAllUsers(List<Guid>? userIds)
        {
            throw new NotImplementedException();
        }

        public UserDto GetUser(Guid id)
        {
            throw new NotImplementedException();
        }

        public UserDto UpdateUser(UpdateUserDto updateUserDto)
        {
            throw new NotImplementedException();
        }
    }
}
