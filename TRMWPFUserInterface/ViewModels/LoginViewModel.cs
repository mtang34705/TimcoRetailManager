using Caliburn.Micro;
using System;
using System.Threading.Tasks;
using TRMDesktopUI.Library.Api;

namespace TRMWPFUserInterface.ViewModels
{
    public class LoginViewModel : Screen
    {
        private int _userName;
        private int _password;
        private IApiHelper _apiHelper;
        public LoginViewModel(IApiHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }

        public int UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                NotifyOfPropertyChange(() => UserName);
            }
        }



        public int Password
        {
            get { return _password; }
            set
            {
                _password = value;
                NotifyOfPropertyChange(() => Password);
            }
        }


        public bool IsErrorVisible
        {
            get {
                bool output = false;
                if(ErrorMessage?.Length > 0)
                {
                    output = true;
                }
                return output; 
            }
        }

        private string _errorMessage;

        public string ErrorMessage
        {
            get { return _errorMessage; }
            set { 
                _errorMessage = value;
                NotifyOfPropertyChange(() => IsErrorVisible);
                NotifyOfPropertyChange(() => ErrorMessage);
            }
        }

        public bool CanLogIn(string userName, string password)
        {
            bool output = false;

            if(userName.Length > 0 && password.Length > 0)
            {
                output = true;
            }

            return output;
        }
        public async Task LogIn(string userName, string password)
        {
            try
            {
                ErrorMessage = string.Empty;
                var result = await _apiHelper.Authenticate(userName, password);
                await _apiHelper.GetLoggedInUserInfo(result.Access_Token);
            }
            catch(Exception ex)
            {
                ErrorMessage = ex.Message;
            }
            
        }
    }

}

