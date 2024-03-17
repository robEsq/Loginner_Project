using Assessment_LoginSystem.MVVM.Model;
using System.Collections;
using System.Windows.Controls;
namespace Assessment_LoginSystem.MVVM.View {
    /// <summary>
    /// Interaction logic for UserList.xaml
    /// </summary>
    public partial class UserListView : UserControl {
        public UserListView() {
            InitializeComponent();
            //Upon clicking the tab the page will
            //  run this command to fetch the data from the text file
            ArrayList UAL = UserAccountManager.ReadFile("Accounts.txt");

            foreach (User account in UAL) { 
                userListEntries.Items.Add(account.username);
            }
        }
    }
}
