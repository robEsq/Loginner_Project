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
            registerPassword.Text = "AUTO GENERATED";
        }

        private void Register_Click(object sender, RoutedEventArgs e) {
            // Add Register funtionality here

            string exitText = "Registration successful, please login with new credentials";
            string caption = "Success!";
            MessageBoxButton button = MessageBoxButton.OK;

            // Alert to show success
            if (MessageBox.Show(exitText, caption, button, MessageBoxImage.Question)
                == MessageBoxResult.Yes) {
                //Close();
            }
            var authWindow = new AuthorisationWindow();
            authWindow.Show();

            Window authParentWindow = Window.GetWindow(this); // Get the parent window to close
            authParentWindow.Close();
        }
    }
}
