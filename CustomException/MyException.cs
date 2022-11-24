
namespace CustomException
{
    public class MyException : Exception
    {
        private int _Age;
        private int _Experience;
        private double _Level;

        private string _messageDetails = String.Empty;
        public DateTime ErrorTimeStamp {
            get { 
                return DateTime.Now; 
            }
        }
        public string CauseOfError {
            get {
                return "The error is because the age or experience you entered is not above 1";
            } 
        
        }

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
            

        }

        public void ExperienceCheck()
        {
            try
            {
                Console.WriteLine("Enter Age: ");
                _Age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter experience: ");
                _Experience= Convert.ToInt32(Console.ReadLine());


                if (_Age <= 0 || _Experience < 0)
                {
                    throw new MyException("Invalid Age or Experience Input",
                    DateTime.Now, $"{_Age} is an invalid age!");
                }
                else
                {
                    _Level = (_Experience / _Age) * 100;
                    Console.WriteLine("Your level is {0}", _Level);
                }
            }
            catch(Exception) 
            {
                Console.WriteLine("Cause of Error: {0}", CauseOfError);
                Console.WriteLine("Time: {0}", ErrorTimeStamp);
            }
        }
    }
}
