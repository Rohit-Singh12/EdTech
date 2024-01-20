using MongoDB.Bson;
using MongoDB.Driver;
using WebApiProjectEdTech.Repositories.RepoModels;

namespace WebApiProjectEdTech.Repositories{

    public class CourseDetailsRepository : ICourseDetailsRepository
    {
        private readonly IMongoClient _mongoClient;
        private readonly IMongoDatabase _database;
        private readonly IMongoCollection<CourseDetails> _collection;
        public CourseDetailsRepository(IMongoClient mongoClient)
        {
            _mongoClient = mongoClient;
            _database = _mongoClient.GetDatabase("Course");
            _collection = _database.GetCollection<CourseDetails>("CourseDetails");
        }
        public async Task<List<CourseDetails>> GetAll()
        {
            return await _collection.Find(new BsonDocument()).ToListAsync();
        }

        public async Task<string> AddCourseDetails(CourseDetails course)
        {
            if (course == null)
                return null;
            
            await _collection.InsertOneAsync(course);
            return course.Id.ToString();
        }

        public async Task<CourseDetails> GetDetailsById(string courseId)
        {
            if (!ObjectId.TryParse(courseId, out ObjectId id))
                return null;
            
            return await _collection.Find(Builders<CourseDetails>.Filter.Eq(x => x.Id, id)).FirstOrDefaultAsync();
        }
    }
}