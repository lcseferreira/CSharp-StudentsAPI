namespace StudentsAPI.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        public string RA { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
    }
}
