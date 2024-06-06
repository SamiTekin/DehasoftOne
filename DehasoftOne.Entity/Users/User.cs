using DehasoftOne.Entity.BaseEntities;

namespace DehasoftOne.Entity.Users;

public class User:BaseEntity
{
    public string Name { get; set; }
    public string Username { get; set; }
    public string Password  { get; set; }
}
