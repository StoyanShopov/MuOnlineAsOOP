namespace MuOnline.Utilities
{
    using System;

    public static class Validator
    {
        public static void ThrowAnExceptionIfIntIsLessThanZero(string objectName, int value)
        {
            if (value < 0)
            {
                throw new ArgumentException($"{objectName} cannot be less than zero!");
            }
        }

        public static void ThrowAnExceptionIfObjectIsNull(object obj, string paramName)
        {
            if (obj == null)
            {
                throw new ArgumentException($"{paramName} cannot be null!");
            }
        }
    }
}
