using Business.Abstract;
using Business.Concrete;
using Entities.Concrete;

namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IStudentService studentService = new StudentService();

            Student student = new Student()
            {
                FirstName = "Kamil",
                LastName = "İbadov",
                IsExcellent = true,
                PhoneNumber = "+994555555556"
            };

            //studentService.Add(student);

            //Console.WriteLine("Student Added Successfully");


            var students = studentService.GetExcellentStudents();

            foreach (var item in students)
            {
                Console.WriteLine(item.FirstName);
            }
        }
    }
}
