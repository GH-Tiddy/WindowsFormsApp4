using System;
using System.ComponentModel;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class PopupEmailForm : Form
    {
        #region General
        string fileName;
        bool isMailMerge;
        string subject;
        string body;
        public PopupEmailForm(string fileName)
        {
            InitializeComponent();
            this.fileName = fileName;
            isMailMerge = false;
        }

        public PopupEmailForm()
        {
            InitializeComponent();
            isMailMerge = true;
        }

        private void PopupEmailForm_Load(object sender, EventArgs e)
        {
            if (isMailMerge)
            {
                emailLabel.Visible = false;
                emailTextBox.Visible = false;
                messageLabel.Visible = false;
                messageTextBox.Visible = false;
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (isMailMerge)
            {
                subject = subjectTextBox.Text;
                DialogResult = DialogResult.OK;
            }
            else
            {
                email(emailTextBox.Text, subjectTextBox.Text, messageTextBox.Text);
            }
            
        }
        
        public string getSubject() => subject;
        #endregion

        #region SendEmail
        public void email(string email, string subject, string body)
        {
            SmtpClient smtpClient = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("ghdev846@gmail.com", "turrudydbiulcwdo"),
            };

            MailMessage message = new MailMessage()
            {
                From = new MailAddress("ghdev846@gmail.com"),
                Subject = subject,
                Body = body
            };
            message.To.Add(email);
            if (!isMailMerge) message.Attachments.Add(new Attachment(fileName));
            smtpClient.SendCompleted += SmtpClient_SendCompleted;
            smtpClient.SendMailAsync(message);
        }

        private void SmtpClient_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show("An error has occured \n" + e.Error.Message, "Error");
                DialogResult = DialogResult.Abort;
            }
            else
            {
                if (!isMailMerge) MessageBox.Show("Sent Sucesfully", "Done");
                DialogResult = DialogResult.OK;
            }
        }
        #endregion

    }
}
