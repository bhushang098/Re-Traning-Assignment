namespace ExceptionLib
{
    public class MarksNegativeException : Exception
    {
        public MarksNegativeException(string message) : base(message)
        {

        }
    }

    public class MarksOverException : Exception
    {
        public MarksOverException(string message) : base(message)
        {

        }
    }
}