using Core.DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IStudentRepository : IRepository<Student>
    {
        List<Student> GetExcellentStudents();
    }
}
