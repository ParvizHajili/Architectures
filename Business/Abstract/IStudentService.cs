using Entities.Concrete;

namespace Business.Abstract
{
    public interface IStudentService
    {
        void Add(Student entity);
        void Update(Student entity);
        void Delete(Student entity);
        Student GetById(int id);
        List<Student> GetAll();
        List<Student> GetExcellentStudents();
    }
}
