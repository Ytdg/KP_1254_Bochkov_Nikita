using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginAcc
{
    public partial class LoginForm : Form
    {   
        public Form MainForm { get; set; }
        Form1 window = new Form1();
        List<Account> users;
        
        
        
        public LoginForm()
        {
            InitializeComponent();
            users = Account.Deserealize();
            window.users = users;

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (users.Count == 0)
            {
              
                button2.Visible = true;
            }

        }
        
       

        private void btnavtorisation_Click(object sender, EventArgs e)
        {
            foreach (Account item in users)
            {
                if (item.login == tbxlogin.Text & item.password == tbxpassword.Text)
                {
                    window.thisUser = item;
                    window.Show();
                    this.Visible = false;


                }
                
            }
           
            if (this.Visible) {
                label3.Visible = true;
               
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            window.thisUser.permissions = Account.Permissions.Guest;
            window.Show();

            this.Visible = false;
         
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            users.Add(new Account() { lastName="Test",name="Тест",password="12345678",
                login="Test",permissions=Account.Permissions.Admin});
            Account.Serelization(users);
            Application.Restart();
        }
    }
}
