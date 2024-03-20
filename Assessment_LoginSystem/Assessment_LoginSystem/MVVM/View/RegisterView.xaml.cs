using Assessment_LoginSystem.MVVM.Model;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Assessment_LoginSystem.MVVM.View {
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class RegisterView : UserControl {
        public RegisterView() {
            InitializeComponent();
        }

        private void GeneratePassword_Checked(object sender, RoutedEventArgs e) {
            registerPassword.IsEnabled = false;
            registerPassword.Password = "";
            registerPassword.Visibility = Visibility.Collapsed;
            autoGeneratePasswordDisplay.Visibility = Visibility.Visible;
        }

        private void GeneratePassword_Unchecked(object sender, RoutedEventArgs e) {
            registerPassword.IsEnabled = true;
            registerPassword.Visibility = Visibility.Visible;
            autoGeneratePasswordDisplay.Visibility = Visibility.Hidden;
        }

        private void Register_Click(object sender, RoutedEventArgs e) {
            string un = registerUsername.Text;
            string pw;

            // If random password was checked
            if (GeneratePassword.IsChecked == true) {
                pw = UserAccountManager.GenerateRandomPassword();
                User newUserRNG = new User(un, pw);
                ValidateRegisterForm(newUserRNG);
            } else {
                pw = registerPassword.Password; 
                User newUser = new User(un, pw);
                ValidateRegisterForm(newUser);
            }
        }

        private void CallRegisterUser(User user) {
            UserAccountManager.RegisterUser(user);

            string exitText = "Registration successful, please login with new credentials";
            string caption = "Success!";
            MessageBoxButton button = MessageBoxButton.OK;

            if (GeneratePassword.IsChecked == true) {
                exitText = 
                    $"Registration successful, please login with new credentials\n" +
                    $"Your generated password is : '{user.password}'\n" +
                    $"Contact your systems admin if you forget.";
            }

            if (MessageBox.Show(exitText, caption, button, MessageBoxImage.Question)
            == MessageBoxResult.Yes) {

                var authWindow = new AuthorisationWindow();
                authWindow.Show();

                Window authParentWindow = Window.GetWindow(this); // Get the parent window to close
                authParentWindow.Close();
            }

            var login = new AuthorisationWindow();
            login.Show();

            var myWindow = Window.GetWindow(this);
            myWindow.Close();
        }

        private void ValidateRegisterForm(User user) {
            if (user.username == "" && user.password == "") {
                authentication.Visibility = Visibility.Visible;
                authentication.Text = "Fill out username and password in the fields";

                registerUsername.BorderBrush = Brushes.Red;
                registerPassword.BorderBrush = Brushes.Red;
            } else if (user.username == "") {
                authentication.Visibility = Visibility.Visible;
                authentication.Text = "Fill out username the field";
                registerUsername.BorderBrush = Brushes.Red;
            } else if (user.password.Length < 10) {
                authentication.Visibility = Visibility.Visible;
                authentication.Text = "Password must be more than 10 chaacters!";
                registerPassword.BorderBrush = Brushes.Red;
            } else if (user.password == "") {
                authentication.Visibility = Visibility.Visible;
                authentication.Text = "Fill out password in the field";
                registerPassword.BorderBrush = Brushes.Red;
            } else {
                if (!UserAccountManager.UserExists(user.username)) {
                    authentication.Visibility = Visibility.Hidden;
                    
                    CallRegisterUser(user);
                } else {
                    authentication.Visibility = Visibility.Visible;
                    authentication.Text = "User already exists!";
                }
            }
        }
    }
}
