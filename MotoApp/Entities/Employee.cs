

namespace MotoApp.Entities
{
    public class Employee:EntityBase
    {
       public Employee() { }
        public Employee(string name)
        {

        }

        //public int Id { get; set; } w entityBase
        public string? FirstName { get; set; }

        public override string ToString() //=>$"Id:{Id}, First Name{FirstName}";
        {
            return $"Id:{Id}, First Name: {FirstName}";
        }
    }
}
