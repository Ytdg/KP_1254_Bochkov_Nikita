using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
namespace Shifr
{
    public partial class Form1 : Form
    {   List<Encrypt> selectEncrypts = new List<Encrypt>();   
        public Form1()
        {
            InitializeComponent();
            lbxtype_shifr.DisplayMember = "name";
            lbxselect_type.DisplayMember = "name";


            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lbxtype_shifr.Items.Add(new Encrypt(GetIncSymbol, 'I', "Inc"));
            lbxtype_shifr.Items.Add(new Encrypt(GetDecSymbol, 'D', "Dec"));
            lbxtype_shifr.Items.Add(new Encrypt(GetZeroSymbol,'Z', "Zero"));
            lbxtype_shifr.Items.Add(new Encrypt(GetSubSymbol, 'S', "Sub"));
        }
      
        private void btngo_shifr_Click(object sender, EventArgs e)
        {
            string resultEncrypt = "";
            string keyResult = "";
            try {
                if (tbxwrite.Text.Replace(" ", "") != "")
                {
                    int indexOperation = 0;
                    foreach (char symbol in tbxwrite.Text)
                    {
                        if (indexOperation == selectEncrypts.Count) { indexOperation = 0; }
                        resultEncrypt += selectEncrypts[indexOperation].GetEncruptSymbol(symbol);
                        indexOperation++;
                    }
                    foreach (Encrypt item in selectEncrypts)
                    {
                        keyResult += item.key;
                    }
                }

                tbxresult.Text = resultEncrypt;
                tbxKeyShifr.Text = keyResult;
            }
            catch
            {
                new Exception();
            }
        }

        

        private void btnclear_select_Click(object sender, EventArgs e)
        {
            lbxselect_type.Items.Clear();
            selectEncrypts.Clear();
        }

        private void lbxtype_shifr_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxselect_type.Items.Add(lbxtype_shifr.SelectedItem);
            selectEncrypts.Add(lbxtype_shifr.SelectedItem as Encrypt);

        }
        
        
        private void tbxwrite_TextChanged(object sender, EventArgs e)
        {
            TextBox texbox=(TextBox)sender;
            if (texbox != null)
            {
                foreach (char s in texbox.Text)
                {
                    int n = (int)s;

                    if ((n >= 1040 & n <= 1103) | (n == 1025 | n == 1105))
                    {

                        texbox.Text = texbox.Text.Replace(Convert.ToString(s), "");
                    }
                }
            }
        }
        public char GetIncSymbol(char symbol)
        {
            return (char)((int)symbol + 1);
        }
        public char GetDecSymbol(char symbol)
        {
            return (char)((int)symbol - 1);
        }
        public char GetSubSymbol(char symbol)
        {
            char str = (char)(255 - (int)symbol);
           



            return str;
        }
        public char GetZeroSymbol(char symbol)
        {
            return symbol;
        }
        private void Reverse(int index,int typeoperation) {
            Encrypt item_one = selectEncrypts[index];
            selectEncrypts[index] = selectEncrypts[index + typeoperation];
            selectEncrypts[index + typeoperation] = item_one;
            lbxselect_type.Items.Clear();
            foreach (Encrypt item in selectEncrypts)
            {
                lbxselect_type.Items.Add(item);
            }
        }
       
        private void bntReverse_Click(object sender, EventArgs e)
        {
            int index = lbxselect_type.SelectedIndex;

            Button btnOperation = (Button)sender;
            if (btnOperation.Name == bntUp.Name)
            {
                if (index != -1 & index != 0)
                {
                    Reverse(index, -1);
                }

            }
            if (btnOperation.Name == btnDown.Name)
            {
                if (index != -1 & index != lbxselect_type.Items.Count - 1)
                {
                    Reverse(index, 1);
                }
            }
        }

        private void btngoDecrypt_Click(object sender, EventArgs e)
        {
            if (tbxresult.Text.Replace(" ", "") != ""&tbxKeyShifr.Text!="")
            {
                tbxDecryptedText.Text = new Decryptor().Decrypt(tbxKeyShifr.Text, tbxresult.Text);
            }
        }

        private void tbxKeyShifr_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in tbxKeyShifr.Text)
            {
                if (item != 'I' & item != 'D' & item != 'S' & item != 'Z')
                {
                    tbxKeyShifr.Text=tbxKeyShifr.Text.Replace(Convert.ToString(item), "");
                }
            }
        }
    }
}
