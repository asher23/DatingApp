using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
  public class UserForRegisterDto
  {
    [Required]
    public string username { get; set; }

    [Required]
    [StringLength(8, MinimumLength = 4, ErrorMessage = "You need to specifiy a password before 4 and 8 characters")]
    public string password { get; set; }
  }
}