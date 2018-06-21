using KubeClient;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MinecraftWeb.Infrastructure;
using Swashbuckle.AspNetCore.Swagger;
using System;

namespace MinecraftWeb
{
    public class Startup
    {
        private IConfigurationRoot Configuration { get; }
        private IHostingEnvironment Env { get; }
        private ILoggerFactory LoggerFactory { get; }

        public Startup(IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            var configurationBuilder = new ConfigurationBuilder()
               .SetBasePath(env.ContentRootPath)
               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
               .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
               .AddEnvironmentVariables();

            Configuration = configurationBuilder.Build();
            Env = env;
            LoggerFactory = loggerFactory;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // MVC
            services.AddMvc();

            // Compression
            services.Configure<GzipCompressionProviderOptions>(options => options.Level = System.IO.Compression.CompressionLevel.Optimal);
            services.AddResponseCompression();

            // Cors
            services.AddCors();

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "Minecraft Web API", Version = "v1" });
            });

            // Add Configuration
            services.AddSingleton<IConfiguration>(Configuration);

            //KubeClientOptions clientOptions = new KubeClientOptions
            //{
            //    ApiEndPoint = new Uri("https://giovani-ak-giovani-rg-7d80c4-f673b008.hcp.australiaeast.azmk8s.io"),
            //    AllowInsecure = true,
            //    AccessToken = "834d9e839b05d8a9acbdcee7c37095ec"
            //};

            //if (!Env.IsDevelopment())
            //    clientOptions = K8sConfig.Load().ToKubeClientOptions();

            //services.AddSingleton(clientOptions);
            //services.AddSingleton(KubeApiClient.Create(clientOptions, LoggerFactory));

            //services.AddNamedKubeClients();
            //services.AddKubeClient(clientOptions);

            services.AddSingleton(new MineKubeApiClient("https://giovani-ak-giovani-rg-7d80c4-f673b008.hcp.australiaeast.azmk8s.io", "834d9e839b05d8a9acbdcee7c37095ec"));
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(
            IApplicationBuilder app,
            ILoggerFactory loggerFactory,
            IServiceProvider serviceProvider,
            IApplicationLifetime applicationLifetime)
        {
            loggerFactory.AddConsole();

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Minecraft Web API v1");
                c.RoutePrefix = string.Empty;
            });

            // Write Log on Console
            loggerFactory.AddConsole();

            // Apply Compression
            app.UseResponseCompression();

            // Enable Cors * * * 
            app.UseCors(x =>
            {
                x.AllowAnyHeader();
                x.AllowAnyMethod();
                x.AllowAnyOrigin();
            });

            app.UseMvc();
        }
    }
}
