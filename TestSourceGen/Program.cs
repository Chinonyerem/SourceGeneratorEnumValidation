namespace TestSourceGen
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            EnumValidation.EnumValidator.Validate((Example1)7);
            EnumValidation.EnumValidator.Validate((Example2)7);
        }
    }

    internal enum Example1
    {
        First = 1,
        Second = 2
    }

    internal enum Example2
    {
        First = 7,
        Second = 11,
        Third = 1
    }
}