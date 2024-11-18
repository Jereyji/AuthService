
namespace Domain.Entity;

public class UserEntity
{
    public Guid ID { get; set; }
    public string Name { get; set; }
    public string HashPassword { get; set; }

    public UserEntity(in string name, in string password)
    {
        ID = Guid.NewGuid();
        Name = name;
        HashPassword = Hash(password); // realize hashing password
    }

    private string Hash(string input)
    {
        return input;
    }
}
