using DataAccess.Model;

namespace DataAccess
{
    public interface IAuthorDao

    {
        Author? Get(int Id);
        IEnumerable<Author> GetAll();
        bool Delete(int Id);
        bool Update(Author author);
        int Create(Author author);

    }
}