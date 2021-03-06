﻿using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using Railway.BLL.Services;
using Microsoft.AspNet.Identity;
using Railway.BLL.Interfaces;

[assembly: OwinStartup(typeof(Railway.App_Start.Startup))]

namespace Railway.App_Start
{
    public class Startup
    {
        IServiceCreator serviceCreator = new ServiceCreator();
        public void Configuration(IAppBuilder app)
        {
            app.CreatePerOwinContext<IUserService>(CreateUserService);
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login"),
            });
        }

        private IUserService CreateUserService()
        {
            return serviceCreator.CreateUserService("DefaultConnection");
        }
    }
}
