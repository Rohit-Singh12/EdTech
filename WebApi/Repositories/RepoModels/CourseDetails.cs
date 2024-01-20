using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using WebApiProjectEdTech.Utilities;

namespace WebApiProjectEdTech.Repositories.RepoModels;

[BsonIgnoreExtraElements]
public class CourseDetails : IModelConvert<BusinessLogic.Models.BizCourseDetails>
{
    public ObjectId Id {get;set;}
    public string CourseTitle {get;set;}
    public List<string> CourseInstructorName{get;set;}
    public string CourseBasicDescription {get;set;}
    public string PreviewImage{get;set;}
    public CourseLevel CourseLevel {get;set;}

    public BusinessLogic.Models.BizCourseDetails ToModel()
    {
        return new BusinessLogic.Models.BizCourseDetails
        {
            CourseId = Id.ToString(),
            CourseBasicDescription = CourseBasicDescription,
            CourseInstructorName = CourseInstructorName,
            CourseName = CourseTitle,
            PreviewImage = PreviewImage,
            Level = (BusinessLogic.Models.CourseLevel)CourseLevel
        };
    }
}

public enum CourseLevel
{
    [Display(Name="Basic")]
    Basic,
    [Display(Name="Intermediate")]
    Intermediate,
    [Display(Name="Advanced")]
    Advanced
}