namespace Basics.Principles.Abstraction
{
    //Abstraction
    //Reduce complexity by hiding unnnecessary details
    //Example: Remote control of TV, we just have to press correct number of channel,
    //and donot have to care about the electrical impulses,electro magnetic waves 
    public class EmailService
    {
        public void SendEmail()
        {
            Connect();
            Authenticate();
            Console.WriteLine("Sending Email...");
            Log();
            Disconnect();
        }

        private void Authenticate()
        {
            Console.WriteLine("Authenticate Credentials..");
        }

        private void Connect()
        {
            Console.WriteLine("Connect...");
        }

        private void Disconnect()
        {
            Console.WriteLine("Disconnect...");
        }

        //New method
        private void Log()
        {
            Console.WriteLine("Log Details");
        }

    }
}
