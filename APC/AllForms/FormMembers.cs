using APC.BLL;
using APC.DAL;
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
    public partial class FormMembers : Form
    {
        public FormMembers()
        {
            InitializeComponent();
        }

        private void FormMembers_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        CountryBLL countryBLL = new CountryBLL();
        CountryDTO countryDTO = new CountryDTO();
        GenderBLL genderBLL = new GenderBLL();
        GenderDTO genderDTO = new GenderDTO();
        ProfessionBLL professionBLL = new ProfessionBLL();
        ProfessionDTO professionDTO = new ProfessionDTO();
        PositionBLL positionBLL = new PositionBLL();
        PositionDTO positionDTO = new PositionDTO();
        MaritalStatusBLL maritalStatusBLL = new MaritalStatusBLL();
        MaritalStatusDTO maritalStatusDTO = new MaritalStatusDTO();
        EmploymentStatusBLL empStatusBLL = new EmploymentStatusBLL();
        EmploymentStatusDTO empStatusDTO = new EmploymentStatusDTO();
        NationalityBLL nationalityBLL = new NationalityBLL();
        NationalityDTO nationalityDTO = new NationalityDTO();
        PermissionBLL permissionBLL = new PermissionBLL();
        PermissionDTO permissionDTO = new PermissionDTO();

        MemberBLL memberBLL = new MemberBLL();
        private void FormMembers_Load(object sender, EventArgs e)
        {
            countryDTO = countryBLL.Select();
            cmbCountry.DataSource = countryDTO.Countries;
            General.ComboBoxProps(cmbCountry, "CountryName", "countryID");

            genderDTO = genderBLL.Select();
            cmbGender.DataSource = genderDTO.Genders;
            General.ComboBoxProps(cmbGender, "GenderName", "genderID");

            professionDTO = professionBLL.Select();
            cmbProfession.DataSource = professionDTO.Professions;
            General.ComboBoxProps(cmbProfession, "Profession", "professionID");

            positionDTO = positionBLL.Select();
            cmbPosition.DataSource = positionDTO.Positions;
            General.ComboBoxProps(cmbPosition, "PositionName", "positionID");

            maritalStatusDTO = maritalStatusBLL.Select();
            cmbMaritalStatus.DataSource = maritalStatusDTO.MaritalStatuses;
            General.ComboBoxProps(cmbMaritalStatus, "MaritalStatus", "MaritalStatusID");

            empStatusDTO = empStatusBLL.Select();
            cmbEmpStatus.DataSource = empStatusDTO.EmploymentStatuses;
            General.ComboBoxProps(cmbEmpStatus, "EmploymentStatus", "EmploymentStatusID");

            nationalityDTO = nationalityBLL.Select();
            cmbNationality.DataSource = nationalityDTO.Nationalities;
            General.ComboBoxProps(cmbNationality, "Nationality", "NationalityID");

            permissionDTO = permissionBLL.Select();
            cmbPermission.DataSource = permissionDTO.Permissions;
            General.ComboBoxProps(cmbPermission, "Permission", "PermissionID");

            txtPhone2.Hide();
            txtPhone3.Hide();
            labelPhone2.Hide();
            labelPhone3.Hide();

            if (isUpdate)
            {                
                txtName.Text = detail.Name;
                txtSurname.Text = detail.Surname;
                txtAddress.Text = detail.HouseAddress;
                cmbPosition.SelectedValue = detail.PositionID;
                dateTimePickerBirthday.Value = detail.Birthday;
                dateTimePickerMemSince.Value = detail.MembershipDate;
                txtUsername.Text = detail.Username;
                txtPassword.Text = detail.Password;
                txtEmail.Text = detail.EmailAddress;
                txtImagePath.Text = detail.ImagePath;                
                txtPhone1.Text = detail.PhoneNumber;
                if (detail.PhoneNumber2 != "")
                {
                    txtPhone2.Visible = true;
                    labelPhone2.Visible = true;
                }
                if (detail.PhoneNumber3 != "")
                {
                    txtPhone3.Visible = true;
                    labelPhone3.Visible = true;
                }
                txtPhone2.Text = detail.PhoneNumber2;
                txtPhone3.Text = detail.PhoneNumber3;
                cmbCountry.SelectedValue = detail.CountryID;
                cmbProfession.SelectedValue = detail.ProfessionID;
                cmbEmpStatus.SelectedValue = detail.EmploymentStatusID;
                cmbGender.SelectedValue = detail.GenderID;
                cmbNationality.SelectedValue = detail.NationalityID;
                cmbMaritalStatus.SelectedValue = detail.MaritalStatusID;
                cmbPermission.SelectedValue = detail.PermissionID;
                string imagePath = Application.StartupPath + "\\images\\" + detail.ImagePath;
                picProfilePic.ImageLocation = imagePath;
            }
        }
        
        private void labelMorePhone_Click(object sender, EventArgs e)
        {
            txtPhone2.Visible = true;
            txtPhone3.Visible = true;
            labelPhone2.Visible = true;
            labelPhone3.Visible = true;
        }
        public MemberDetailDTO detail = new MemberDetailDTO();
        public bool isUpdate = false;
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
            else if (txtUsername.Text.Trim() == "")
            {
                MessageBox.Show("Please enter username");
            }
            else if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Please enter password");
            }
            else if (txtPhone1.Text.Trim() == "")
            {
                MessageBox.Show("Please enter phone number");
            }
            else if (txtEmail.Text.Trim()=="")
            {
                MessageBox.Show("Please enter email");
            }
            else if (cmbCountry.SelectedIndex ==- 1)
            {
                MessageBox.Show("Please select a country");
            }
            else if (cmbEmpStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an employment status");
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
            else if (cmbPermission.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an access level");
            }
            else
            {
                if (!isUpdate)
                {                
                    MemberDetailDTO member = new MemberDetailDTO();
                    member.Name = txtName.Text;
                    member.Surname = txtSurname.Text;
                    member.Username = txtUsername.Text;
                    member.Password = txtPassword.Text;
                    member.Birthday = dateTimePickerBirthday.Value;
                    member.EmailAddress = txtEmail.Text;
                    member.HouseAddress = txtAddress.Text;
                    member.CountryID = Convert.ToInt32(cmbCountry.SelectedValue);
                    member.ProfessionID = Convert.ToInt32(cmbProfession.SelectedValue);
                    member.GenderID = Convert.ToInt32(cmbGender.SelectedValue);
                    member.EmploymentStatusID = Convert.ToInt32(cmbEmpStatus.SelectedValue);
                    member.NationalityID = Convert.ToInt32(cmbNationality.SelectedValue);
                    member.MaritalStatusID = Convert.ToInt32(cmbMaritalStatus.SelectedValue);
                    member.PermissionID = Convert.ToInt32(cmbPermission.SelectedValue);
                    member.PositionID = Convert.ToInt32(cmbPosition.SelectedValue);
                    member.ImagePath = fileName;
                    member.PhoneNumber = txtPhone1.Text;
                    member.PhoneNumber2 = txtPhone2.Text;
                    member.PhoneNumber3 = txtPhone3.Text;       
                    member.MembershipDate = dateTimePickerMemSince.Value;
                    if (memberBLL.Insert(member))
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
                        txtUsername.Clear();
                        txtPassword.Clear();
                        dateTimePickerBirthday.Value = DateTime.Today;
                        dateTimePickerMemSince.Value = DateTime.Today;
                        txtEmail.Clear();
                        txtAddress.Clear();
                        txtImagePath.Clear();
                        txtPhone1.Clear();
                        txtPhone2.Clear();
                        txtPhone3.Clear();
                        cmbCountry.SelectedIndex = -1;
                        cmbCountry.DataSource = countryDTO.Countries;
                        cmbNationality.SelectedIndex = -1;
                        cmbNationality.DataSource = nationalityDTO.Nationalities;
                        cmbEmpStatus.SelectedIndex = -1;
                        cmbEmpStatus.DataSource = empStatusDTO.EmploymentStatuses;
                        cmbGender.SelectedIndex = -1;
                        cmbGender.DataSource = genderDTO.Genders;
                        cmbMaritalStatus.SelectedIndex = -1;
                        cmbMaritalStatus.DataSource = maritalStatusDTO.MaritalStatuses;
                        cmbPosition.SelectedIndex = -1;
                        cmbPosition.DataSource = positionDTO.Positions;
                        cmbProfession.SelectedIndex = -1;
                        cmbProfession.DataSource = professionDTO.Professions;
                        cmbPermission.SelectedIndex = -1;
                        cmbPermission.DataSource = permissionDTO.Permissions;
                        picProfilePic.Image = null;
                    }
                }
                else if(isUpdate)
                {
                    if (
                            detail.Name == txtName.Text.Trim() && detail.Surname == txtSurname.Text.Trim()
                            && detail.EmailAddress == txtEmail.Text.Trim() && detail.PositionID == Convert.ToInt32(cmbPosition.SelectedValue)
                            && detail.Birthday == dateTimePickerBirthday.Value && detail.MembershipDate == dateTimePickerMemSince.Value
                            && detail.HouseAddress == txtAddress.Text.Trim() && detail.Username == txtUsername.Text.Trim()
                            && detail.Password == txtPassword.Text.Trim() && detail.ImagePath == txtImagePath.Text.Trim()
                            && detail.PhoneNumber == txtPhone1.Text.Trim() && detail.PhoneNumber2 == txtPhone2.Text.Trim()
                            && detail.PhoneNumber3 == txtPhone3.Text.Trim() && detail.CountryID == Convert.ToInt32(cmbCountry.SelectedValue)
                            && detail.ProfessionID == Convert.ToInt32(cmbProfession.SelectedValue) && detail.EmploymentStatusID == Convert.ToInt32(cmbEmpStatus.SelectedValue)
                            && detail.GenderID == Convert.ToInt32(cmbGender.SelectedValue) && detail.NationalityID == Convert.ToInt32(cmbNationality.SelectedValue)
                            && detail.MaritalStatusID == Convert.ToInt32(cmbMaritalStatus.SelectedValue) && detail.PermissionID == Convert.ToInt32(cmbPermission.SelectedValue)
                        )
                    {
                        MessageBox.Show("There is no change");
                    }
                    else
                    {
                        detail.Name = txtName.Text;
                        detail.Surname = txtSurname.Text;
                        detail.HouseAddress = txtAddress.Text;
                        detail.PositionID = Convert.ToInt32(cmbPosition.SelectedValue);
                        detail.Birthday = dateTimePickerBirthday.Value;
                        detail.MembershipDate = dateTimePickerMemSince.Value;
                        detail.Username = txtUsername.Text;
                        detail.Password = txtPassword.Text;
                        detail.EmailAddress = txtEmail.Text;
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
                        detail.PhoneNumber = txtPhone1.Text;
                        detail.PhoneNumber2 = txtPhone2.Text;
                        detail.PhoneNumber3 = txtPhone3.Text;
                        detail.CountryID = Convert.ToInt32(cmbCountry.SelectedValue);
                        detail.ProfessionID = Convert.ToInt32(cmbProfession.SelectedValue);
                        detail.EmploymentStatusID = Convert.ToInt32(cmbEmpStatus.SelectedValue);
                        detail.GenderID = Convert.ToInt32(cmbGender.SelectedValue);
                        detail.NationalityID = Convert.ToInt32(cmbNationality.SelectedValue);
                        detail.MaritalStatusID = Convert.ToInt32(cmbMaritalStatus.SelectedValue);
                        detail.PermissionID = Convert.ToInt32(cmbPermission.SelectedValue);
                        if (memberBLL.Update(detail))
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
        private void btnBrowse_Click(object sender, EventArgs e)
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
