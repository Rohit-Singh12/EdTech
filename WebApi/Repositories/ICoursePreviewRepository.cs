using WebApiProjectEdTech.Repositories.RepoModels;

namespace WebApiProjectEdTech.Repositories
{
    public interface ICoursePreviewRepository
    {
        Task<string> AddCourse(CoursePreview course);
        Task<CoursePreview> GetCourseById(string courseId);
        Task<List<CoursePreview>> GetAll();
    }
}