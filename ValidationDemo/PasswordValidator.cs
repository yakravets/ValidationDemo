using System;

namespace ValidationDemo
{
    public class PasswordValidator
    {
        public bool Validate(string password)
        {
            if (password == String.Empty)
            {
                return false;
            }

            if (password == null)
            {
                throw new NullReferenceException();
            }

            return true;
        }
    }
}