using WebApiProjectEdTech.BusinessLogic.Models;

namespace WebApiProjectEdTech.BusinessLogic;

public interface ICourseManager
{
    Task<IEnumerable<CourseDetails>> GetCourseDetails();
}