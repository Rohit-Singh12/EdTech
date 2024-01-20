using WebApiProjectEdTech.BusinessLogic;
using WebApiProjectEdTech.Repositories;
namespace WebApiProjectEdTech.Configurator;
public static class Configurator
{
     public static void RegisterServices(this IServiceCollection services)
    {
        // Repository Registration
        services.AddScoped<ICourseDetailsRepository, CourseDetailsRepository>();
        services.AddScoped<ICoursePreviewRepository, CoursePreviewRepository>();

        // BusinessLogic Registration
        services.AddScoped<ICourseManager, CourseManager>();
    }
}