using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Tests
{
    internal class TestResult
    {
        public string NameUser {get;set}
        public string LastUser {get;set}
        public int YearsUser {get;set}
        public string GroupUser {get;set}
        public string Answer1 {get;set}
        public List<string> Answer2 {get;set} = new List<string>()
        public string Answer3 {get;set}
        public decimal Answer4 {get;set}
        public string Answer5 {get;set}


        public void Serialize()

        {

            string path = Path.Combine(Directory.GetCurrentDirectory(), "opros.json");

            string creat_text = "[{" + "\"NameUser\"" + ": " + $"\"{this.NameUser}\"" + "," + "\"LastName\"" + ": " + $"\"{this.LastUser}\"" + "," + "\"Age\"" + ": " + this.YearsUser + "," + "\"GroupNumber\"" + ": " + $"\"{this.GroupUser}\"" + "," + "\"LoveNature\"" + ": " + $"\"{this.Answer1}\"" + "," + "\"LikeAnimals\"" + ": " + $"\"[{string.Join(",", this.Answer2).TrimEnd(',')}]\"" + "," + "\"AboutEcologi\"" + ": " + $"\"{this.Answer3}\"" + "," + "\"CountMyAnimals\"" + ": " + $"{this.Answer4}" + "," + "\"HowSaveNature\"" + ": " + $"\"{this.Answer5}\"" + "}]";
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(creat_text);
                sw.Close();
            }


        }
        public bool Deserialize(List<TestResult> results, Label lb)
        {

            if (File.Exists(Directory.GetCurrentDirectory()+ "/opros.json"))
            {
                var user = System.IO.File.ReadAllLines("opros.json");
                if (user.Length != 0)
                {
                    results.Clear();
                    foreach (var answer in user)
                    {
                        string format = answer.Replace("\"HowSaveNature\"", "*");
                        string[] result = format.Replace((char)34 + ":" + " " + (char)34, " ").Replace((char)34 + "," + (char)34, " ").Replace("," + (char)34, " ").Replace("," + "*", " ").Split(' ');
                        string answerOpen = format.Substring(format.IndexOf("*"), format.LastIndexOf("}") - format.IndexOf("*"));
                        answerOpen = answerOpen.Substring(answerOpen.IndexOf(Convert.ToString((char)34)) + 1, answerOpen.LastIndexOf(Convert.ToString((char)34)) - answerOpen.IndexOf(Convert.ToString((char)34)) - 1);
                        results.Add(new TestResult());
                        results[results.Count - 1].NameUser = result[1];
                        results[results.Count - 1].LastUser = result[3];
                
                        results[results.Count - 1].YearsUser = Convert.ToInt32(result[5]);
                        results[results.Count - 1].GroupUser = result[7];
                        results[results.Count - 1].Answer1 = result[9];
                        foreach (var item in result[11].Replace("[", "").Replace("]", "").Replace(",", " ").Split(' '))
                        {
                            results[results.Count - 1].Answer2.Add(item);

                        }
                        results[results.Count - 1].Answer3 = result[13];
                        results[results.Count - 1].Answer4 = Convert.ToInt32(result[15]);
                        results[results.Count - 1].Answer5 = answerOpen;

                    }
                   


                    return true;
                }
                else
                {
                    MessageBox.Show("Файл пустой");
                    return false;
                }

            }
            else
            {
                MessageBox.Show("Файл не найден");
                return false;
            }




        }
    }
}
