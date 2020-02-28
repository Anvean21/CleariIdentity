using Railway.DAL.Entities;
using System;

namespace Railway.DAL.Interfaces
{
    public interface IClientManager:IDisposable
    {
        void Create(ClientProfile item);
    }
}
