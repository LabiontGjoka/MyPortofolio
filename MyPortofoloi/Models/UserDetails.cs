namespace MyPortofoloi.Models
{
    public class UserDetails
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender{ get; set; }
        public string Description { get; set; }
        public string Address{ get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public List<Projects> Projects{ get; set; }
        public List<string> Hobbies { get; set; }
    }
}
