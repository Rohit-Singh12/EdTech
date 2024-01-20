using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using WebApiProjectEdTech.BusinessLogic.Models;
using WebApiProjectEdTech.Utilities;

namespace WebApiProjectEdTech.Repositories.RepoModels
{
    [BsonIgnoreExtraElements]
    public class CoursePreview : IModelConvert<BizCoursePreview>
    {
        /// <summary>
        ///     Id of the course
        /// </summary>
        public ObjectId Id { get; set; }
        public string CourseName { get; set; }
        public string CoursePreviewText { get; set; }
        public string PreviewImage { get; set; }

        public CoursePreview()
        {

        }

        public BizCoursePreview ToModel()
        {
            return new BizCoursePreview
            {
                CourseId = Id.ToString(),
                CourseName = CourseName,
                CoursePreviewText = CoursePreviewText,
                PreviewImage = PreviewImage
            };
        }
    }
}