namespace FieldValidationAPI
{
    public class CommonRegularExpressionValidationPatterns
    {
        // Regular expression pattern for email address validation
        public const string Email_Address_RegEx_Pattern = @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";

        // Regular expression pattern for strong password validation
        public const string Strong_Password_RegEx_Pattern = @"(?=^.{6,10}$)(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&amp;*()_+}{&quot;:;'?/&gt;.&lt;,])(?!.*\s).*$";
    }
}
