namespace CustomException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyException myException= new MyException();
            myException.ExperienceCheck();
        }
    }
}