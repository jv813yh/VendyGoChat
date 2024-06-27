using System.Windows.Input;

namespace ChatClient.Commands
{
    // Base abstract class for implementing commands in the application
    public abstract class BaseCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public void OnCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        public virtual bool CanExecute(object? parameter)
         => true;


        public abstract void Execute(object? parameter);
    }
}
