using System;
namespace MvcTueTest.Models
{
    public class Person
    {
//        public Person()
//        {
//            Id = new Guid();
//            CreateOn = DateTime.Now;
//        }

        public int Id { get; set; }
//        public DateTime CreateOn { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
//        public int Id { get; set; }
//        public string Name { get; set; }

    }
}
