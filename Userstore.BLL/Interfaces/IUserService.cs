using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Railway.BLL.DTO;
using Railway.BLL.Infrastructure;

namespace Railway.BLL.Interfaces
{
    public interface IUserService : IDisposable
    {
        Task<OperationDetails> Create(UserDTO userDto);
        Task<ClaimsIdentity> Authenticate(UserDTO userDto);
        Task SetInitialData(UserDTO adminDto, List<string> roles);
    } 
}
