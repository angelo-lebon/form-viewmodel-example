using System.ComponentModel.DataAnnotations;

namespace FormViewModelExample.ViewModels
{
    public class AccountLoginVm
    {
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
