using System.Reflection;

namespace UserRegistration.Models
{
    public class Registration
    {
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PasswordRepeat { get; set; }

        public bool Confirm()
        {
            if (!(UserName == PasswordRepeat))
            {
                return false;
            }
            else
            {
            return true;
            }
        }
    }
}
