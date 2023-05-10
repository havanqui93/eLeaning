using System;
using eLeaning.Infrastructure.Data.Repository;
using eLearning.API.DTOs.User;
using eLearning.API.Services.Interfaces;
using eLearning.Domain.Entities;
using eLearning.Domain.Interfaces;
using Shared.API;
using Shared.API.Model;

namespace eLearning.API.Services
{
	public class UserService : BaseService, IUserService
	{
        private readonly ILogger<UserService> _logger;

        public UserService(IUnitOfWork unitOfWork, ILogger<UserService> logger) : base(unitOfWork)
        {
            _logger = logger;
        }


		public async Task<RegisterResponse> RegisterUserAsync(RegisterRequest request) {

            // 1. Create new instance repository
            var userRespos = UnitOfWork.RepositoryAsync<User>();

            var existUser = await userRespos.GetAsync(x => x.Email.Equals(request.Email));

            if(existUser != null) {
                _logger.LogError("User already exists!");
                return new RegisterResponse() { IsSuccess = false, UserId = existUser.Id };
                // Sample response
                // return Response(false, "User already exists!"); 
            }

            var user = new User() {
                Email = request.Email,
                Password = request.Password, // need to encode.
                FirstName = request.FirstName,
                LastName = request.LastName,
                PhoneNumber = request.PhoneNumber,
                IsActive = true,
                RoleId = 2
            };

            // 2. Add new user
            await userRespos.AddAsync(user);

            // 3. Save trasaction
            var result = await UnitOfWork.SaveChangesAsync();

            if(result > 0) {
                return new RegisterResponse() { IsSuccess = true, UserId = user.Id };
            }

            return new RegisterResponse() { IsSuccess = false };
        }

        public async Task<LoginResponse> LoginUserAsync(LoginRequest request)
        {
            LoginResponse loginResponse = new LoginResponse();

            var userRespos = UnitOfWork.RepositoryAsync<User>();

            // Endcode password and comparasion

            var user = userRespos.GetAsync(x => x.Email.Equals(request.Email) && x.Password.Equals(request.Password));

            if(user == null) {
                _logger.LogError("Wrong username or password!");
                return null;
            }

            // Generate token

            return loginResponse;
        }
    }
}

