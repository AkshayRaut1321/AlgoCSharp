using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AlgoCSharp.Algorithms
{
    public interface ISedolValidator
    {
        ISedolValidationResult ValidateSedol(string input);
    }
    public interface ISedolValidationResult
    {
        string InputString { get; }
        bool IsValidSedol { get; }
        bool IsUserDefined { get; }
        string ValidationDetails { get; }
    }

    public class SedolValidationResult : ISedolValidationResult
    {
        public string InputString { get; }
        public bool IsValidSedol { get; }
        public bool IsUserDefined { get; }
        public string ValidationDetails { get; }

        public SedolValidationResult(string input, bool isValid, bool isUserDefined, string validationMessage)
        {
            this.InputString = input;
            this.IsValidSedol = isValid;
            this.IsUserDefined = isUserDefined;
            this.ValidationDetails = validationMessage;
        }

        public override string ToString()
        {
            return $"Input: {this.InputString}, Is valid: {this.IsValidSedol}, Is user defined: {this.IsUserDefined}, Validation details: {this.ValidationDetails}";
        }
    }

    public class SedolValidator : ISedolValidator
    {
        public ISedolValidationResult ValidateSedol(string input)
        {
            if (input == null || input == "" || input.Length != 7)
            {
                return new SedolValidationResult(input, false, false, "Input string was not 7-characters long");
            }
            var charArray = input.ToCharArray();
            var isUserDefined = charArray[0] == '9';

            var regexForLettersAndNumbers = @"^([a-zA-Z0-9]*)$";
            var allValidCharacters = Regex.IsMatch(input, regexForLettersAndNumbers);
            if (!allValidCharacters)
            {
                return new SedolValidationResult(input, false, isUserDefined, "SEDOL contains invalid characters");
            }

            var letterAlphabetIndex = new Dictionary<char, int>() { {'A', 1}, { 'B', 2}, { 'C',3}, { 'D',4}, { 'E',5}, { 'F',6}, { 'G',7}, { 'H',8},
        { 'I',9}, { 'J',10}, { 'K',11}, { 'L',12}, { 'M',13}, { 'N',14}, { 'O',15}, { 'P',16}, { 'Q',17}, { 'R',18},
        { 'S',19}, { 'T',20}, { 'U',21}, { 'V',22}, { 'W',23}, { 'X',24}, { 'Y',25}, { 'Z',26} };

            var characterWeightage = new Dictionary<int, int>() { { 0, 1 }, { 1, 3 }, { 2, 1 }, { 3, 7 }, { 4, 3 }, { 5, 9 } };

            var letterDisplacementValue = 9;

            var sum = 0;

            for (int i = 0; i < input.Length - 1; i++)
            {
                int currentNumber = -1;
                if (!int.TryParse(charArray[i].ToString(), out currentNumber))
                {
                    currentNumber = letterAlphabetIndex[charArray[i]] + letterDisplacementValue;
                }
                var characterValue = currentNumber * characterWeightage[i];
                sum = characterValue + sum;
            }

            var checkDigit = (10 - (sum % 10)) % 10;

            if (charArray[6].ToString() == checkDigit.ToString())
            {
                return new SedolValidationResult(input, true, isUserDefined, null);
            }
            else
            {
                return new SedolValidationResult(input, false, isUserDefined, "Checksum digit does not agree with the rest of the input");
            }
        }
    }

    public class SEDOLChecker
    {
        public void Test()
        {
            var sedolValidator = new SedolValidator();
            Console.WriteLine(sedolValidator.ValidateSedol("0709954").ToString());
            Console.WriteLine(sedolValidator.ValidateSedol(null).ToString());
            Console.WriteLine(sedolValidator.ValidateSedol("").ToString());
            Console.WriteLine(sedolValidator.ValidateSedol("12").ToString());
            Console.WriteLine(sedolValidator.ValidateSedol("123456789").ToString());
            Console.WriteLine(sedolValidator.ValidateSedol("1234567").ToString());
            Console.WriteLine(sedolValidator.ValidateSedol("B0YBKJ7").ToString());
            Console.WriteLine(sedolValidator.ValidateSedol("9123451").ToString());
            Console.WriteLine(sedolValidator.ValidateSedol("9ABCDE8").ToString());
            Console.WriteLine(sedolValidator.ValidateSedol("9123_51").ToString());
            Console.WriteLine(sedolValidator.ValidateSedol("VA.CDE8").ToString());
            Console.WriteLine(sedolValidator.ValidateSedol("9123458").ToString());
            Console.WriteLine(sedolValidator.ValidateSedol("9ABCDE1").ToString());
        }
    }
}
