using DataAccess.Interface;
using DataAccess.SQL_Server;

namespace BlogSharp.Test.DataAccessTests
{
    public class AuthorDaoTest
    {
        private const string connectionString = "Data Source=localhost;Initial Catalog=BlogSharp;User ID=sa;Password=@12tf56so;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AuthorDao_GetAll()
        {
            //arrange
            //insert Data...
            IAuthorDao authorDao = new AuthorDao(connectionString);

            //act
            var authors = authorDao.GetAll();
            //assert
            Assert.That(authors.Count(), Is.EqualTo(3), "Der blev forventede 3");

        }

        [Test]
        public void AuthorDao_Create()
        {
            //arrange

            //act

            //assert

        }
    }
}