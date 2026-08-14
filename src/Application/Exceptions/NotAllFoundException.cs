namespace Application.Exceptions;

public class NotAllFoundException(string entityName, long[] ids)
    : AWSApiException($"The following ids '{string.Join(", ", ids)}' were not found for entity '{entityName}'.")
{
    public IEnumerable<long> NotFoundIds { get; } = ids;
}