using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.Owin.Security.OAuth;
using System.Security.Claims;
using TejeratBankReporting.Core;
using Castle.Windsor;
using Castle.MicroKernel.Registration;
using Castle.Windsor.Installer;
using Castle.MicroKernel.Handlers;
using System.Collections.Concurrent;
using Castle.Core;
using Castle.MicroKernel.Context;
using System.Reflection;
using TejeratBankReporting.Dependency;
using Castle.MicroKernel.SubSystems.Configuration;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.AspNet.Identity.Owin;
using System.Security.Cryptography;

namespace TejeratBankReporting.Web
{


    public class MyAutorizeServerProvider : OAuthAuthorizationServerProvider
    {
        private readonly string _publicClientId;
        //private readonly ICartService _cartService;
        //private readonly IAddressService _addressService;
        public MyAutorizeServerProvider(string publicClientId)
        {
            if (publicClientId == null)
            {
                throw new ArgumentNullException("publicClientId");
            }
            _publicClientId = publicClientId;
         
        }
        public override Task TokenEndpoint(OAuthTokenEndpointContext context)
        {
            var identity = (ClaimsIdentity)context.Identity;
            foreach (KeyValuePair<string, string> property in context.Properties.Dictionary)
            {
                context.AdditionalResponseParameters.Add(property.Key, property.Value);
            }

            return Task.FromResult<object>(null);
        }
        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            var userManager = context.OwinContext.GetUserManager<ApplicationUserManager>();

            ApplicationUser user = await userManager.FindAsync(context.UserName, context.Password);

            if (user == null)
            {
                context.SetError("invalid_grant", "نام کاربری یا کلمه عبور اشتباه می باشد.");
                return;
            }

            ClaimsIdentity oAuthIdentity = await user.GenerateUserIdentityAsync(userManager,
               OAuthDefaults.AuthenticationType);
            ClaimsIdentity cookiesIdentity = await user.GenerateUserIdentityAsync(userManager,
                CookieAuthenticationDefaults.AuthenticationType);
       
            var Gallery =string.Format("{0}", user.Id*999+10444);
            List<Claim> roles = oAuthIdentity.Claims.Where(c => c.Type == ClaimTypes.Role).ToList();
            var data = await context.Request.ReadFormAsync();
            if (string.IsNullOrEmpty( data[""]))
            {

            }    
            //_cartService.Insert(context.)
            //var Carts = Newtonsoft.Json.JsonConvert.SerializeObject(_cartService.Get(new AppUser { Id = user.Id }).ToList());
            //var Addresses = Newtonsoft.Json.JsonConvert.SerializeObject(_addressService.List(user.Id).ToList());

            AuthenticationProperties properties = CreateProperties(user.UserName, Gallery, Newtonsoft.Json.JsonConvert.SerializeObject(roles.Select(x => x.Value)), user.Name);

            //AuthenticationProperties properties = CreateProperties(user.UserName);
            AuthenticationTicket ticket = new AuthenticationTicket(oAuthIdentity, properties);
            context.Validated(ticket);
            context.Request.Context.Authentication.SignIn(cookiesIdentity);
        }

        //public override Task TokenEndpoint(OAuthTokenEndpointContext context)
        //{
        //    foreach (KeyValuePair<string, string> property in context.Properties.Dictionary)
        //    {
        //        context.AdditionalResponseParameters.Add(property.Key, property.Value);
        //    }

        //    return Task.FromResult<object>(null);
        //}

        public override Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            // Resource owner password credentials does not provide a client ID.
            if (context.ClientId == null)
            {
                context.Validated();
            }

            return Task.FromResult<object>(null);
        }

        public override Task ValidateClientRedirectUri(OAuthValidateClientRedirectUriContext context)
        {
            if (context.ClientId == _publicClientId)
            {
                Uri expectedRootUri = new Uri(context.Request.Uri, "/");

                if (expectedRootUri.AbsoluteUri == context.RedirectUri)
                {
                    context.Validated();
                }
            }

            return Task.FromResult<object>(null);
        }

        public static AuthenticationProperties CreateProperties(string userName, string Gallery, string Roles, string name)
        {
            IDictionary<string, string> data = new Dictionary<string, string>
            {
                { "userName", userName },
                    {"gallery",Gallery},
                   {"roles",Roles},
               
                       {"name",name},
            };
            return new AuthenticationProperties(data);
        }


        //private  IWindsorContainer _windsorContainer;
        //private IUserService _userService;
        //public MyAutorizeServerProvider(IUserService userService)
        //{
        //    _userService = userService;
        //}


        //public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        //{
        //    context.Validated();
        //}
        //public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        //{

        //    var identity = new ClaimsIdentity(context.Options.AuthenticationType);
        //    var user = _userService.Get(context.UserName, context.Password);
        //    if (user!=null)
        //    {
        //        ////identity.AddClaim(new Claim(ClaimTypes.Role, user.UserInRoles.));
        //        //identity.AddClaim(new Claim("username", "admin"));
        //        //identity.AddClaim(new Claim("brand", "novin"));
        //        identity.AddClaim(new Claim(ClaimTypes.Name, user.Name));
        //        identity.AddClaim(new Claim(ClaimTypes.Gender, user.Gender.ToString()));
        //        identity.AddClaim(new Claim(ClaimTypes.Email, user.Email));
        //        context.Validated(identity);
        //    }
        //    else
        //    {
        //        context.SetError("error", "error");
        //        return;
        //    }
        //}


    }
}