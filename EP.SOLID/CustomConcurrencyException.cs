using Microsoft.EntityFrameworkCore;

namespace EP.SOLID
{
    public class CustomConcurrencyException : CustomException
    {
        public CustomConcurrencyException() { }
        public CustomConcurrencyException(string message) : base(message) { }
        public CustomConcurrencyException(
        string message, DbUpdateConcurrencyException innerException)
        : base(message, innerException) { }
    }
}
