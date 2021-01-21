using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using ProiectDAW.Entities;
using ProiectDAW.IRepositories;
using ProiectDAW.IServices;
using ProiectDAW.Mappers;
using ProiectDAW.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ProiectDAW.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepostiory;
        private readonly AppSettings _appSettings;

        public UserService(IUserRepository userRepository, IOptions<AppSettings> appSettings)
        {
            this._userRepostiory = userRepository;
            this._appSettings = appSettings.Value;
        }

        public bool Register(AuthenticationRequest request)
        {
            var entity = request.ToUserExtension(Enums.UserTypeEnum.NormalUser);

            _userRepostiory.Create(entity);
            return _userRepostiory.SaveChanges();
        }

        public List<User> GetAll()
        {
            return _userRepostiory.GetAllActive();
        }

        public User GetById(int id)
        {
            return _userRepostiory.FindById(id);
        }

        public AuthenticationResponse Login(AuthenticationRequest request)
        {
            // find user
            var user = _userRepostiory.GetByUserAndPassword(request.Username, request.Password);
            if (user == null)
                return null;

            // attach token
            var token = GenerateJwtForUser(user);

            // return user & token
            return new AuthenticationResponse
            {
                Id = user.Id,
                Username = user.Username,
                Type = user.Type,
                Token = token
            };
        }

        private string GenerateJwtForUser(User user)
        {
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new System.Security.Claims.ClaimsIdentity(new[] { new Claim("id", user.Id.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
