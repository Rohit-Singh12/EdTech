using MongoDB.Bson;
using WebApiProjectEdTech.Repositories.RepoModels;
using WebApiProjectEdTech.Utilities;

namespace WebApiProjectEdTech.BusinessLogic.Models
{
    public class BizCoursePreview : IModelConvert<CoursePreview>
    {
        public string CourseId {get;set;}
        public string CourseName {get;set;}
        public string CoursePreviewText { get; set; }
        public string PreviewImage { get; set; }
        public CoursePreview ToModel()
        {
            _ = ObjectId.TryParse(CourseId, out ObjectId id);
            return new CoursePreview
            {
                Id = id,
                CoursePreviewText = CoursePreviewText,
                CourseName = CourseName,
                PreviewImage = PreviewImage
            };
        }
    }

}