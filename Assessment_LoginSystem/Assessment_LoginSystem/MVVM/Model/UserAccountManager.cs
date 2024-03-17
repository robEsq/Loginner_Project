using Assessment_LoginSystem.MVVM.View;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_LoginSystem.MVVM.Model {
    class UserAccountManager {
        

        public static ArrayList ReadFile(string filePath) {
            UserAccounts userAccounts = new UserAccounts();

            // Used to read file then pass it to a List of User objects, the UserList class might be redundant but I cbf
            using (StreamReader sr = File.OpenText(filePath)) {
                string s = "";

                // 's' in this context already has the data from the text file
                while ((s = sr.ReadLine()) != null) {
                    string[] userInfo = s.Split(','); // Splits the words into an array
                    User tempUser = new User(userInfo[0], userInfo[1]); // Puts those array elements into the User object
                    userAccounts.AddUser(tempUser);
                }
            }

            return userAccounts.GetAllUsers();
        }
    }
}
