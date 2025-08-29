namespace SendNotificationPJ.Domain.Exceptions;

public class DomainException : Exception
{
    public DomainException(string exception) : base(exception)
    {
        //Envie um email
    }
}