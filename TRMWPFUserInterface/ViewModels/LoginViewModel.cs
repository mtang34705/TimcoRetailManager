using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRMWPFUserInterface.Helpers;

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

                var result = await _apiHelper.Authenticate(userName, password);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }

}

