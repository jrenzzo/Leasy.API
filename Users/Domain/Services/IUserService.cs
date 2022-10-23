﻿using Leasy.API.Users.Domain.Models;
using Leasy.API.Users.Domain.Services.Communication;

namespace Leasy.API.Users.Domain.Services;

public interface IUserService
{
    Task<IEnumerable<User>> ListAsync();
    Task<User> GetByIdAsync(int id);
    Task DeleteAsync(int id);
    
    //three are missing and will be implemented with security features
}