using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Mail
{
    public partial class Form1 : Form
    {
        private List<string> attachments = new List<string>(); // Прикрепленные файлы
        public static string Login; // Логин отправителя
        public static string Password;// Пароль отправителя
        public static string Port;  // Порт
        public static string Host; // Хост

        [Obsolete]
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        [Obsolete]
        private void sendMessge_Click(object sender, EventArgs e) // Уведомление об успешной отправке письма
        {
            SendMessage();
        }

        [Obsolete]
        private void SendMessage() //Создание и отправка письма
        {
            try
            {
                string[] recipients = adressRecipient.Text.Split(new char[] { ';' });

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(Login);

                foreach (var item in recipients)
                {
                    mail.To.Add(new MailAddress(item)); // Адрес получателя
                }

                foreach (var item in attachments)
                {
                    mail.Attachments.Add(new Attachment(item)); // Прикрепленные файлы
                }

                mail.Subject = subjectMessage.Text;
                mail.Body = textMessage.Text;

                SmtpClient client = new SmtpClient($"smtp.{Host}", int.Parse(Port));
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(Login, Password);
                client.Send(mail);
                MessageBox.Show("Письмо отправлено!");
                ClearFieldOnForm();
            } catch (ArgumentNullException e) {

                MessageBox.Show(e.Message);
            }
        }

        private void ClearFieldOnForm() //Очистка полей письма
        {
            attachments.Clear();
            adressRecipient.Text = String.Empty;
            subjectMessage.Text = String.Empty;
            textMessage.Text = String.Empty;
            listFileName.Items.Clear();
        }

        private void addFile_Click(object sender, EventArgs e) //Прикрепление файлов к письму
        {
            OpenFileDialog nameFile = new OpenFileDialog();
            
            if (nameFile.ShowDialog() == DialogResult.OK)
            {
                attachments.Add(nameFile.FileName);
                listFileName.Items.Add($"\n{attachments.Last()}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Authorize authorization = new Authorize();
            authorization.Show();
        }

        private void deleteItem(object sender, MouseEventArgs e)
        {
            attachments.RemoveAt(listFileName.SelectedIndex);
            listFileName.Items.RemoveAt(listFileName.SelectedIndex);
        }
    }
}
