using Caliburn.Micro;
namespace TRMWPFUserInterface.ViewModels
{
    public class ShellViewModel:Conductor<object>
    {
        LoginViewModel _loginVM;
        public ShellViewModel(LoginViewModel loginVM)
        {
            _loginVM = loginVM;
            ActivateItemAsync(_loginVM);
        }
    }
}
