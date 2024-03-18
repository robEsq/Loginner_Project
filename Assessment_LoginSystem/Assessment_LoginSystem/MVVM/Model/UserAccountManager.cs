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
        public static UserAccounts? userAccounts { get; set; }
        public static string accounts = "accounts.txt"; // Not sure if hard coding it is good practice

        public bool Login(string username, string password) {
            foreach (User user in ReadFile(accounts)) {
                if (user.username == username && user.password == password) {
                    return true;
                }
            }
            return false;
        }

        public static bool UserExists(string username) {
            // Extracts current list of users for validation
            ArrayList userAccountList = new ArrayList();

            foreach (User i in ReadFile(accounts)) {
                userAccountList.Add(i.username);
            }

            // Check if the entered user does not exist first
            if (userAccountList.Contains(username) == true) {
                return true;
            } 
                return false;
            
        }

        public static void RegisterUser(User user) {
            string userInfo = $"{user.username},{user.password}";
            //Creates file if it does not exist
            if (!File.Exists("accounts.txt")) {
                using (StreamWriter sw = File.CreateText("accounts.txt")) {
                    sw.WriteLine(userInfo);
                }
            } else {
                using (StreamWriter sw = File.AppendText("accounts.txt")) {
                    sw.WriteLine(userInfo);
                }
            }
        }

        public static string GenerateRandomPassword() {
            Random rnd = new Random();
            char a;
            string password = "";

            for (int i = 0; i < 10; i++) {
                a = (char)rnd.Next(33, 126);
                password += a;
            }

            return password;
        }

        public static ArrayList ReadFile(string filePath) {
            //UserAccounts userAccounts = new UserAccounts();
            userAccounts = new UserAccounts();

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
