using Microsoft.AspNetCore.Mvc;
using WebApiProjectEdTech.BusinessLogic;
using WebApiProjectEdTech.BusinessLogic.Models;
using WebApiProjectEdTech.Utilities;

namespace WebApiProjectEdTech.Controllers;

[ApiController]
[Route("[controller]")]
public class CourseDetailsController : ControllerBase
{

    private readonly ILogger<CourseDetailsController> _logger;
    private readonly ICourseManager _courseManager;

    public CourseDetailsController(ILogger<CourseDetailsController> logger, ICourseManager courseManager)
    {
        _logger = logger;
        _courseManager = courseManager;
    }

    /// <summary>
    ///     Add Course Preview Data
    /// </summary>
    /// <returns></returns>
    [HttpPost("CoursePreview")]
    public async Task<IActionResult> CoursePreview([FromBody] BizCoursePreview coursePreview)
    {
        if (coursePreview == null)
            return BadRequest();
        var id = await _courseManager.AddCoursePreview(coursePreview);
        return Ok(new GenericResponse{Response = id, ResponseInfo = "Id of the added document"});
    }

    /// <summary>
    ///     Get all course previews
    /// </summary>
    /// <returns> List of all course previews</returns>
    [HttpGet("CoursePreviews")]
    public async Task<IActionResult> CoursePreviews()
    {
        var coursePreviews = await _courseManager.GetAllCoursePreview();
        if (coursePreviews == null)
            return Ok(new List<BizCoursePreview>());
        return Ok(coursePreviews);
    }

    /// <summary>
    ///     Add specified course details
    /// </summary>
    /// <param name="courseDetails"></param>
    /// <returns></returns>
    [HttpPost("CourseDetails")]
    public async Task<IActionResult> CourseDetails([FromBody] BizCourseDetails courseDetails)
    {
        if (courseDetails == null)
            return BadRequest();
        var id = await _courseManager.AddCourseDetails(courseDetails);
        return Ok(new GenericResponse{Response = id, ResponseInfo = "Id of the added document"});
    }

    /// <summary>
    ///     Get all course details
    /// </summary>
    /// <returns> List of all course details</returns>
    [HttpGet("CourseDetailsList")]
    public async Task<IActionResult> CourseDetailsList()
    {
        var coursedetails = await _courseManager.GetAllCourseDetails();
        if (coursedetails == null)
            return Ok(new List<BizCourseDetails>());
        return Ok(coursedetails);
    }
}
