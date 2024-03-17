using Assessment_LoginSystem.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_LoginSystem.MVVM.ViewModel {
    internal class AuthorisationViewModel  : ObservableObject{
        private object _currentView;

        public RelayCommand LoginViewCommand { get; set; }
        public RelayCommand RegisterViewCommand { get; set; }

        public LoginViewModel LoginVM { get; set; }
        public RegisterViewModel RegisterVM { get; set; }

        public object CurrentView {
            get { return _currentView; }
            set {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public AuthorisationViewModel() {
            LoginVM = new LoginViewModel();
            RegisterVM = new RegisterViewModel();

            CurrentView = LoginVM;

            LoginViewCommand = new RelayCommand(o => {
                CurrentView = LoginVM;
            });

            RegisterViewCommand = new RelayCommand(o => {
                CurrentView = RegisterVM;
            });
        }
    }
}
