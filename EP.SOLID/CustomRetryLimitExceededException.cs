using Microsoft.EntityFrameworkCore.Storage;

namespace EP.SOLID
{
    public class CustomRetryLimitExceededException : CustomException
    {
        public CustomRetryLimitExceededException() { }
        public CustomRetryLimitExceededException(string message)
        : base(message) { }
        public CustomRetryLimitExceededException(
        string message, RetryLimitExceededException innerException)
        : base(message, innerException) { }
    }
}
