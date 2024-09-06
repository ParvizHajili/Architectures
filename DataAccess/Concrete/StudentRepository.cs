using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using DataAccess.SqlDbContext;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class StudentRepository : BaseRepository<Student, ApplicationDbContext>, IStudentRepository
    {
        ApplicationDbContext ApplicationDbContext = new();
        public List<Student> GetExcellentStudents()
        {
            var students = ApplicationDbContext.Students.Where(x => x.IsExcellent == true).ToList();

            return students;
        }
    }
}
