using ProiectDAW.Data;
using ProiectDAW.Entities;
using ProiectDAW.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectDAW.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }

        public User GetByUserAndPassword(string username, string password)
        {
            return _table.Where(x => x.Username == username && x.Password == password).FirstOrDefault();
        }
    }
}
