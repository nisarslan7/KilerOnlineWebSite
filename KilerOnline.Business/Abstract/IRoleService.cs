using KilerOnline.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilerOnline.Business.Abstract
{
	public interface IRoleService
	{
		List<Role> GetAllRoles();
		Role GetRoleById(int id);

		Role CreateRole(Role role);
		Role UpdateRole(Role role);

		void DeleteRole(int id);
	}
}
