using System;
using System.Collections;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        #region Start
        TXTextControl.SaveSettings saveSettings = new TXTextControl.SaveSettings();
        ArrayList people = new ArrayList();
        public Form1()
        {
            InitializeComponent(); 
        }
        #endregion

        #region CalculatorTab
        double currentSum = 0;
        double currentNum = 0;
        char currentOp = 'a';
        Boolean negative = false;
        Boolean newSum = false;
        short decimalLevel = 0;
        private void oneButton_Click(object sender, EventArgs e)
        {
            ClickNumber(1);
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            ClickNumber(2);
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            ClickNumber(3);
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            ClickNumber(4);
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            ClickNumber(5);
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            ClickNumber(6);
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            ClickNumber(7);
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            ClickNumber(8);
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            ClickNumber(9);
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            ClickNumber(0);
        }
        
        private void dotButton_Click(object sender, EventArgs e)
        {
            if (newSum)
            {
                outputLabel.Text = "";
                currentSum = 0;
                newSum = false;
            }
            outputLabel.Text += ".";
            decimalLevel = 1;
        }

        private void ClickNumber(int num)
        {
            if (newSum)
            {
                outputLabel.Text = "";
                currentSum = 0;
                newSum = false;
            }
            outputLabel.Text += num;
            if (decimalLevel == 0)
            {
                currentNum = currentNum * 10 + num;
            }
            else
            {
                currentNum += num / Math.Pow(10, decimalLevel);
                decimalLevel++;
            }
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text += "+";
            UpdateSum();
            currentOp = 'a';
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text += "-";
            if (!negative) UpdateSum();
            negative = !negative;
            currentOp = 'a';
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text += "x";
            UpdateSum();
            currentOp = 'm';
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text += "÷";
            UpdateSum();
            currentOp = 'd';
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            UpdateSum();
            outputLabel.Text = currentSum.ToString();
            currentOp = 'a';
            newSum = true;
        }

        private void UpdateSum()
        {
            if (newSum)
            {
                newSum = false;
            }

            if (negative) currentNum *= -1;

            switch (currentOp)
            {
                case 'a':
                    currentSum += currentNum;
                    break;
                case 'm':
                    currentSum *= currentNum;
                    break;
                case 'd':
                    currentSum /= currentNum;
                    break;
            }
            currentNum = 0;
            negative = false;
            decimalLevel = 0;
        }
        #endregion

        #region TextControlTab
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textControl.Load(TXTextControl.StreamType.PlainText);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textControl.Save(TXTextControl.StreamType.PlainText, saveSettings);
        }

        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveSettings.SavedFile.Equals(""))
            {
                textControl.Save(TXTextControl.StreamType.PlainText, saveSettings);
            }
            
            PopupEmailForm popup = new PopupEmailForm(saveSettings.SavedFile);
            popup.ShowDialog();
            popup.Dispose();
        }

        #endregion

        #region HexTab
        private void button1_Click(object sender, EventArgs e)
        {
            convertToHex();
        }
        
        private void stringTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                convertToHex();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void convertToHex()
        {
            StringBuilder sb = new StringBuilder();
            foreach (char t in stringTextBox.Text)
            {
                sb.Append(Convert.ToInt32(t).ToString("x"));
            }
            hexLabel.Text = sb.ToString();
        }

        #endregion

        #region WebPageTab
        private void webButton_Click(object sender, EventArgs e)
        {
            searchURL();
        }
        private void webTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchURL();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void searchURL()
        {
            string address = webTextBox.Text;
            if (String.IsNullOrEmpty(address)) return;
            if (address.Equals("about:blank")) return;
            if ((!address.StartsWith("http://")) && (!address.StartsWith("https://")))
            {
                address = "http://" + address;
            }
            try
            {
                webBrowser.ScriptErrorsSuppressed = true;
                webBrowser.Navigate(new Uri(address));
            }
            catch (System.UriFormatException)
            {
                return;
            }
        }

        private void myWebButton_Click(object sender, EventArgs e)
        {
            try
            {
                webBrowser.ScriptErrorsSuppressed = true;
                webBrowser.Navigate(new Uri(@"C:/Users/GTidd/source/repos/WindowsFormsApp4/WindowsFormsApp4/html/index.html"));
            }
            catch (System.UriFormatException)
            {
                return;
            }
        }


        #endregion

        #region MailMerge
        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textControl.Text = textControl.Text + "<<NAME>>";
        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textControl.Text = textControl.Text + "<<COMPANY>>";
        }

        private void costToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textControl.Text = textControl.Text + "<<COST>>";
        }
        
        private void mergeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PopupEmailForm popup = new PopupEmailForm();
            if (popup.ShowDialog() == DialogResult.OK)
            {
                string subject = popup.getSubject();
                
                foreach (Person person in people)
                {
                    textControl.Text = textControl.Text.Replace("<<NAME>>", person.getName());
                    textControl.Text = textControl.Text.Replace("<<COMPANY>>", person.getCompany());
                    textControl.Text = textControl.Text.Replace("<<COST>>", person.getCost());
                    popup.email(person.getEmail(), subject, textControl.Text);
                    textControl.Text = textControl.Text.Replace(person.getName(), "<<NAME>>");
                    textControl.Text = textControl.Text.Replace(person.getCompany(), "<<COMPANY>>");
                    textControl.Text = textControl.Text.Replace(person.getCost(), "<<COST>>");
                }
                MessageBox.Show("Sent Successfully", "Done");
                popup.Dispose();
            }
        }

        private void addPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PopupAddPerson popup = new PopupAddPerson();
            popup.ShowDialog();
            Person person = popup.getPerson();
            people.Add(person);
            popup.Dispose();
        }

        #endregion

    }
}

#region Person
public class Person
{

    private string email;
    private string name;
    private string company;
    private string cost;

    public Person(string email, string name, string company, string cost)
    {
        this.email = email;
        this.name = name;
        this.company = company;
        this.cost = cost;
    }

    public string getEmail() => email;
    public string getName() => name;
    public string getCompany() => company;
    public string getCost() => cost;

}
#endregion