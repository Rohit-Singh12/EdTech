using WebApiProjectEdTech.BusinessLogic.Models;

namespace WebApiProjectEdTech.BusinessLogic;

public interface ICourseManager
{
    Task<IEnumerable<BizCourseDetails>> GetAllCourseDetails();
    Task<IEnumerable<BizCoursePreview>> GetAllCoursePreview();
    Task<string> AddCoursePreview(BizCoursePreview coursePreview);
    Task<BizCoursePreview> GetCoursePreview(string courseId);
    Task<string> AddCourseDetails(BizCourseDetails courseDetails);
    Task<BizCourseDetails> GetCourseDetails(string courseId);
}