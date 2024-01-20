using WebApiProjectEdTech.Repositories.RepoModels;

namespace WebApiProjectEdTech.Repositories;

public interface ICourseDetailsRepository
{
    Task<List<CourseDetails>> GetAll();
    Task<string> AddCourseDetails(CourseDetails course);
    Task<CourseDetails> GetDetailsById(string courseId);
}