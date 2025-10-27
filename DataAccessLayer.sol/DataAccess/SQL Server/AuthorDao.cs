using DataAccess.Interface;
using DataAccess.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            throw new NotImplementedException();
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
