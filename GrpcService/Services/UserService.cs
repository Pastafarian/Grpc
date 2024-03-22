using Grpc.Core;

namespace GrpcService.Services
{
    public class UserService : User.UserBase
    {
        private readonly ILogger<UserService> _logger;
        public UserService(ILogger<UserService> logger)
        {
            _logger = logger;
        }

        public override Task<UserResponse> GetUserById(GetUserByIdRequest request, ServerCallContext context)
        {
            return Task.FromResult(new UserResponse
            {
                Id = request.Id,
                FirstName = "User " + request.Id,
                Email = "user" + request.Id + "@example.com"
            });
        }
    }
}
