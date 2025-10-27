using Dapper;
using DataAccess.Interface;
using DataAccess.Model;
using DataAccess.Tools;
using static Dapper.SqlMapper;
namespace DataAccess.SQL_Server
{
    public class AuthorDao : BaseDao, IAuthorDao
    {
        // Constructor which passed the connection string to the base class
        public AuthorDao(string connectionString) : base(connectionString)
        {

        }

        public Author? Get(int Id)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Author> GetAll()
        {
            var query = "SELECT * FROM Author";
            using var connection = CreateConnection();
            return connection.Query<Author>(query).ToList();
        }
        public int Create(Author author)
        {
            var query = "INSERT INTO Author (Email, BlogTitle, PasswordHash) OUTPUT INSERTED.Id VALUES(@Email, @BlogTitle, @PasswordHash)";
            var passwordHash = BCryptTool.HashPassword(author.PasswordHash);
            using var connection = CreateConnection();
            return connection.QuerySingle<int>(query, new { author.Email, author.BlogTitle, PasswordHash = passwordHash });
        }
        public bool Update(Author author)
        {
            throw new NotImplementedException();
        }
        public bool Delete(int Id)
        {
            throw new NotImplementedException();
        }

    }
}
