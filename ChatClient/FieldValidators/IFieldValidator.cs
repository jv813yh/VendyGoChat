namespace ChatClient.FieldValidators
{
    public delegate bool FieldValidatorDel(int fieldIndex, string fieldValue, string[] fieldArray, out string fieldInvalidMessage);

    //public delegate bool FieldValidatorDel(int fieldIndex, string fieldValue, string[] fieldArray);
    public interface IFieldValidator
    {
        void InitialiseValidatorDelegates();

        string[] FieldArray { get; }

        FieldValidatorDel GetFieldValidatorDel { get; }
    }
}
