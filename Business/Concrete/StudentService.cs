using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;

namespace Business.Concrete
{
    public class StudentService : IStudentService
    {
        IStudentRepository repository = new StudentRepository();
        public void Add(Student entity)
        {
            repository.Add(entity);
        }

        public void Delete(Student entity)
        {
           repository.Delete(entity);
        }

        public List<Student> GetAll()
        {
            return repository.GetAll();
        }

        public Student GetById(int id)
        {
            return repository.GetById(id);
        }

        public List<Student> GetExcellentStudents()
        {
            return repository.GetExcellentStudents();
        }

        public void Update(Student entity)
        {
            repository.Update(entity);
        }
    }
}
