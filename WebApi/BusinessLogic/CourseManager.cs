
using WebApiProjectEdTech.BusinessLogic.Models;
using WebApiProjectEdTech.Repositories.CourseDetailsRepository;
namespace WebApiProjectEdTech.BusinessLogic;

public class CourseManager : ICourseManager
{
    public ICourseDetailsRepository _repositoryCourseDetails;
    public CourseManager(ICourseDetailsRepository repositoryCourseDetails)
    {
        _repositoryCourseDetails = repositoryCourseDetails;
    }

    public async Task<IEnumerable<CourseDetails>> GetCourseDetails()
    {
        var courses = await _repositoryCourseDetails.GetAllCourses();
        return courses.Where(item => item != null).Select(item => item.ToModel());
    }
}
