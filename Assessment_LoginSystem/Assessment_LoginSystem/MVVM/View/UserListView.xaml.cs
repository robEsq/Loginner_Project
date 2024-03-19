using Assessment_LoginSystem.MVVM.Model;
using System;
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
            int index = 1;
            foreach (User account in UAL) {
                userListEntries.Items.Add(new userEntry() {
                    ID = index++,
                    Username = account.username
                }); ;
            }
        }

        public class userEntry {
            public int ID { get; set; }
            public string? Username { get; set; }
        }
    }
}
