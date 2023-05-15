using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginAcc
{
    public partial class Form1 : Form
    {
        public List<Account> users { get; set; }
        public Account thisUser { get; set; } = new Account();   
        Dictionary<string,string>translate= new Dictionary<string, string>() {
                {"а","a"},
                {"б","b"},
                {"в","v"},
                {"г","g"},
                {"д","d"},
                {"е","e"},
                {"ё","yo"},
                {"ж","zh"},
                {"з","z"},
                {"и","i"},
                {"й","y"},
                {"к","k"},
                {"л","l"},
                {"м","m"},
                {"н","n"},
                {"о","o"},
                {"п","p"},
                {"р","r"},
                {"с","s"},
                {"т","t"},
                {"у","u"},
                {"ф","f"},
                {"х","h"},
                {"ц","ts"},
                {"ч","ch"},
                {"ш","sh"},
                {"щ","sch"},
                {"ъ","'"},
                {"ы","yi"},
                {"ь",""},
                {"э","e"},
                {"ю","yu"},
                {"я","ya"},
                





        };
        Process procces= new Process();
        
        
        

        public Form1()
        {
            InitializeComponent();
            CreateProcc();
          
            
        }

      
        
        
        private void CreateProcc()
        {
            
            

            procces.StartInfo = new ProcessStartInfo()
            {

                FileName = Directory.GetCurrentDirectory() + "/GetPassword.exe",

                UseShellExecute = false,

                CreateNoWindow = true,

                RedirectStandardOutput = true,


            };
            
         
        }
       
        
       
        private void saveIn_Click(object sender, EventArgs e)
        {
            if (ValidAnswer())
            {  int index=AllUSers.SelectedIndex;
               if(index != -1) { Account user = AllUSers.Items[index] as Account;
                    user.name = NameU.Text;
                    user.lastName = LastNameU.Text;
                    user.password = PasswordU.Text; 
                    user.login = LoginU.Text;
                    AllUSers.Items[index]=user;
                }
                AllUSers.Update();
            }
            else
            {
                MessageBox.Show("Неккоректные параметры или такой Login уже существует");
            }


        }
        private void AllUSers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = AllUSers.SelectedIndex;
            if (index != -1)
            {   Account user = AllUSers.Items[index] as Account;
                NameU.Text = user.name;
                LastNameU.Text = user.lastName;
                LoginU.Text = user.login;
                PasswordU.Text = user.password;
               
                if (thisUser.permissions == Account.Permissions.CommonUser)
                {
                    if (thisUser.login == user.login) { CapabilitiesCommonUser(true); }
                    else { CapabilitiesCommonUser(false); }
                }
                
            }
        }

        private void NameU_TextChanged(object sender, EventArgs e)
        {
            string res_string = "";
            LoginU.Enabled = true;
            try
            {
                foreach (char gets in NameU.Text)
                {
                    string convertgets = Convert.ToString(gets);
                    convertgets = convertgets.ToUpper() == convertgets ? translate[convertgets.ToLower()].ToUpper() : translate[convertgets];
                    res_string = res_string + convertgets;
                }
                LoginU.Text = res_string;
            }
            catch { LoginU.Text = "#error";LoginU.Enabled = false; }
            
            
        }
        private bool ValidAnswer()
        {

            foreach (Control item in firstGroup.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Text.Replace(" ", "") == "")
                    {
                        return false;
                    }
                    if (item.Name == "LoginU")
                    {
                        foreach (char g in item.Text)
                        { int chek = (int)g;
                            if ((chek < 65 | (chek > 90 & chek < 97) | chek > 122) & g != '-' & g != '_' & g != '@')
                            {

                                return false;
                            }
                        }

                    }
                }
            }
            if (rbntypeAdmin.Checked == false&rbntypeUser.Checked==false) { return false; }
            foreach(Account s in users)
            {
                if (LoginU.Text == s.login)
                {
               
                    return false;
                }
            }
            return true;
        }
        
        private void GenPass_Click(object sender, EventArgs e)
        {
            
            string parametrs_password = "";
            if (LenPasP.Text.Replace(" ","") != "")
            {
                parametrs_password=parametrs_password+LenPasP.Text+" ";
            }
            if(CountNumberP.Text.Replace(" ", "") != "")
            {
                parametrs_password=parametrs_password+ lbDigitsP.Text + CountNumberP.Text+" ";
            }
            if(CountLettersP.Text.Replace(" ", "") != "")
            {
                parametrs_password=parametrs_password+lbLettersP.Text + CountLettersP.Text+" ";
            }
            if (CheckUpperCaseP.Checked)
            {
                parametrs_password = parametrs_password + "-u ";
            }
            if(CheckSpecialP.Checked)
            {
                parametrs_password = parametrs_password + "-s ";
            }
            procces.StartInfo.Arguments = parametrs_password;
            procces.Start();
            PasswordU.Text = procces.StandardOutput.ReadLine();
            procces.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thisUser.permissions != Account.Permissions.Guest)
            {
                Account.Serelization(users);
            }
            Application.Exit();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
                AllUSers.DisplayMember = "name";
                ChekUser();

            
            foreach (Account item in users)
                {
                switch (thisUser.permissions)
                {
                    case Account.Permissions.Guest:
                        if(item.permissions==Account.Permissions.CommonUser) {AllUSers.Items.Add(item);
                         
                        }
                        break;
                    case Account.Permissions.Admin:
                        AllUSers.Items.Add(item);
                           
                        break;
                    case Account.Permissions.CommonUser:
                        AllUSers.Items.Add(item);  break;
                }
               
                }
            if (thisUser.permissions == Account.Permissions.Guest) { CapabilitiesGuest(); }
            if (thisUser.permissions == Account.Permissions.CommonUser) { CapabilitiesCommonUser(false);label5.Text = thisUser.name; }
         
           
            
                
        }
        private void CapabilitiesGuest()
        {
            foreach(Control item in this.Controls)
            {
                if (item.GetType() != AllUSers.GetType())
                {
                    item.Enabled = false;
                }
            }
            LoginU.Visible = false;
            PasswordU.Visible = false;

        }
        private void CapabilitiesCommonUser(bool chekerData)
        {
           
            if (chekerData)
            {
                foreach (Control item in this.Controls)
                {
                  
                    item.Enabled = true;
                }
                PasswordU.Visible = true;
                LoginU.Enabled = true;
            }
            else
            {
                
                foreach (Control item in this.Controls)
                {
                    if (item.Name!= "AllUSers"&item.Name!= "groupbox1") {
                        item.Enabled = false; }
                }
                PasswordU.Visible = false;
            }
            btnRemoveUser.Enabled = false;
            button1.Enabled = false;
        }

        private void rbntypeAdmin_CheckedChanged(object sender, EventArgs e)
        {
            AllUSers.Items.Clear();
          
            foreach(Account user in users)
            {
                if (user.permissions == Account.Permissions.Admin) { AllUSers.Items.Add(user); }
            }
        }

        private void rbntypeUser_CheckedChanged(object sender, EventArgs e)
        {
            AllUSers.Items.Clear();
            foreach (Account user in users)
            {
                if (user.permissions == Account.Permissions.CommonUser) { AllUSers.Items.Add(user); }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidAnswer()&(rbntypeAdmin.Checked|rbntypeUser.Checked))
            {
                Account user = new Account()
                {
                    lastName = LastNameU.Text,
                    name = NameU.Text,
                    password = PasswordU.Text,
                    login = LoginU.Text,
                    permissions = rbntypeAdmin.Checked ? Account.Permissions.Admin : Account.Permissions.CommonUser
                };
                AllUSers.Items.Add(user);
                AllUSers.SelectedIndex=AllUSers.Items.Count-1;
                users.Add(user);
                
            }
            else { MessageBox.Show("Неккоректные параметры или такой Login уже существует"); }
           
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            int index = AllUSers.SelectedIndex;
            if (index != -1) {
                Account user = AllUSers.Items[index] as Account;
                if (user != null&&user.login!=thisUser.login) {users.Remove(user); AllUSers.Items.RemoveAt(index); }
                
             
            }
            else { MessageBox.Show("Выберете usera"); }
        }
        async private void ChekUser()
        {

            await Task.Run(() =>
            {
                while (true) {
                if(AllUSers.SelectedIndex !=-1) { saveIn.Enabled = true; }
                    else { saveIn.Enabled = false; }
                }
            });
        }
    }
}
