using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using FluentValidation.AspNetCore;
using Application.Common.Interfaces;
using Application;
using Persistence;
using Infrastructure;
using WebUI.Common;
using WebUI.Services;

namespace WebUI
{
    public class Startup
    {
        private IServiceCollection _services;
        readonly string AllowAnyOrigin = "CorsPolicy";
        public IConfiguration Configuration { get; }
        public IWebHostEnvironment Environment { get; }

        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            Configuration = configuration;
            Environment = environment;
        }
        
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication();
            //services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddInfrastructure(Configuration, Environment);
            services.AddPersistence(Configuration);
            services.AddPersistenceServices();
            services.AddHealthChecks()
                .AddDbContextCheck<XOKADbContext>();
            services.AddScoped<ICurrentUserService, CurrentUserService>();
            services.AddHttpContextAccessor();
            services
                .AddControllersWithViews()
                .AddNewtonsoftJson()
                .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<IXOKADbContext>());
           
            // Customise default API behaviour
            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });          
            services.AddOpenApiDocument(configure =>
            {
                configure.Title = "jobAPI";
            });

            _services = services;

            services.AddCors(options =>
            {
                options.AddPolicy(AllowAnyOrigin,
                builder =>
                {
                    builder.AllowAnyOrigin()
                    .AllowAnyMethod()
               .AllowAnyHeader();
                });
            });
            services.AddMvc(option => option.EnableEndpointRouting = false).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
     

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            if (Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseCustomExceptionHandler();
            app.UseHealthChecks("/health");
            app.UseCors(AllowAnyOrigin);
            //app.UseHttpsRedirection();
            app.UseOpenApi();
            app.UseSwaggerUi3(settings =>
            {
                settings.Path = "/api";
                //    settings.DocumentPath = "/api/specification.json";   Enable when NSwag.MSBuild is upgraded to .NET Core 3.0
            });

            app.UseRouting();
          // app.UseAuthentication();
            //app.UseAuthorization();
            app.UseMvc();
        }
    }
}
