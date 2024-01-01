using WebApiProjectEdTech.Repositories.RepoModels;

namespace WebApiProjectEdTech.Repositories.CourseDetailsRepository;

public interface ICourseDetailsRepository
{
    Task<List<CourseDetails>> GetAllCourses();
}