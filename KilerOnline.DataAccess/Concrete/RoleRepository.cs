using KilerOnline.DataAccess.Abstract;
using KilerOnline.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilerOnline.DataAccess.Concrete
{
	public class RoleRepository : IRoleRepository
	{
		ApplicationDbContext _context;
		public RoleRepository(ApplicationDbContext context)
		{
			_context = context;

		}
		public Role CreateRole(Role role)
		{
			_context.Roles.Add(role);
			_context.SaveChanges();
			return role;
		}

		public void DeleteRole(int id)
		{
			var role = GetRoleById(id);
			_context.Roles.Remove(role);
			_context.SaveChanges();

		}

		public List<Role> GetAllRoles()
		{
			return _context.Roles.ToList();
		}

		public Role GetRoleById(int id)
		{
			return _context.Roles.Find(id);
		}

		public Role UpdateRole(Role role)
		{
			_context.Roles.Update(role);
			_context.SaveChanges();
			return role;
		}
	}
}
