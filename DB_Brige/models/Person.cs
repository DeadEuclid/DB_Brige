using System.ComponentModel.DataAnnotations;
using AutoGrid;

namespace Viewer
{
    [Title("пасажиров")]
    public class Person
    {
        public Person(string firstName, string lastName, string middleName = null)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
        }

        public Person()
        { }
        public int Id { get; set; }

        [Title("Фамилия")]
        [AddableBDTitle("Фамилия")]
        public string LastName { get; set; }
        [Title("Имя")]
        [AddableBDTitle("Имя")]
        public string FirstName { get; set; }



        [Title("Отчество")]
        [AddableBDTitle("Отчество")]
        public string MiddleName { get; set; }
    }
}