using KilerOnline.Business.Abstract;
using KilerOnline.DataAccess.Abstract;
using KilerOnline.DataAccess.Concrete;
using KilerOnline.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilerOnline.Business.Concrete
{
	public class RoleManager : IRoleService
	{
		private IRoleRepository _roleRepository;
		public RoleManager(IRoleRepository roleRepository)
		{
			_roleRepository = roleRepository;
		}
		public Role CreateRole(Role role)
		{
			return _roleRepository.CreateRole(role);
		}

		public void DeleteRole(int id)
		{
			_roleRepository.DeleteRole(id);
		}

		public List<Role> GetAllRoles()
		{
			return _roleRepository.GetAllRoles();
		}

		public Role GetRoleById(int id)
		{
			if (id > 0)
			{
				return _roleRepository.GetRoleById(id);
			}
			throw new Exception("Id 0'dan büyük olmalı");
		}

		public Role UpdateRole(Role role)
		{
			return _roleRepository.UpdateRole(role);
		}
	}
}
