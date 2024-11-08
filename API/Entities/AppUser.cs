namespace API.Entities;

public class AppUser
{
    //Id by convention will be the PK of the table. If not you need to use an annotation of [key]
    public int Id { get; set; }
    public required string UserName { get; set; }
    public required byte[] PasswordHash { get; set; }
    public required byte[] PasswordSalt { get; set; }
}
