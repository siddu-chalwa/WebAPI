using ClientEight.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
namespace ClientEight
{
    /// <summary>
    /// class startup: build and configure webhost, initialize dependency injuction
    /// </summary>
    public class Startup
    {
        private IConfiguration _configuration;
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        /// <summary>
        /// function: configure the services
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<DbContextClass>(options => options.UseSqlServer(_configuration.GetConnectionString("UserDBConnection")));
            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddScoped<IUser, MUser>();
        }
        /// <summary>
        /// function: configure middleware
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseMvc();
        }
    }
}
