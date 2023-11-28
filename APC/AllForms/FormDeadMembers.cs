using APC.BLL;
using APC.DAL.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APC.AllForms
{
    public partial class FormDeadMembers : Form
    {
        public FormDeadMembers()
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
        DeadMembersBLL bll = new DeadMembersBLL();
        DeadMembersDTO dto = new DeadMembersDTO();
        public DeadMembersDetailDTO detail = new DeadMembersDetailDTO();
        public bool isUpdate = false;
        private void FormDeadMembers_Load(object sender, EventArgs e)
        {
            dto = bll.Select();

            cmbCountry.DataSource = dto.Countries;
            General.ComboBoxProps(cmbCountry, "CountryName", "countryID");
            cmbGender.DataSource = dto.Genders;
            General.ComboBoxProps(cmbGender, "GenderName", "genderID");
            cmbProfession.DataSource = dto.Professions;
            General.ComboBoxProps(cmbProfession, "Profession", "professionID");
            cmbPosition.DataSource = dto.Positions;
            General.ComboBoxProps(cmbPosition, "PositionName", "positionID");
            cmbMaritalStatus.DataSource = dto.MaritalStatuses;
            General.ComboBoxProps(cmbMaritalStatus, "MaritalStatus", "MaritalStatusID");
            cmbNationality.DataSource = dto.Nationalities;
            General.ComboBoxProps(cmbNationality, "Nationality", "NationalityID");

            if (isUpdate)
            {
                txtImagePath.Text = detail.ImagePath;
                txtName.Text = detail.Name;
                txtSurname.Text = detail.Surname;
                cmbPosition.SelectedValue = detail.PositionID;
                dateTimePickerBirthday.Value = Convert.ToDateTime(detail.Birthday);
                dateTimePickerDied.Value = Convert.ToDateTime(detail.DeathDate);
                dateTimePickerMemSince.Value = Convert.ToDateTime(detail.MembershipDate);
                cmbCountry.SelectedValue = detail.CountryID;
                cmbProfession.SelectedValue = detail.ProfessionID;
                cmbGender.SelectedValue = detail.GenderID;
                cmbNationality.SelectedValue = detail.NationalityID;
                cmbMaritalStatus.SelectedValue = detail.MaritalStatusID;
                string imagePath = Application.StartupPath + "\\images\\" + detail.ImagePath;
                picProfilePic.ImageLocation = imagePath;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter name");
            }
            else if (txtSurname.Text.Trim() == "")
            {
                MessageBox.Show("Please enter surname");
            }           
            else if (cmbCountry.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a country");
            }            
            else if (cmbGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a gender");
            }
            else if (cmbMaritalStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a marital status");
            }
            else if (cmbNationality.SelectedIndex == -1)
            {
                MessageBox.Show("Please select nationality");
            }
            else if (cmbPosition.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a position");
            }
            else if (cmbProfession.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a profession");
            }            
            else
            {
                if (!isUpdate)
                {
                    DeadMembersDetailDTO member = new DeadMembersDetailDTO();
                    member.Name = txtName.Text;
                    member.Surname = txtSurname.Text;
                    member.Birthday = dateTimePickerBirthday.Value;
                    member.DeathDate = dateTimePickerDied.Value;
                    member.CountryID = Convert.ToInt32(cmbCountry.SelectedValue);
                    member.ProfessionID = Convert.ToInt32(cmbProfession.SelectedValue);
                    member.GenderID = Convert.ToInt32(cmbGender.SelectedValue);
                    member.NationalityID = Convert.ToInt32(cmbNationality.SelectedValue);
                    member.MaritalStatusID = Convert.ToInt32(cmbMaritalStatus.SelectedValue);
                    member.PositionID = Convert.ToInt32(cmbPosition.SelectedValue);
                    member.ImagePath = fileName;
                    member.MembershipDate = dateTimePickerMemSince.Value;
                    if (bll.Insert(member))
                    {
                        MessageBox.Show("Member was added");
                        try
                        {
                            File.Copy(txtImagePath.Text, @"images\\" + fileName);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Cannot find the path to this picture");
                        }
                        txtName.Clear();
                        txtSurname.Clear();                        
                        dateTimePickerBirthday.Value = DateTime.Today;
                        dateTimePickerDied.Value = DateTime.Today;
                        dateTimePickerMemSince.Value = DateTime.Today;
                        cmbCountry.SelectedIndex = -1;
                        cmbCountry.DataSource = dto.Countries;
                        cmbNationality.SelectedIndex = -1;
                        cmbNationality.DataSource = dto.Nationalities;
                        cmbGender.SelectedIndex = -1;
                        cmbGender.DataSource = dto.Genders;
                        cmbMaritalStatus.SelectedIndex = -1;
                        cmbMaritalStatus.DataSource = dto.MaritalStatuses;
                        cmbPosition.SelectedIndex = -1;
                        cmbPosition.DataSource = dto.Positions;
                        cmbProfession.SelectedIndex = -1;
                        cmbProfession.DataSource = dto.Professions;
                        picProfilePic.Image = null;
                    }
                }
                else if (isUpdate)
                {
                    if (
                            detail.Name == txtName.Text.Trim() && detail.Surname == txtSurname.Text.Trim()
                            && detail.PositionID == Convert.ToInt32(cmbPosition.SelectedValue) && detail.MaritalStatusID == Convert.ToInt32(cmbMaritalStatus.SelectedValue)
                            && detail.Birthday == dateTimePickerBirthday.Value && detail.MembershipDate == dateTimePickerMemSince.Value
                            && detail.ImagePath == txtImagePath.Text.Trim() && detail.CountryID == Convert.ToInt32(cmbCountry.SelectedValue)
                            && detail.GenderID == Convert.ToInt32(cmbGender.SelectedValue) && detail.NationalityID == Convert.ToInt32(cmbNationality.SelectedValue)
                            && detail.ProfessionID == Convert.ToInt32(cmbProfession.SelectedValue) && detail.DeathDate == dateTimePickerDied.Value
                        )
                    {
                        MessageBox.Show("There is no change");
                    }
                    else
                    {
                        detail.Name = txtName.Text;
                        detail.Surname = txtSurname.Text;
                        detail.PositionID = Convert.ToInt32(cmbPosition.SelectedValue);
                        detail.Birthday = dateTimePickerBirthday.Value;
                        detail.DeathDate = dateTimePickerDied.Value;
                        detail.MembershipDate = dateTimePickerMemSince.Value;
                        if (txtImagePath.Text != detail.ImagePath)
                        {
                            if (File.Exists(@"images\\" + detail.ImagePath))
                            {
                                File.Delete(@"images\\" + detail.ImagePath);
                            }
                            File.Copy(txtImagePath.Text, @"images\\" + fileName);
                            detail.ImagePath = fileName;
                        }
                        else if (txtImagePath.Text == detail.ImagePath)
                        {
                            detail.ImagePath = txtImagePath.Text;
                        }
                        detail.CountryID = Convert.ToInt32(cmbCountry.SelectedValue);
                        detail.ProfessionID = Convert.ToInt32(cmbProfession.SelectedValue);
                        detail.GenderID = Convert.ToInt32(cmbGender.SelectedValue);
                        detail.NationalityID = Convert.ToInt32(cmbNationality.SelectedValue);
                        detail.MaritalStatusID = Convert.ToInt32(cmbMaritalStatus.SelectedValue);
                        if (bll.Update(detail))
                        {
                            MessageBox.Show("Member was updated");
                            this.Close();
                        }
                    }
                }
            }

        }

        string fileName;
        OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
        private void btnBrowse_Click_1(object sender, EventArgs e)
        {

            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picProfilePic.Load(OpenFileDialog1.FileName);
                txtImagePath.Text = OpenFileDialog1.FileName;
                string unique = Guid.NewGuid().ToString();
                fileName += unique + OpenFileDialog1.SafeFileName;
            }
        }
    }
}
