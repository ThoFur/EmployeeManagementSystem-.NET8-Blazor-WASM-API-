using BaseLibrary.DTOs;
using BaseLibrary.Responses;
using CliëntLibrary.Services.Contracts;

namespace CliëntLibrary.Services.Implementations
{
    public class UserAccountService : IUserAccountService
    {
        public Task<GeneralResponse> CreateAsync(Register user)
        {
            throw new NotImplementedException();
        }

        public Task<LoginResponse> SignInAsync(Login user)
        {
            throw new NotImplementedException();
        }

        public Task<LoginResponse> RefreshTokenAsync(RefreshToken token)
        {
            throw new NotImplementedException();
        }

        
        public Task<WeatherForecast[]> GetWeatherForecast()
        {
            throw new NotImplementedException();
        }
    }
}
