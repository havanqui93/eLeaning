using System;
using eLearning.API.DTOs.User;

namespace eLearning.API.Services.Interfaces
{
	public interface IUserService
	{
		Task<LoginResponse> LoginUserAsync(LoginRequest request);

		Task<RegisterResponse> RegisterUserAsync(RegisterRequest request);
	}
}

