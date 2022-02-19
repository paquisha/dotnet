using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVentas.library
{
    public class LUsersRoles
    {
        public List<SelectListItem> getRoles(RoleManager<IdentityRole> roleManager)
        {
            List<SelectListItem> _selectList = new List<SelectListItem>();
            var roles = roleManager.Roles.ToList();

            roles.ForEach(item =>
            {
                _selectList.Add(new SelectListItem
                {
                    Value = item.Id,
                    Text = item.Name
                });
            });
            return _selectList;
        }

        public static implicit operator UserManager<object>(LUsersRoles v)
        {
            throw new NotImplementedException();
        }
    }
}
