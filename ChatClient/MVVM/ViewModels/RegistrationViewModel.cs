using System.Windows.Input;

namespace ChatClient.MVVM.ViewModels
{
    public class RegistrationViewModel : BaseViewModel
    {

        private string _userName = string.Empty;

        private string _password = string.Empty;

        private string _confirmPassword = string.Empty;

        private string _email = string.Empty;

        public string UserName
        {
            get => _userName;
            set
            {
                _userName = value;
                OnPropertyChanged(nameof(UserName));
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public string ConfirmPassword
        {
            get => _confirmPassword;
            set
            {
                _confirmPassword = value;
                OnPropertyChanged(nameof(ConfirmPassword));
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public ICommand RegisterCommand { get; }

        public RegistrationViewModel()
        {

        }
    }
}
