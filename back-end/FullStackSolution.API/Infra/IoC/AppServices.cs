using FullStackSolution.API.Infra.Swagger;
using FullStackSolution.Domain.Services;
using FullStackSolution.Infra.Mappers.FullStackSolutionProfile;
using FullStackSolution.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.PlatformAbstractions;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.IO;
using System.Reflection;

namespace FullStackSolution.API.Infra.IoC
{
    public static class AppServices
    {
        public static void RegisterDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IHeroService, HeroService>();
        }

        public static void ConfigureAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(c =>
            {
                c.AddProfile<FullStackSolutionProfile>();
            }, typeof(Startup));
        }

        public static void AddSwagger(this IServiceCollection services)
        {
            services.AddApiVersioning(options =>
            {
                options.ReportApiVersions = true;
                options.ApiVersionReader = new HeaderApiVersionReader("api-version");
                options.AssumeDefaultVersionWhenUnspecified = true;
                options.DefaultApiVersion = new ApiVersion(1, 0);
            });

            services.AddVersionedApiExplorer(
                options =>
                {
                    options.GroupNameFormat = "'v'VVV";
                    options.SubstituteApiVersionInUrl = true;

                });

            services.AddSwaggerGen(options =>
            {
                options.CustomOperationIds(e => $"{e.ActionDescriptor.RouteValues["controller"]}_{e.RelativePath}_{e.HttpMethod}");
                options.DescribeAllParametersInCamelCase();
                options.CustomSchemaIds(x => x.FullName);
                options.IncludeXmlComments(XmlCommentsFilePath);
            });

            services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();
        }

        static string XmlCommentsFilePath
        {
            get
            {
                var basePath = PlatformServices.Default.Application.ApplicationBasePath;
                var fileName = typeof(Startup).GetTypeInfo().Assembly.GetName().Name + ".xml";
                return Path.Combine(basePath, fileName);
            }
        }
    }
}