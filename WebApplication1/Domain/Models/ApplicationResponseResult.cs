namespace WebApplication1.Domain.Models
{
    public class ApplicationResponseResult<T>
    {
        private readonly List<string> _errors = new List<string>();

        public T Result { get; set; }

        public IReadOnlyCollection<string> Errors => _errors.AsReadOnly();

        public ApplicationResponseStatus Status { get; private set; }

        public void Success()
        {
            Status = ApplicationResponseStatus.Success;
        }

        public void AddErrorMessage(string errorMessage)
        {
            _errors.Add(errorMessage);
        }

        public void Failure()
        {
            Status = ApplicationResponseStatus.Error;
        }
    }

    public enum ApplicationResponseStatus
    {
        Success,
        Error
    }
}
