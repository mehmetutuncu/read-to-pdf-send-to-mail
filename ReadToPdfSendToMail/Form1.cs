using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.Net.Mail;

namespace ReadToPdfSendToMail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\";
            
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);
            string pdf_path = dir.FullName + "pdf";
            
            string[] dizindekiDosyalar = Directory.GetFiles(pdf_path);
            foreach (string dosya in dizindekiDosyalar)
            {
                FileInfo fileInfo = new FileInfo(dosya);
                string dosyaAdi = fileInfo.Name;
                long byteBoyut = fileInfo.Length;
                DateTime olsTarihi = fileInfo.CreationTime;
                ListViewItem item = new ListViewItem(dosyaAdi);
                item.SubItems.Add("Dosya");
                item.SubItems.Add(byteBoyut.ToString());
                item.SubItems.Add(olsTarihi.ToString("dd.MM.yyyy HH:mm"));
                dizinIcerigiListView.Items.Add(item);
                readToPdf(pdf_path +@"\"+ fileInfo.Name);
            }
            
        }
        private void readToPdf(string pdf)
        {
            
            PdfReader reader = new PdfReader(pdf);
            string text = string.Empty;
            for (int page = 1; page <= reader.NumberOfPages; page++)
            {
                text += PdfTextExtractor.GetTextFromPage(reader, page);
            }
            reader.Close();
            List<string> lines = new List<string>();
            Match match = Regex.Match(text, "^.*$", RegexOptions.Multiline | RegexOptions.RightToLeft);

            while (match.Success && lines.Count < text.Length)
            {
                lines.Insert(0, match.Value);
                match = match.NextMatch();
            }

            string mail = lines.Last();
            listViewEmail.Items.Add(mail);
            try
            {
                SmtpClient client = new SmtpClient("smtp-mail.outlook.com", 587);
                MailMessage message = new MailMessage();
                message.From = new MailAddress("mehmetyusuftutuncu@outlook.com");
                message.To.Add(mail);
                message.Body = "Your message body";
                message.Subject = "Your message subject";
                client.UseDefaultCredentials = false;
                client.EnableSsl = true;
                message.Attachments.Add(new Attachment(pdf));
                client.Credentials = new System.Net.NetworkCredential("youremailadress", "yourpassword");
                client.Send(message);
                message = null;
                listIsSended.Items.Add("Mail sent");


            }
            catch(Exception exception)
            {
                listIsSended.Items.Add("Mail sent failed!");
            }



        }

        
    }
}
