using KilerOnline.Business.Abstract;
using KilerOnline.DataAccess.Abstract;
using KilerOnline.DataAccess.Concrete;
using KilerOnline.Entities.Abstact;
using KilerOnline.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KilerOnline.Business.Concrete
{
	public class UserManager : IUserService
	{
		private IUserRepository _userRepository;
		public UserManager(IUserRepository userRepository)
		{
			_userRepository = userRepository;
		}
		public User CreateUser(User user)
		{
			return _userRepository.CreateUser(user);
		}

		public void DeleteUser(int id)
		{
                _userRepository.DeleteUser(id);
            
            
		}

        public User FindUser(LoginVM model)
        {
            return _userRepository.FindUser(model);
        }

        public List<User> GetAllUsers()
		{
			return _userRepository.GetAllUsers();
		}

		public User GetUserById(int id)
		{
			if (id > 0)
			{
				return _userRepository.GetUserById(id);
			}
			throw new Exception("Id 0'dan büyük olmalı");
		}

		public User UpdateUser(User user)
		{
			return _userRepository.UpdateUser(user);
		}
	}
}
