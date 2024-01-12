using System.ComponentModel.DataAnnotations;

namespace Traversal.Models
{
	public class UserRegisterViewModel
	{
		[Required(ErrorMessage="Lütfen Adınızı Giriniz")]
        public string Name { get; set; }

		[Required(ErrorMessage = "Lütfen Soyadınızı Giriniz")]
		public string SurName { get; set; }

		[Required(ErrorMessage = "Lütfen Kullanıcı Adını Giriniz")]
		public string UserName { get; set; }

		[Required(ErrorMessage = "Lütfen E-Posta Adresinizi Giriniz")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Lütfen Şifrenizi Giriniz")]
		public string Password { get; set; }

		[Required(ErrorMessage = "Lütfen Şifrenizi Tekrar Giriniz")]
		[Compare("Password",ErrorMessage ="Şifreler Uyumlu Değildir")]
		public string ConfirmPassword { get; set; }

	}
}
