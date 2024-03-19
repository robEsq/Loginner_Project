using Assessment_LoginSystem.MVVM.Model;
using System.Windows;
using System.Windows.Controls;

namespace Assessment_LoginSystem.MVVM.View {
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class LoginView : UserControl {
        public LoginView() {
            InitializeComponent();
        }
        //private void CloseButton_Click(object sender, RoutedEventArgs e) {
        //    string exitText = "Are you sure you want to quit?";
        //    string caption = "Exit";
        //    MessageBoxButton button = MessageBoxButton.YesNo;

        //    // Asks user before quitting
        //    if (MessageBox.Show(exitText, caption, button, MessageBoxImage.Question)
        //        == MessageBoxResult.Yes) {
        //        var loginRegistraion = Window.GetWindow(this); // Way to get the current window
        //        loginRegistraion.Close();
        //    }
        //}

        //private void ToRegistration_Click(object sender, RoutedEventArgs e) {

        //}
        private void LoginButton_Click(object sender, RoutedEventArgs e) {
            // Add login funtionality here
            UserAccountManager UAM = new UserAccountManager();

            if (UAM.Login(username.Text, password.Password) == true) {
                var mainWindow = new MainWindow();
                mainWindow.Show();

                Window authParentWindow = Window.GetWindow(this); // Get the parent window to close
                authParentWindow.Close();
            } else {
                authentication.Visibility = Visibility.Visible;
            }
            //UAM.Login(username.Text, password.Text);
            //UserAccountManager.ReadFile("accounts.txt");


            
        }
    }
}
