namespace DatingApp.Entities
{
    public class AppUser
    {
        public int Id { get; set; } // since it's called Id, this property will be the primary key by default
        public required string UserName { get; set; } 

    }
}
