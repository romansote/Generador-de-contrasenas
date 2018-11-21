using System;
namespace test.Models
{
    public enum TypePassword
    {
        OnlyAlphaNumeric = 1,
        OnlyNumbers = 2,
        OnlyLetters = 3,
        AlphanumericAndSpecialSymbols = 4
    }

    public class GeneratorModel
    {
        public int Type { get; set; }
        public int Size { get; set; }

    }

}
