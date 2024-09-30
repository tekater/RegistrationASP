namespace UserRegistration.Models
{
    public class ErrorVM
    {
        public string? regId { get; set; }

        public bool ShowRegId => !(string.IsNullOrEmpty(regId));
    }
}
