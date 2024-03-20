using System.Collections;

namespace Assessment_LoginSystem.MVVM.Model {
    // This class holds all the users and returns a list of them.
    class UserAccounts {
        private ArrayList userList = new ArrayList();

        public void AddUser(User user) {
            userList.Add(user);
        }

        public ArrayList GetAllUsers() {
            return userList;
        }
    }
}
