using WebApiProjectEdTech.BusinessLogic;
using WebApiProjectEdTech.Repositories.CourseDetailsRepository;
namespace WebApiProjectEdTech.Configurator;
public static class Configurator
{
     public static void RegisterServices(this IServiceCollection services)
    {
        // Repository Registration
        services.AddScoped<ICourseDetailsRepository, CourseDetailsRepository>();

        // BusinessLogic Registration
        services.AddScoped<ICourseManager, CourseManager>();
    }
}