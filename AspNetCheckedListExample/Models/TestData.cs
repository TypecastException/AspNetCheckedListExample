using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetCheckedListExample.Models
{
    public class TestData
    {
        public TestData()
        {
            this.People = new List<Person>();
            this.People.Add(new Person() { 
                Id = 1, LastName = "Lennon", firstName = "John" });
            this.People.Add(new Person() { 
                Id = 2, LastName = "McCartney", firstName = "Paul" });
            this.People.Add(new Person() { 
                Id = 3, LastName = "Harrison", firstName = "George" });
            this.People.Add(new Person() { 
                Id = 4, LastName = "Starr", firstName = "Ringo" });
        }
        public List<Person> People { get; set; }
    }
}