using Microsoft.AspNetCore.Identity;
using OnSale.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnSale.Web.Helpers
{
    public interface IUserHelper
    {
        // Get the user by the email, return 
        Task<User> GetUserAsync(string email);

        // Add the user given a user and a password.
        // Return 
        Task<IdentityResult> AddUserAsync(User user, string password);

        // Check the role.
        Task CheckRoleAsync(string roleName);

        // Add role to a user.
        Task AddUserToRoleAsync(User user, string roleName);

        // Check is a user has the role.
        // Return boolean
        Task<bool> IsUserInRoleAsync(User user, string roleName);
    }

}
