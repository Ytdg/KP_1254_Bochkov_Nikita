using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginAcc
{
    public  class Account
    {
       public string name { get; set; }
       public string lastName { get; set; }
       public string login { get; set; }
       public string password { get; set; }
        public Permissions permissions { get; set; }
        [Flags]
        public enum Permissions
        {
            None = 0,
            ViewUsers = 1,
            ViewAdmins = 2,
            EditSelf = 4,
            EditOther = 8,
            ViewPasswords = 16,
 

             Guest = ViewUsers,
            CommonUser = ViewAdmins | ViewUsers|EditSelf,
            Admin = CommonUser | EditOther|ViewPasswords
        }


        public static void Serelization(List<Account> users)
        {

            string basicData;
            string secondaryData;
            StreamWriter writerSD = new StreamWriter(new FileStream(ConfData.secondaryDatapath, FileMode.Create, FileAccess.Write));
            StreamWriter writerBD = new StreamWriter(new FileStream(ConfData.basicDatapath, FileMode.Create, FileAccess.Write));
            foreach (var user in users)
                {
                    basicData = "{ " + "Login: " + $"{user.login}" + " , Password: " + $"{user.password}" + " }";
                    secondaryData = "{ " + "Name: " + $"{user.name}" + " , LastName: " + $"{user.lastName}" + " , Login: " + $"{user.login}" + " , TypeUser: " + $"{user.permissions}"+" }";
                   writerBD.WriteLine(basicData);
                    writerSD.WriteLine(secondaryData);
                }
                writerSD.Close();
                writerBD.Close();

        }
        public static List<Account> Deserealize()
        {   List<Account> users = new List<Account>();


            if (File.Exists(ConfData.basicDatapath))
            {
                foreach (string item in File.ReadLines(ConfData.secondaryDatapath))
                {

                    string[] data = item.Replace("{ ", "").Replace(" }", "").Replace(": ", " ").Replace(" , ", " ").Split(' ');
                    Permissions type_user = 0;
                    if (Enum.TryParse(data[7], out Permissions result))
                    {
                        type_user = result;
                    }
                    users.Add(new Account() { name = data[1], lastName = data[3], login = data[5], permissions = type_user });
                }
                int index = 0;
                foreach (string item in File.ReadLines(ConfData.basicDatapath))
                {
                    string[] data = item.Replace("{ ", "").Replace(" }", "").Replace(": ", " ").Replace(" , ", " ").Split(' ');
                    users[index].password = data[3];
                    index++;
                }
                return users;
            }
            else { return users; }
        
            
        }
       
       

       

    }
}
