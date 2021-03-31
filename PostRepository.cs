using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Dapper;
using System.Threading.Tasks;



public class PostRepository : BaseRepository, IRepository<Post>
{

    public PostRepository(IConfiguration configuration) : base(configuration) { }

    public async Task<IEnumerable<Post>> GetAll()
    {
        using var connection = CreateConnection();
        IEnumerable<Post> posts = await connection.QueryAsync<Post>("SELECT * FROM Posts ORDER BY Id DESC LIMIT 5;");
        return posts;
    }


    public async Task Delete(long id)
    {
        using var connection = CreateConnection();
        await connection.ExecuteAsync("DELETE FROM Posts WHERE Id = @Id;", new { Id = id });
    }

    public async Task<Post> Get(long id)
    {
        using var connection = CreateConnection();
        return await connection.QuerySingleAsync<Post>("SELECT * FROM Posts WHERE Id = @Id;", new { Id = id });
    }


    public async Task<Post> Insert(Post post)
    {
        using var connection = CreateConnection();
        return await connection.QuerySingleAsync<Post>("INSERT INTO Posts (Content, Name) VALUES (@Content, @Name) RETURNING *;", post);
    }
}

