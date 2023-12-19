using APC.DAL.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace APC.AllForms
{
    public partial class FormViewDocument : Form
    {
        public FormViewDocument()
        {
            InitializeComponent();
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public DocumentDetailDTO detail = new DocumentDetailDTO();
        private void FormViewDocument_Load(object sender, EventArgs e)
        {
            labelWordsCount.Hide();
            this.Text = detail.DocumentName +" (" + detail.Date + ")";
            string filePath = System.Windows.Forms.Application.StartupPath + "\\documents\\" + detail.DocumentPath;
            if (detail.DocumentType == "Word Document")
            {
                ReadFiles.ReadWord(filePath, txtDocumentContent);
                string[] words = txtDocumentContent.Text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                labelWordsCount.Text = words.Length.ToString();
                labelWordsCount.Visible = true;
            }            
        }
    }
}
