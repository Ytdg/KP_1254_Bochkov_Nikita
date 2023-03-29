using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tests
{
    public partial class Form1 : Form
    {
        List<TestResult> results = new List<TestResult>();
        List<string> dinamicanswer= new List<string>(); /* ДИНИМАЧИЕСКИЕ ОТВЕТЫ*/
        TestResult All_Users = new TestResult(); 
        Random randanswer= new Random();
        

      

        public Form1()
        {
            InitializeComponent();
            InitComponent();
            
          
        }
        public void InitComponent()
        {

            NewUser();
            ClearAnswerLocal();


        }
        
   
        private void NewUser()
        {

            results.Add(new TestResult());
           

        }
        private void ClearAnswerLocal()
        {

            dinamicanswer.Clear();
            for (int i = 0; i < 9; i++)
            {
                dinamicanswer.Add("");

            }
        }


        
        private bool cheksavebuttom = false;


        private void SaveAnswer_Click(object sender, EventArgs e)
        {
            
            
            cheksavebuttom = true;
            AnswerUser();
            ItemClear();
           
         

            


        }
        bool chekloadresult= false;
        private void SaveInFile_Click(object sender, EventArgs e)
        {   int c = 0;
            if (ValidAnswer() &chekloadresult==false )
            {
                cheksavebuttom = false;
                SaveResultFile();
                ClearAnswerLocal();
                NewUser();
                c = c + 1;
            }
            if (ValidAnswer() & chekloadresult == true)
            {
                NewUser();
                SaveResultFile();
                ClearAnswerLocal();
                c = c + 1;

            }
            if (c == 0)
            {
                MessageBox.Show("Вы ответили не на все впоросы или забыли сохранить");
            }

        }
        



        private bool ValidAnswer()
        {
          foreach (string answer in dinamicanswer) { 

                if(answer.Trim()=="" | dinamicanswer[2].Trim() == "0")
                {

                    return false;
                }
                          
            }
          return true;
           
        }



        
        private int AnswerUser()
        {

            dinamicanswer[5] = "";
            foreach (Control item in groupBox1.Controls)
            {
                if (item.GetType() == typeof(Panel))
                {
                    foreach (Control its_item in item.Controls)
                    {
                        RadioButton one = its_item as RadioButton;
                        CheckBox two = its_item as CheckBox;
                        if (one != null && one.Checked)
                        {
                            dinamicanswer[4] = one.Text;
                        }
                        if (two != null && two.Checked)
                        {
                            dinamicanswer[5] = dinamicanswer[5] + two.Text + " ";
                        }


                    }
                }
            }
            dinamicanswer[6] = comboBox1.Text;
            dinamicanswer[7] = numericUpDown1.Value.ToString();
            dinamicanswer[8] = OpenAnswer.Text;
            dinamicanswer[0] = NameUser.Text;
            dinamicanswer[1] = LastUser.Text;
            dinamicanswer[2] = YearsUser.Value.ToString();
            dinamicanswer[3] = GroupUser.Text;
            if (GroupUser.Items.Contains(GroupUser.Text) == false)
            {
                GroupUser.Items.Add(GroupUser.Text);
            }


            return 0;

        }
        private void AllResults_SelectedIndexChanged(object sender, EventArgs e)

        {
            if (cheksavebuttom == true)
            {
                int index = AllResults.SelectedIndex;
                if (index != -1)
                {
                    AllResults.Items.Insert(index, dinamicanswer[index + 4]);
                    AllResults.Items.RemoveAt(index + 1);

                }

            }
            
        }

        private void ItemClear()
        {
            AllResults.Items.Clear();
            for (int i = 1; i < 5; i++)
            {
                AllResults.Items.Add("Ответ" + i);
            }


        }
        private void SaveResultFile()
        {
            
                results[results.Count - 1].NameUser = dinamicanswer[0].Replace(" ","");
                results[results.Count - 1].LastUser = dinamicanswer[1].Replace(" ","");
                results[results.Count - 1].YearsUser = Convert.ToInt32(dinamicanswer[2].Replace(" ",""));
            results[results.Count - 1].GroupUser = dinamicanswer[3].Replace(" ", "") ;
                results[results.Count - 1].Answer1 = dinamicanswer[4];
                results[results.Count - 1].Answer2 = dinamicanswer[5].Split(' ').ToList();
                results[results.Count - 1].Answer3 = dinamicanswer[6].Replace(" ", "");
                results[results.Count - 1].Answer4 = Convert.ToInt32(dinamicanswer[7].Replace(" ", ""));
                results[results.Count - 1].Answer5 = dinamicanswer[8];
                results[results.Count - 1].Serialize();
            
            

            

        }
        private void ClearAnswer_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Очистить форму?", "Предупреждение",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Exclamation);

            if (dialogResult == DialogResult.Yes)
            {
                ClearForm();
            }
                
            
        }

        private void ControlValueDefoltorRand(bool randresult=false,bool noloadresult=true, int index_chek_result_users=0)
        {
            if (noloadresult)
            {
                NameUser.Text = randresult == false ? "" : Convert.ToString((char)randanswer.Next(65, 91));
                LastUser.Text = randresult == false ? "" : Convert.ToString((char)randanswer.Next(65, 91));
                YearsUser.Value = randresult == false ? 0 : randanswer.Next(1, 100);
                GroupUser.Text = randresult == false ? "" : Convert.ToString((char)randanswer.Next(65, 91));
                comboBox1.Text = randresult == false ? "" : Convert.ToString((char)randanswer.Next(65, 91));
                numericUpDown1.Value = randresult == false ? 0 : randanswer.Next(1, 100);
                OpenAnswer.Text = randresult == false ? "" : Convert.ToString((char)randanswer.Next(65, 91));
            }
            else
            {
                NameUser.Text = results[index_chek_result_users].NameUser;
                LastUser.Text = results[index_chek_result_users].LastUser;
                YearsUser.Value = results[index_chek_result_users].YearsUser;
                GroupUser.Text = results[index_chek_result_users].GroupUser;
                comboBox1.Text = results[index_chek_result_users].Answer3;
                numericUpDown1.Value = results[index_chek_result_users].Answer4;
                OpenAnswer.Text = results[index_chek_result_users].Answer5;
            }
        }
        private void ClearForm()
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item.GetType() == typeof(Panel))
                {
                    foreach (Control its_item in item.Controls)
                    {
                        RadioButton one = its_item as RadioButton;
                        CheckBox two = its_item as CheckBox;
                        if (one != null)
                        {
                            one.Checked = true;
                        }
                        if (two != null)
                        {
                            two.Checked = false;
                        }


                    }
                }

            }
            ControlValueDefoltorRand();
            ItemClear();
            ClearAnswerLocal();
        }
        private void testrusult_Click(object sender, EventArgs e)
        {
            int c = 1;
            int k = 0;
            
            foreach (Control item in groupBox1.Controls)
            {
                if (item.GetType() == typeof(Panel))
                {
                    c = 1;
                    int randindexrb = randanswer.Next(1, 4);
                   
                    foreach (Control its_item in item.Controls)
                    {
                        RadioButton one = its_item as RadioButton;
                        CheckBox two = its_item as CheckBox;
                        if (one != null & c==randindexrb)
                        {
                            one.Checked = true;
                        }

                        if (two != null )
                        {   
                            two.Checked = Convert.ToBoolean(randanswer.Next(0,2));
                            k=two.Checked==true?k+ 1 :k;
                           
                        }
                        c++;

                    }
                }
                var  ff = string.Join(",",dinamicanswer);
            }
            checkBox1.Checked = k==0?true:checkBox1.Checked;
            ControlValueDefoltorRand(randresult:true);
        }
        bool chek_all_users=false;
        private void LoadFromFile_Click(object sender, EventArgs e)
        {
            int c = 0;
            
            if (All_Users.Deserialize(results,label12))
            {
                
                ItemResulUsers.Items.Clear();
                for (int i = 0; i < results.Count; i++)
                {
                    ItemResulUsers.Items.Add("Users" + i);
                    c++;
                }
                chek_all_users = c != 0 ? true : false;

            }
            
        }



        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void ItemResulUsers_SelectedIndexChanged(object sender, EventArgs e)
        { if (chek_all_users) {
                int index_chek_result_users = ItemResulUsers.SelectedIndex;
                label12.Text = results[0].Answer1;
                if (index_chek_result_users != -1) {
                    foreach (Control item in groupBox1.Controls)
                    {
                        if (item.GetType() == typeof(Panel))
                        {
                            foreach (Control its_item in item.Controls)
                            {
                                RadioButton one = its_item as RadioButton;
                                CheckBox two = its_item as CheckBox;
                                if (one != null )
                                {
                                    one.Checked = results[index_chek_result_users].Answer1 == one.Text?true:false;
                                }
                                if (two != null)
                                {
                                    int c = 0;
                                    foreach (var items in results[index_chek_result_users].Answer2)
                                    {
                                        if (two.Text == items)
                                        {
                                          
                                            c = c + 1;
                                        }
                                    }
                                    two.Checked = c==0?false:true;

                                }


                            }
                        }

                    }
                    ControlValueDefoltorRand(noloadresult: false, index_chek_result_users: index_chek_result_users);
                    ItemClear();
                    ClearAnswerLocal();
                    AnswerUser();
                    chekloadresult = true;

                }
            }
            else
            {

                MessageBox.Show("Вы не загрузили результаты либо они отсутвуют");
            }
        

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
