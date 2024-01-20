
using WebApiProjectEdTech.BusinessLogic.Models;
using WebApiProjectEdTech.Repositories;
namespace WebApiProjectEdTech.BusinessLogic;

public class CourseManager : ICourseManager
{
    public ICourseDetailsRepository _repositoryCourseDetails;
    public ICoursePreviewRepository _repositoryCoursePreview;
    public CourseManager(ICourseDetailsRepository repositoryCourseDetails, ICoursePreviewRepository repositoryCoursePreview)
    {
        _repositoryCourseDetails = repositoryCourseDetails;
        _repositoryCoursePreview = repositoryCoursePreview;
    }

    public async Task<IEnumerable<BizCourseDetails>> GetAllCourseDetails()
    {
        var courses = await _repositoryCourseDetails.GetAll();
        return courses.Where(item => item != null).Select(item => item.ToModel());
    }

    public async Task<IEnumerable<BizCoursePreview>> GetAllCoursePreview()
    {
        var courses = await _repositoryCoursePreview.GetAll();
        return courses.Where(item => item != null).Select(item => item.ToModel());
    }

    public async Task<string> AddCoursePreview(BizCoursePreview coursePreview)
    {
        if (coursePreview == null)
            return null;

        var id = await _repositoryCoursePreview.AddCourse(coursePreview.ToModel());
        return id;
    }

    public async Task<BizCoursePreview> GetCoursePreview(string courseId)
    {
        if (string.IsNullOrEmpty(courseId))
            return null;
        
        var coursePreview = await _repositoryCoursePreview.GetCourseById(courseId);
        return coursePreview?.ToModel();
    }

    public async Task<string> AddCourseDetails(BizCourseDetails courseDetails)
    {
        if (courseDetails == null)
            return null;
        
        return await _repositoryCourseDetails.AddCourseDetails(courseDetails.ToModel());
    }

    public async Task<BizCourseDetails> GetCourseDetails(string courseId)
    {
        if (string.IsNullOrEmpty(courseId))
            return null;
        
        var courseDetails = await _repositoryCourseDetails.GetDetailsById(courseId);
        return courseDetails?.ToModel();
    }
}
