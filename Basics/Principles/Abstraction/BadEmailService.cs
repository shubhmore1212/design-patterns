namespace Basics.Principles.Abstraction
{
    public class BadEmailService
    {
        public void SendEmail()
        {
            Console.WriteLine("Sending Email...");
        }

        public void Authenticate()
        {
            Console.WriteLine("Authenticate Credentials..");
        }

        public void Connect()
        {
            Console.WriteLine("Connect...");
        }

        public void Disconnect()
        {
            Console.WriteLine("Disconnect...");
        }

        //New method
        public void Log()
        {
            Console.WriteLine("Log Details");
        }
    }
}
