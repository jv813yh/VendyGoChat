using ChatClient.MVVM.ViewModels;

namespace ChatClient.Commands
{
    public class RegisterCommand : BaseCommand
    {
        private readonly RegistrationViewModel _registrationViewModel;

        public RegisterCommand(RegistrationViewModel registrationViewModel)
        {
            _registrationViewModel = registrationViewModel;
        }

        public override bool CanExecute(object? parameter)
        {
            if(_registrationViewModel.UserName.Length < 3 || _registrationViewModel.UserName.Length > 20)
            {
                return false;
            } 
            else if (_registrationViewModel.Password.Length < 6 || _registrationViewModel.Password.Length > 20)
            {
                return false;
            }
            else if (_registrationViewModel.Password != _registrationViewModel.ConfirmPassword)
            {
                return false;
            }
            else if (!_registrationViewModel.Email.Contains("@"))
            {
                return false;
            }


            return base.CanExecute(parameter);
        }

        public override void Execute(object? parameter)
        {
            throw new NotImplementedException();
        }
    }
}
