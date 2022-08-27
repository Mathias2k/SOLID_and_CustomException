﻿using Microsoft.EntityFrameworkCore;

namespace EP.SOLID
{
    internal class CustomDbUpdateException : CustomException
    {
        public CustomDbUpdateException() { }
        public CustomDbUpdateException(string message) : base(message) { }
        public CustomDbUpdateException(
        string message, DbUpdateException innerException)
        : base(message, innerException) { }
    }
}
