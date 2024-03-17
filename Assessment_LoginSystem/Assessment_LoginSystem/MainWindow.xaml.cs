using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assessment_LoginSystem {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        // Event to handle quitting the app
        private void CloseButton_Click(object sender, RoutedEventArgs e) {
            string exitText = "Are you sure you want to quit?";
            string caption = "Exit";
            MessageBoxButton button = MessageBoxButton.YesNo;

            // Asks user before quitting
            if (MessageBox.Show(exitText, caption, button, MessageBoxImage.Question)
                == MessageBoxResult.Yes) {
                Close();
            }
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e) {
            var login = new AuthorisationWindow();
            login.Show();
            this.Close();
        }
    }
}
