using System.Windows;

namespace Assessment_LoginSystem {
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class AuthorisationWindow : Window {
        public AuthorisationWindow() {
            InitializeComponent();
        }
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

        

        private void ToRegistration_Click(object sender, RoutedEventArgs e) {
            ToRegistration.Visibility = Visibility.Hidden;
            CloseButton.Visibility = Visibility.Hidden;

            BackButton.Visibility = Visibility.Visible;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e) {
            SwitchToLogin();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e) {
            string exitText = "Registration successful, please login with new credentials";
            string caption = "Success!";
            MessageBoxButton button = MessageBoxButton.OK;

            // Asks user before quitting
            if (MessageBox.Show(exitText, caption, button, MessageBoxImage.Question)
                == MessageBoxResult.Yes) {
                Close();
            }
            SwitchToLogin();
        }

        private void SwitchToLogin() {
            BackButton.Visibility = Visibility.Hidden;

            ToRegistration.Visibility = Visibility.Visible;
            CloseButton.Visibility = Visibility.Visible;
        }
    }
}
