using System;

namespace LegacyApp
{
    public interface IUserValidationService
    {
        bool Validate(string firstName, string lastName, string email, DateTime dateOfBirth);
    }
}