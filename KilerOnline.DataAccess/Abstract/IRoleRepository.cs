using KilerOnline.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace KilerOnline.DataAccess.Abstract
{
	public interface IRoleRepository
	{
		List<Role> GetAllRoles();
		Role GetRoleById(int id);

		Role CreateRole(Role role);
		Role UpdateRole(Role role);

		void DeleteRole(int id);
	}
}
