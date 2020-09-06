using LinkWomen.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkWomen.Services.Services
{
    public interface IUserConnectionService
    {
        void Connect(int userId, int userToConnectId); 
        void Disconnect(int userId, int userToDisconnectId);
        IEnumerable<User> GetConnections(int userId); 
    }
}
