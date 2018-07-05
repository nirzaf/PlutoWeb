using PlutoWeb.Core.Domain;

namespace PlutoWeb.Core.Repositories
{
    public interface IAuthorRepository : IRepository<Author>
    {
        Author GetAuthorWithCourses(int id);
    }
}