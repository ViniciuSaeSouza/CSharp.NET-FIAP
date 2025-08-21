using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
    internal class PasswordPolicy
    {
        private const int MinLength = 10;

        public bool IsValid(string password)
        {
            return !string.IsNullOrEmpty(password) && password.Length >= MinLength;
        }

    }
}

