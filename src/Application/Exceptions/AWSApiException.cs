namespace Application.Exceptions
{
    public class AWSApiException(string message) : Exception(message)
    {
    }
}