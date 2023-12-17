using APC.BLL;
using APC.DAL.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APC
{
    public partial class FormEvent : Form
    {
        public FormEvent()
        {
            InitializeComponent();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        EventsBLL bll = new EventsBLL();
        public EventsDetailDTO detail = new EventsDetailDTO();
        public bool isUpdate = false;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text.Trim()=="")
            {
                MessageBox.Show("Enter event title");
            }
            else
            {
                if (!isUpdate)
                {
                    EventsDetailDTO events = new EventsDetailDTO();
                    events.EventTitle = txtTitle.Text;
                    events.Summary = txtSummary.Text;
                    events.CoverImagePath = fileName;
                    events.Day = dateTimePickerEvent.Value.Day;
                    events.MonthID = dateTimePickerEvent.Value.Month;
                    events.Year = dateTimePickerEvent.Value.Year.ToString();
                    if (bll.Insert(events))
                    {
                        MessageBox.Show("Event was added");
                        try
                        {
                            File.Copy(txtImagePath.Text, @"images\\" + fileName);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Cannot find the path to this picture");
                        }
                        txtSummary.Clear();
                        txtTitle.Clear();
                        txtImagePath.Clear();
                        picEventCoverImage.Image = null;
                        dateTimePickerEvent.Value = DateTime.Today;
                    }
                }
                else if (isUpdate)
                {
                    if (detail.Day == dateTimePickerEvent.Value.Day && detail.MonthID == dateTimePickerEvent.Value.Month 
                        && detail.Year == dateTimePickerEvent.Value.Year.ToString() && txtTitle.Text.Trim() == detail.EventTitle
                        && detail.Summary == txtSummary.Text.Trim() && detail.CoverImagePath == txtImagePath.Text.Trim())
                    {
                        MessageBox.Show("There is no change");
                    }
                    else
                    {
                        string imagePath = Application.StartupPath + "\\images\\" + detail.CoverImagePath;
                        if (txtImagePath.Text != imagePath)
                        {
                            if (File.Exists(@"images\\" + detail.CoverImagePath))
                            {
                                File.Delete(@"images\\" + detail.CoverImagePath);
                            }
                            File.Copy(txtImagePath.Text, @"images\\" + fileName);
                            detail.CoverImagePath = fileName;
                        }
                        else if (txtImagePath.Text == detail.CoverImagePath)
                        {
                            detail.CoverImagePath = txtImagePath.Text;
                        }
                        detail.Day = dateTimePickerEvent.Value.Day;
                        detail.MonthID = dateTimePickerEvent.Value.Month;
                        detail.Year = dateTimePickerEvent.Value.Year.ToString();
                        detail.Summary = txtSummary.Text;
                        detail.EventTitle = txtTitle.Text;
                        detail.Summary = txtSummary.Text;
                        if (bll.Update(detail))
                        {
                            MessageBox.Show("Event was updated");
                            this.Close();
                        }
                    }
                }
            }
        }
        string fileName;
        OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picEventCoverImage.Load(OpenFileDialog1.FileName);
                txtImagePath.Text = OpenFileDialog1.FileName;
                string unique = Guid.NewGuid().ToString();
                fileName += unique + OpenFileDialog1.SafeFileName;
            }
        }

        private void FormEvent_Load(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                txtImagePath.Text = detail.CoverImagePath;
                txtSummary.Text = detail.Summary;
                txtTitle.Text = detail.EventTitle;
                labelTitle.Text = "Update "+ detail.EventTitle;
                dateTimePickerEvent.Value = Convert.ToDateTime(detail.MonthID + "/" + detail.Day + "/" + detail.Year);
                string imagePath = Application.StartupPath + "\\images\\" + detail.CoverImagePath;
                picEventCoverImage.ImageLocation = imagePath;
            }
        }
    }
}
