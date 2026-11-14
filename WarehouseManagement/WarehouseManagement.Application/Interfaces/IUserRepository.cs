using System;
using System.Collections.Generic;
using System.Text;
using WarehouseManagement.Domain.Entities;

namespace WarehouseManagement.Application.Interfaces
{
    public interface IUserRepository
    {
        User AddUser(User user);
        User UpdateUser(User user);
        bool DeleteUser(Guid userId);
        User GetUserById(Guid userId);
        List<User> GetAllUsers(List<Guid>? UserIds);



    }
}
