using Core.Entities;

namespace Entities.Concrete
{
    public class Student : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsExcellent { get; set; }
        public string PhoneNumber { get; set; }
    }
}
