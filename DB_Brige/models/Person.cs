namespace DB_Brige
{
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
        
        [Title("Имя")]
        public string FirstName { get; set; }
        
        [Title("Фамилия")]
        public string LastName { get; set; }
        
        [Title("Отчество")]
        public string MiddleName { get; set; }
    }
}