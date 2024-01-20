using MongoDB.Bson;
using MongoDB.Driver;
using WebApiProjectEdTech.Repositories.RepoModels;

namespace WebApiProjectEdTech.Repositories
{
    public class CoursePreviewRepository : ICoursePreviewRepository
    {
        private readonly IMongoClient _mongoClient;
        private readonly IMongoDatabase _database;
        private readonly IMongoCollection<CoursePreview> _collection;
        public CoursePreviewRepository(IMongoClient mongoClient)
        {
            _mongoClient = mongoClient;
            _database = _mongoClient.GetDatabase("Course");
            _collection = _database.GetCollection<CoursePreview>("CoursePreview");
        }

        public async Task<string> AddCourse(CoursePreview course)
        {
            if (course == null)
                return null;

            await _collection.InsertOneAsync(course);
            return course.Id.ToString();
        }

        public async Task<CoursePreview> GetCourseById(string courseId)
        {
            if (!ObjectId.TryParse(courseId, out ObjectId id))
                return null;
            return await _collection.Find(Builders<CoursePreview>.Filter.Eq(x => x.Id,id)).FirstOrDefaultAsync();
        }

        public async Task<List<CoursePreview>> GetAll()
        {
            return await _collection.Find(new BsonDocument()).ToListAsync();
        }
    }
}