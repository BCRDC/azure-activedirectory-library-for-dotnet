using Microsoft.Identity.Core;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace BCRDC.Aad
{
    /// <summary>
    /// Credential used for username/password authentication.
    /// </summary>
    public sealed class UserPasswordCredential : UserCredential
    {
        internal UsernamePasswordInput UserPasswordInput { get; }

        /// <summary>
        /// Constructor to create credential with username and password
        /// </summary>
        /// <param name="userName">Identifier of the user application requests token on behalf.</param>
        /// <param name="password">User password.</param>
        public UserPasswordCredential(string userName, string password)
        {
            UserPasswordInput = new UsernamePasswordInput(userName, password);

        }

        /// <summary>
        /// Constructor to create credential with username and password
        /// </summary>
        /// <param name="userName">Identifier of the user application requests token on behalf.</param>
        /// <param name="securePassword">User password.</param>
        //public UserPasswordCredential(string userName, SecureString securePassword)
        //{
        //    UserPasswordInput = new UsernamePasswordInput(userName, securePassword);
        //}
    }
}
