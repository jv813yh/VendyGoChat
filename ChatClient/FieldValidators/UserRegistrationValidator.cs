using FieldValidationAPI;
using static ChatClient.FieldValidators.FieldConstants;

namespace ChatClient.FieldValidators
{
    delegate bool IsAvailableEmailDel(string email);


    // Class to validate user registration or login fields
    public class UserRegistrationValidator : IFieldValidator
    {

        private const int _userNameMinLength = 3;
        private const int _userNameMaxLength = 20;


        private ReguiredFieldValidation _reguiredFieldValidation = null;

        private PatternMatchDel _patternMatchDel = null;

        private CompareFieldsDel _compareFieldsDel = null;

        private LengthValidationDel _lengthValidationDel = null;

        private IsAvailableEmailDel _isAvailableEmailDel = null;


        // Function to validate the required fields
        private FieldValidatorDel _fieldValidatorDel = null;



        public UserRegistrationValidator()
        {
            
        }


        private string[] _fieldArray;
        public string[] FieldArray 
        { 
            get
            {
                if(_fieldArray == null)
                {
                    _fieldArray = new string[Enum.GetValues(typeof(UserRegistrationFields)).Length];
                }

                return _fieldArray;
            }
        }

        public FieldValidatorDel GetFieldValidatorDel
            => _fieldValidatorDel;

        public void InitialiseValidatorDelegates()
        {
            _fieldValidatorDel = new FieldValidatorDel(ValidFieldFunc);

            _reguiredFieldValidation = CommonValidatorFunctions.GetReguiredFieldValidation;
            _patternMatchDel = CommonValidatorFunctions.GetPatternMatchDel;
            _compareFieldsDel = CommonValidatorFunctions.GetCompareFieldsDel;
            _lengthValidationDel = CommonValidatorFunctions.GetLengthValidationDel;
        }


        private bool ValidFieldFunc(int fieldIndex, string fieldValue, string[] fieldArray, out string fieldInvalidMessage)
        {
            fieldInvalidMessage = string.Empty;

            UserRegistrationFields field = (UserRegistrationFields)fieldIndex;

            switch(field)
            {
                case UserRegistrationFields.UserName:
                    if(!_reguiredFieldValidation(fieldValue))
                    {
                        fieldInvalidMessage = "User name is required";

                        return false;
                    }

                    if(!_lengthValidationDel(fieldValue, _userNameMinLength, _userNameMaxLength))
                    {
                        fieldInvalidMessage = $"User name must be between {_userNameMinLength} and {_userNameMaxLength} characters";


                        return false;
                    }

                    break;

                case UserRegistrationFields.Password:
                    if(!_reguiredFieldValidation(fieldValue))
                    {
                        fieldInvalidMessage = "Password is required";

                        return false;
                    }

                    if(!_patternMatchDel(fieldValue, CommonRegularExpressionValidationPatterns.Strong_Password_RegEx_Pattern))
                    {
                        fieldInvalidMessage = "Password must be between 6 and 10 characters, contain at least one numeric digit, one uppercase and one lowercase letter, and one special character";

                        return false;
                    }

                    break;

                case UserRegistrationFields.ConfirmPassword:
                    if(!_reguiredFieldValidation(fieldValue))
                    {
                        fieldInvalidMessage = "Confirm password is required";

                        return false;
                    }

                    if(!_compareFieldsDel(fieldValue, fieldArray[(int)UserRegistrationFields.Password]))
                    {
                        fieldInvalidMessage = "Password and confirm password do not match";

                        return false;
                    }

                    break;

                case UserRegistrationFields.Email:
                    if(!_reguiredFieldValidation(fieldValue))
                    {
                        fieldInvalidMessage = "Email is required";

                        return false;
                    }

                    if(!_patternMatchDel(fieldValue, CommonRegularExpressionValidationPatterns.Email_Address_RegEx_Pattern))
                    {
                        fieldInvalidMessage = "Invalid email address";

                        return false;
                    }

                    break;
            }


            return true;
        }
    }
}
