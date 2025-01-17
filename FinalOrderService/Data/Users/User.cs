using System.ComponentModel.DataAnnotations;

public class User
{
    [Key]
    public Guid UserGuid { get; set; }

    [Required]
    public String Username { get; set; }

    [Required]
    public String Email { get; set; }

    [Required]
    public String Password { get; set; }

     [Required]
    public DateTime CreatedDate { get; set; }

    string toString(){
        return this.UserGuid.ToString();
    }
}
