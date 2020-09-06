using LinkWomen.Data.Repositories;
using LinkWomen.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkWomen.Services.Services
{
    public class UserConnectionService : IUserConnectionService
    {
        private readonly IGenericRepository<UserConnection> _userConnectionRepository;

        public UserConnectionService(IGenericRepository<UserConnection> userConnectionRepository)
        {
            _userConnectionRepository = userConnectionRepository; 
        }

        public void Connect(int userId, int userToConnectId)
        {
            var connection = new UserConnection
            {
                UserHostId = userId,
                UserGuestId = userToConnectId
            };

            _userConnectionRepository.Add(connection); 
        }

        public void Disconnect(int userId, int userToDisconnectId)
        {
            var connection = _userConnectionRepository.GetAll()
                    .Where(x =>
                        (x.UserGuestId == userId || x.UserHostId == userId) &&
                        (x.UserGuestId == userToDisconnectId || x.UserHostId == userToDisconnectId))
                    .FirstOrDefault();

            _userConnectionRepository.Delete(connection); 
        }

        public IEnumerable<User> GetConnections(int userId)
        {
            var connectionsGuest = _userConnectionRepository.GetAll()
                    .Where(x => x.UserGuestId == userId)
                    .Select(x => x.UserHost);

            var connectionsHost = _userConnectionRepository.GetAll()
                    .Where(x => x.UserHostId == userId)
                    .Select(x => x.UserGuest);

            return connectionsGuest.Union(connectionsHost).Distinct().ToList(); 
        }
    }
}
