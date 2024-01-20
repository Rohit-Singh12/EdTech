using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using WebApiProjectEdTech.Repositories.RepoModels;
using WebApiProjectEdTech.Utilities;
using ZstdSharp.Unsafe;

namespace WebApiProjectEdTech.BusinessLogic.Models
{
    public class BizCourseDetails : IModelConvert<CourseDetails>
    {
        public string CourseId {get;set;}
        public string CourseName {get;set;}
        public List<string> CourseInstructorName{get;set;}
        public string CourseBasicDescription {get;set;}
        public string PreviewImage {get;set;}
        public CourseLevel Level {get;set;}

        public CourseDetails ToModel()
        {
            _ = ObjectId.TryParse(CourseId, out ObjectId id); 
            return new CourseDetails
            {
                Id = id,
                CourseBasicDescription = CourseBasicDescription,
                CourseInstructorName = CourseInstructorName,
                CourseLevel = (Repositories.RepoModels.CourseLevel)Level,
                PreviewImage = PreviewImage,
                CourseTitle = CourseName,
                
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
}