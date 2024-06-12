namespace Basics.SOLID.S.BadExample
{
    public class User
    {
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public void Register()
        {
            // Register user logic
            // ...

            // Send email notification
            EmailSender emailSender = new EmailSender();
            emailSender.SendEmail("Welcome to our platform!", Email);
        }
    }
}