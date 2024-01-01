using MongoDB.Bson;
using MongoDB.Driver;
using WebApiProjectEdTech.Repositories.RepoModels;

namespace WebApiProjectEdTech.Repositories.CourseDetailsRepository{

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
    public async Task<List<CourseDetails>> GetAllCourses()
    {
        return await _collection.Find(new BsonDocument()).ToListAsync();
    }
}
}