using System.ComponentModel.DataAnnotations;

namespace dbAspNet.Models
{
    public class LoginModel
    {
        [Required (ErrorMessage = "vui lòng nhập username!")]
        public string UserName { set; get; }
        [Required(ErrorMessage = "vui lòng nhập passwork!")]

        public string Password { set; get; }
        public int QL { set; get; }
        public bool RememberMe { set; get; }
    }
}