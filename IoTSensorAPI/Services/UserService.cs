using IoTSensorAPI.Entities;
using IoTSensorAPI.Repository;

namespace IoTSensorAPI.Services
{
    public class UserService
    {
        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> CreateUser(User user)
        {
            return await _userRepository.CreateUser(user);
        }
    }
}
