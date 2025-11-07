using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProject.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="Ltfen kullanıcı adını giriniz")]
        public string username { get; set; }

        [Required(ErrorMessage ="Ltfen şifrenizi giriniz")]
        public string password { get; set; }
    }
}
