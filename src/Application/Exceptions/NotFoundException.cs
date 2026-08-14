namespace Application.Exceptions;

public class NotFoundException(string entityName, long id) : AWSApiException($"{entityName} with id '{id}' was not found.")
{
}