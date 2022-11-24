
namespace CustomException
{
    public class MyException : Exception
    {
        private int _Age;
        private int _Experience;

        private string _messageDetails = String.Empty;
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }

        public MyException() 
        {
            
        }

        public MyException(string Cause, DateTime date ) : this(Cause, date, string.Empty)
        {
            
        }

        public MyException(string cause, DateTime time, string message) : this(cause, time, message, null)
        {
            
        }

        public MyException(string cause, DateTime time, string message, System.
        Exception inner) : base(message, inner)
        {
            CauseOfError = cause;
            ErrorTimeStamp = time;

        }

        public void ExperienceCheck()
        {
            Console.WriteLine("Enter Age: ");
            _Age = Convert.ToInt32(Console.ReadLine());  

            Console.WriteLine("Enter experience: ");
            _Experience= Convert.ToInt32(Console.ReadLine());

            if(_Age <= 0 ) 
            { 
            throw new MyException("Invalid Age Input",
            DateTime.Now, $"{_Age} is an invalid age!")
            {
                HelpLink = "http://www.stackoverflow.com",
            };

            }
        }
    }
}
