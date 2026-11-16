using System;
using MongoDB.Bson;
using MongoDB.Driver;

var client = new MongoClient("mongodb://localhost:27017");
var database = client.GetDatabase("MoviesDatabase");
var movies = database.GetCollection<BsonDocument>("Movies");

var pipeline = new[]
{
    new BsonDocument("$match", new BsonDocument("year", 2007)),
    new BsonDocument("$project", new BsonDocument
    {
        { "_id", 0 },
        { "title", 1 },
        { "genres", new BsonDocument("$slice", new BsonArray { "$genres", 1 }) }
    })
};

var results = await movies.Aggregate<BsonDocument>(pipeline).ToListAsync();

foreach (var document in results)
{
    Console.WriteLine(document.ToJson());
}
