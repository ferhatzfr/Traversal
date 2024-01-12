using System.ComponentModel.DataAnnotations;

namespace Traversal.Models
{
    public class UserSingInViewModel
    {
        [Required(ErrorMessage = "Lütfen Kullanıcı Adınızı Giriniz")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Şifrenizi Giriniz")]
        public string Password { get; set; }
    }
}
