using Assessment_LoginSystem.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Assessment_LoginSystem.MVVM.View {
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class RegisterView : UserControl {
        public RegisterView() {
            InitializeComponent();
        }

        private void GeneratePassword_Checked(object sender, RoutedEventArgs e) {
            // auto generate logic. send to VM
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
            string pw = registerPassword.Password;
            Debug.WriteLine(un);
            Debug.WriteLine(pw);

            Debug.WriteLine(UserAccountManager.UserExists(un));

            if (un == "" && pw == "") {
                authentication.Visibility = Visibility.Visible;
                authentication.Text = "Fill out username and password in the fields";

                registerUsername.BorderBrush = Brushes.Red;
                registerPassword.BorderBrush = Brushes.Red;
            } else if (un == "") {
                authentication.Visibility = Visibility.Visible;
                authentication.Text = "Fill out username the field";
                registerUsername.BorderBrush = Brushes.Red;
            } else if (pw == "") {
                authentication.Visibility = Visibility.Visible;
                authentication.Text = "Fill out password in the field";
                registerPassword.BorderBrush = Brushes.Red;
            } else {
                if (!UserAccountManager.UserExists(un)) {
                    authentication.Visibility = Visibility.Hidden;
                    User newUser = new User(un, pw);
                    UserAccountManager.RegisterUser(newUser);

                    string exitText = "Registration successful, please login with new credentials";
                    string caption = "success!";
                    MessageBoxButton button = MessageBoxButton.OK;
                    if (MessageBox.Show(exitText, caption, button, MessageBoxImage.Question)
                    == MessageBoxResult.Yes) {
                        //Close();

                        var authWindow = new AuthorisationWindow();
                        authWindow.Show();

                        Window authParentWindow = Window.GetWindow(this); // Get the parent window to close
                        authParentWindow.Close();
                    }

                    var login = new AuthorisationWindow();
                    login.Show();

                    var myWindow = Window.GetWindow(this);
                    myWindow.Close();

                } else {
                    authentication.Visibility = Visibility.Visible;
                    authentication.Text = "User already exists!";
                }
            }

            //if (UserAccountManager.UserExists(newUser.username)) {
            //    UserAccountManager.RegisterUser(newUser);

            //    string exitText = "Registration successful, please login with new credentials";
            //    string caption = "Success!";
            //    MessageBoxButton button = MessageBoxButton.OK;

            //    // Alert to show success
            //    if (MessageBox.Show(exitText, caption, button, MessageBoxImage.Question)
            //        == MessageBoxResult.Yes) {
            //        //Close();

            //        var authWindow = new AuthorisationWindow();
            //        authWindow.Show();

            //        Window authParentWindow = Window.GetWindow(this); // Get the parent window to close
            //        authParentWindow.Close();
            //    }
            //} else {
            //    authentication.Visibility = Visibility.Visible;
            //}

        }
    }
}
