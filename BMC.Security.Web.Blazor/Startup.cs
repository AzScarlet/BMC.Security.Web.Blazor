using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BMC.Security.Web.Blazor.Data;
using BMC.Security.Tools;
using Blazored.Toast;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Net.Http;

namespace BMC.Security.Web.Blazor
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            AppConstants.BlobConString = Configuration["ConnectionStrings:BlobConString"];
            AppConstants.IoTCon = Configuration["ConnectionStrings:IoTCon"];
            MqttInfo.MqttHost = Configuration["MqttInfo:MqttHost"];
            MqttInfo.MqttUser = Configuration["MqttInfo:MqttUser"];
            MqttInfo.MqttPass = Configuration["MqttInfo:MqttPass"];
            AppConstants.AdminAccounts = Configuration.GetSection("AdminAccount").Get<List<Account>>();

            services.AddBlazoredLocalStorage();
            services.AddRazorPages();
            services.AddBlazoredToast();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();

            // ******
            // BLAZOR COOKIE Auth Code (begin)
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddAuthentication(
                CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie();
            // BLAZOR COOKIE Auth Code (end)
            // ******
            // ******
            // BLAZOR COOKIE Auth Code (begin)
            // From: https://github.com/aspnet/Blazor/issues/1554
            // HttpContextAccessor
            services.AddHttpContextAccessor();
            services.AddScoped<HttpContextAccessor>();
            services.AddHttpClient();
            services.AddScoped<HttpClient>();

            // BLAZOR COOKIE Auth Code (end)
            // ******
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            // ******
            // BLAZOR COOKIE Auth Code (begin)
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();
            // BLAZOR COOKIE Auth Code (end)
            // ******

            app.UseEndpoints(endpoints =>
            {                
                // BLAZOR COOKIE Auth Code (begin)
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
                // BLAZOR COOKIE Auth Code (end)
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
