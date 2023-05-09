using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.DataAccessLayer.Entities;

namespace ToDoApp.DataAccessLayer.Auth
{
    internal class AuthRepository : IAuthRepository
    {
        private readonly DataContext _context;
        public AuthRepository(DataContext context)
        {
            _context = context;
        }
        public Task<string> Login(string userName, string password)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Register(User user, string password)
        {
            //Controlla se lo User esiste, andrebbe implementata una ServiceResponse
            if(await UserExists(user.Username))
            {
                return 0;
            }

            //Crea una password criptata e la assegna allo user
            CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);
            user.PasswordSalt = passwordSalt;
            user.PasswordHash = passwordHash;

            //Aggiunge lo user nel DB e salva i cambiamenti
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return user.Id;
            
        }

        public async Task<bool> UserExists(string userName)
        {
            if(await _context.Users.AnyAsync(u => u.Username.ToLower() == userName.ToLower()))
                return true;

            return false;
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using(var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}
