using System.Security.Claims;
using System.Security.Principal;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using Slk.Web.Models;
using Slk.Models;

namespace Slk.Web.Helpers
{
    public class SignInHelper
    {
        private readonly IAuthenticationManager authenticationManager;

        public SignInHelper(IAuthenticationManager authenticationManager)
        {
            this.authenticationManager = authenticationManager;
        }

        public void SignIn(User usr, bool rememberMe, bool isPersistent = false)
        {
            authenticationManager.SignOut(DefaultAuthenticationTypes.ExternalCookie, DefaultAuthenticationTypes.TwoFactorCookie);

            var identity = new ClaimsIdentity(DefaultAuthenticationTypes.ApplicationCookie);
            identity.AddClaim(new Claim(ClaimTypes.Email, usr.Email));
            identity.AddClaim(new Claim(ClaimTypes.Name, usr.ToString()));
            identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, usr.Id.ToString()));

            if (rememberMe)
            {
                var rememberBrowserIdentity =
                    authenticationManager.CreateTwoFactorRememberBrowserIdentity(usr.Email);

                authenticationManager.SignIn(
                    new AuthenticationProperties { IsPersistent = isPersistent },
                    identity,
                    rememberBrowserIdentity);
            }
            else
            {
                authenticationManager.SignIn(
                    new AuthenticationProperties { IsPersistent = isPersistent },
                    identity);
            }
        }

        public void SignOut()
        {
            authenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            //authenticationManager.SignOut();
        }
    }
}

