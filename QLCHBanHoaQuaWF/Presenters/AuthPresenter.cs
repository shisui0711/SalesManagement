using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using QLCHBanHoaQuaWF.Views;

namespace QLCHBanHoaQuaWF.Presenters
{
    internal class AuthPresenter
    {
        private IViewLogin _viewLogin;
        private IViewMain _viewMain;
        public AuthPresenter(IViewLogin viewLogin,IViewMain viewMain)
        {
            _viewLogin = viewLogin;
            _viewMain = viewMain;

            _viewLogin.LoginEvent += delegate { Login(); };
        }

        public void Login()
        {
            var loginForm = _viewLogin as Form;
            var mainForm = _viewMain as Form;
            loginForm.Hide();
            mainForm.ShowDialog();
            loginForm.Show();
        }
    }
}
