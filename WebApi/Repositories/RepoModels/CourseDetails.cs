using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using WebApiProjectEdTech.Utilities;

namespace WebApiProjectEdTech.Repositories.RepoModels;

[BsonIgnoreExtraElements]
public class CourseDetails : IModelConvert<BusinessLogic.Models.CourseDetails, CourseDetails>
{
    public ObjectId Id {get;set;}
    public string? CourseName {get;set;}
    public string? CourseInstructorName{get;set;}
    public string? CourseBasicDescription {get;set;}

    public BusinessLogic.Models.CourseDetails ToModel()
    {
        return new BusinessLogic.Models.CourseDetails
        {
            CourseBasicDescription = CourseBasicDescription,
            CourseInstructorName = CourseInstructorName,
            CourseName = CourseName
        };
    }
}