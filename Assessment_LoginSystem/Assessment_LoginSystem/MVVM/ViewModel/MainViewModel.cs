using Microsoft.Win32;
using Assessment_LoginSystem.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_LoginSystem.MVVM.ViewModel{
    class MainViewModel : ObservableObject {

        private object _currentView;
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand UserListCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }
        public UserListViewModel UserListVM { get; set; }

        public object CurrentView {
            get { return _currentView; }
            set { 
                _currentView = value;
                OnPropertyChanged();
            }
        }
        
        public MainViewModel() {
            HomeVM = new HomeViewModel();
            UserListVM = new UserListViewModel();

            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o => {
                CurrentView = HomeVM;
            });

            UserListCommand = new RelayCommand(o => {
                CurrentView = UserListVM;
            });
        }
    }
}
