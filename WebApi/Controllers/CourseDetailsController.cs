using Microsoft.AspNetCore.Mvc;
using WebApiProjectEdTech.BusinessLogic;

namespace WebApiProjectEdTech.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class CourseDetailsController : ControllerBase
{

    private readonly ILogger<CourseDetailsController> _logger;
    private readonly ICourseManager _courseManager;

    public CourseDetailsController(ILogger<CourseDetailsController> logger, ICourseManager courseManager)
    {
        _logger = logger;
        _courseManager = courseManager;
    }

    [HttpGet]
    public async Task<IActionResult> Details()
    {
        var courseItems = await _courseManager.GetCourseDetails();
        return Ok(courseItems);
    }
}
