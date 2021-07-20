﻿using Domain.Contracts.User.Output;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infra.Interfaces
{
    public interface IUserRepository
    {
        Task<UserContract> GetUserByEmail(string email);
        Task<IEnumerable<UserContract>> GetUsers();
    }
}