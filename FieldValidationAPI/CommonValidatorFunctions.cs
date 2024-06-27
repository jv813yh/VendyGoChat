
using System.Text.RegularExpressions;

namespace FieldValidationAPI
{
    // Delegate for the required field validation
    public delegate bool ReguiredFieldValidation(string fieldValue);

    // Delegate for the pattern match validation
    public delegate bool PatternMatchDel(string fieldVal, string pattern);

    // Delegate for the compare fields validation
    public delegate bool CompareFieldsDel(string fieldVal1, string fieldVal2);

    // Delegate for the length validation
    public delegate bool LengthValidationDel(string fieldVal, int minLength, int maxLength);



    // Class to hold the common validation functions
    public class CommonValidatorFunctions
    {

        private static ReguiredFieldValidation _reguiredFieldValidation = null;

        private static PatternMatchDel _patternMatchDel = null;

        private static CompareFieldsDel _compareFieldsDel = null;

        private static LengthValidationDel _lengthValidationDel = null;


        /*
         * 
         *              Getters for the delegates
         *                 
         */

        public static ReguiredFieldValidation GetReguiredFieldValidation
        {
            get
            {
                if (_reguiredFieldValidation == null)
                {
                    _reguiredFieldValidation = new ReguiredFieldValidation(RequiredFieldValidator);
                }
                return _reguiredFieldValidation;
            }
        }

        public static PatternMatchDel GetPatternMatchDel
        {
            get
            {
                if (_patternMatchDel == null)
                {
                    _patternMatchDel = new PatternMatchDel(PatternMatchValidator);
                }
                return _patternMatchDel;
            }
        }

        public static CompareFieldsDel GetCompareFieldsDel
        {
            get
            {
                if (_compareFieldsDel == null)
                {
                    _compareFieldsDel = new CompareFieldsDel(CompareFieldsValidator);
                }
                return _compareFieldsDel;
            }
        }

        public static LengthValidationDel GetLengthValidationDel
        {
            get
            {
                if (_lengthValidationDel == null)
                {
                    _lengthValidationDel = new LengthValidationDel(LengthValidator);
                }
                return _lengthValidationDel;
            }
        }


        /*
         * 
         *              Implientation of the validation functions
         *              
         *              return true if the field is valid
         * 
         */

        private static bool LengthValidator(string fieldVal, int minLength, int maxLength)
        {
            if(fieldVal.Length >= minLength && fieldVal.Length <= maxLength)
            {
                return true;
            }

            return false;
        }

        private static bool CompareFieldsValidator(string fieldVal1, string fieldVal2)
        {
            if(string.Equals(fieldVal1.Trim(), fieldVal2.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            return false;
        }

        private static bool PatternMatchValidator(string fieldVal, string regularExpressionPattern)
        {
            if(Regex.IsMatch(fieldVal, regularExpressionPattern))
            {
                return true;
            }

            return false;
        }

        private static bool RequiredFieldValidator(string fieldValue)
        {
            if(!string.IsNullOrEmpty(fieldValue))
            {
                return true;
            }

            return false;
        }
    }
}
