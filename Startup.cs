﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Omnicanal.Database;
using Omnicanal.Models;

namespace Omnicanal
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public static void ConfigCookie(CookieAuthenticationOptions options)
        {
      //      options.LoginPath = "/Accesos/Ingresar"; // ruta relativa para login.
      //      options.AccessDeniedPath = "/Accesos/NoAutorizado"; // ruta relativa para accesos no autorizados por falta de permisos en el rol.
      //      options.LogoutPath = "/Accesos/Salir"; // ruta relativa para logout
            options.ExpireTimeSpan = new System.TimeSpan(1, 0, 0); // tiempo de permanencia logueado
            options.SlidingExpiration = true; // renuevo la cookie
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(ConfigCookie);
            services.AddControllersWithViews();
            services.AddDbContext<OmnicanalDbContext>(options => options.UseSqlite("filename = omnicanal.db"));
          
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
