﻿using KilerOnline.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KilerOnline.DataAccess.Abstract
{
	public interface IUserRepository
	{
		List<User> GetAllUsers();
		User GetUserById(int id);

		User CreateUser(User user);
		User UpdateUser(User user);

		void DeleteUser(int id);
        User FindUser(LoginVM model);
    }
}
