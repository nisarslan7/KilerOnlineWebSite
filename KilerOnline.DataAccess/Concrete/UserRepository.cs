using KilerOnline.DataAccess.Abstract;
using KilerOnline.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilerOnline.DataAccess.Concrete
{
	public class UserRepository : IUserRepository
	{
		ApplicationDbContext _context;
		public UserRepository(ApplicationDbContext context)
		{
			_context = context;

		}
		public User CreateUser(User user)
		{
			_context.Users.Add(user);
			_context.SaveChanges();
			return user;
		}


		public void DeleteUser(int id)
		{
            var user = _context.Users.Find(id);
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user), "Kullanıcı bulunamadı");
            }

            _context.Users.Remove(user);
            _context.SaveChanges();
            
		}

        public User FindUser(LoginVM model)
        {
            var user = _context.Users.Where(x=> x.UserName == model.UserName && x.Password == model.Password).FirstOrDefault();
			return user;
        }

        public List<User> GetAllUsers()
		{
			return _context.Users.ToList();
		}

		public User GetUserById(int id)
		{
			return _context.Users.Find(id);
		}

		public User UpdateUser(User user)
		{
			_context.Users.Update(user);
			_context.SaveChanges();
			return user;
		}
	}
}
