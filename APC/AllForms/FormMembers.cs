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
using System.Runtime.InteropServices;
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
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int IParam);
        
        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        MemberBLL bll = new MemberBLL();
        MemberDTO dto = new MemberDTO();
        private void FormMembers_Load(object sender, EventArgs e)
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
            cmbEmpStatus.DataSource = dto.EmploymentStatuses;
            General.ComboBoxProps(cmbEmpStatus, "EmploymentStatus", "EmploymentStatusID");
            cmbNationality.DataSource = dto.Nationalities;
            General.ComboBoxProps(cmbNationality, "Nationality", "NationalityID");
            cmbPermission.DataSource = dto.Permissions;
            General.ComboBoxProps(cmbPermission, "Permission", "PermissionID");            

            txtPhone2.Hide();
            txtPhone3.Hide();
            labelPhone2.Hide();
            labelPhone3.Hide();
            label13.Hide();
            labelLastEnteredUsername.Hide();
            if (LoginInfo.AccessLevel != 4)
            {
                labelAccessLevel.Hide();
                cmbPermission.Hide();
            }            
            //if (!isUpdate)
            //{
            //    labelLastEnteredUsername.Text = bll.GetLastMemberUsername();
            //}
            if (isUpdate)
            {
                txtName.Text = detail.Name;
                txtSurname.Text = detail.Surname;
                txtAddress.Text = detail.HouseAddress;
                cmbPosition.SelectedValue = detail.PositionID;
                dateTimePickerBirthday.Value = Convert.ToDateTime(detail.Birthday);
                dateTimePickerMemSince.Value = Convert.ToDateTime(detail.MembershipDate);
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
                detail.PermissionID = detail.PermissionID;
                if (LoginInfo.AccessLevel != 4)
                {
                    labelAccessLevel.Hide();
                    cmbPermission.Hide();                    
                }
                else
                {
                    labelAccessLevel.Visible = true;
                    cmbPermission.Visible = true;
                }
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
            else if (LoginInfo.AccessLevel == 4 && cmbPermission.SelectedIndex == -1)
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
                    member.Birthday = dateTimePickerBirthday.Value;
                    int day, month, yearDigit;
                    string year;
                    day = dateTimePickerBirthday.Value.Day;
                    month = dateTimePickerBirthday.Value.Month;
                    yearDigit = dateTimePickerBirthday.Value.Year % 100;
                    if (yearDigit == 0)
                    {
                        year = "0" + yearDigit;
                    }
                    else
                    {
                        year = (dateTimePickerBirthday.Value.Year % 100).ToString();
                    }
                    string lastUsername = bll.GetLastMemberUsername();
                    if (lastUsername == null)
                    {
                        member.Username = "apc20001";
                    }
                    else
                    {
                        string getDigits = lastUsername.Substring(3);
                        int convertDigits = Convert.ToInt32(getDigits) + 1;
                        member.Username = "apc" + convertDigits;
                    }                    
                    if (day < 10 && month < 10)
                    {
                        member.Password = "0"+ day + "0" + month + "" + year;
                    }
                    else if (day < 10 && month >= 10)
                    {
                        member.Password = "0" + day + "" + month + "" + year;
                    }
                    else if (day >= 10 && month < 10)
                    {
                        member.Password = "" + day + "0" + month + "" + year;
                    }
                    else
                    {
                        member.Password = "" + day + "" + month + "" + year;
                    }
                    member.EmailAddress = txtEmail.Text;
                    member.HouseAddress = txtAddress.Text;
                    member.CountryID = Convert.ToInt32(cmbCountry.SelectedValue);
                    member.ProfessionID = Convert.ToInt32(cmbProfession.SelectedValue);
                    member.GenderID = Convert.ToInt32(cmbGender.SelectedValue);
                    member.EmploymentStatusID = Convert.ToInt32(cmbEmpStatus.SelectedValue);
                    member.NationalityID = Convert.ToInt32(cmbNationality.SelectedValue);
                    member.MaritalStatusID = Convert.ToInt32(cmbMaritalStatus.SelectedValue);
                    if (LoginInfo.AccessLevel != 4)
                    {
                        member.PermissionID = 2;
                    }
                    else
                    {
                        member.PermissionID = Convert.ToInt32(cmbPermission.SelectedValue);
                    }
                    member.PermissionID = Convert.ToInt32(cmbPermission.SelectedValue);
                    member.PositionID = Convert.ToInt32(cmbPosition.SelectedValue);
                    member.ImagePath = fileName;
                    member.PhoneNumber = txtPhone1.Text;
                    member.PhoneNumber2 = txtPhone2.Text;
                    member.PhoneNumber3 = txtPhone3.Text;       
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
                        dateTimePickerMemSince.Value = DateTime.Today;
                        txtEmail.Clear();
                        txtAddress.Clear();
                        txtImagePath.Clear();
                        txtPhone1.Clear();
                        txtPhone2.Clear();
                        txtPhone3.Clear();
                        cmbCountry.SelectedIndex = -1;
                        cmbCountry.DataSource = dto.Countries;
                        cmbNationality.SelectedIndex = -1;
                        cmbNationality.DataSource = dto.Nationalities;
                        cmbEmpStatus.SelectedIndex = -1;
                        cmbEmpStatus.DataSource = dto.EmploymentStatuses;
                        cmbGender.SelectedIndex = -1;
                        cmbGender.DataSource = dto.Genders;
                        cmbMaritalStatus.SelectedIndex = -1;
                        cmbMaritalStatus.DataSource = dto.MaritalStatuses;
                        cmbPosition.SelectedIndex = -1;
                        cmbPosition.DataSource = dto.Positions;
                        cmbProfession.SelectedIndex = -1;
                        cmbProfession.DataSource = dto.Professions;
                        cmbPermission.SelectedIndex = -1;
                        cmbPermission.DataSource = dto.Permissions;
                        picProfilePic.Image = null;
                        txtPhone2.Hide();
                        txtPhone3.Hide();
                        labelPhone2.Hide();
                        labelPhone3.Hide();
                    }
                }
                else if(isUpdate)
                {                    
                    if (
                            detail.Name == txtName.Text.Trim() && detail.Surname == txtSurname.Text.Trim()
                            && detail.EmailAddress == txtEmail.Text.Trim() && detail.PositionID == Convert.ToInt32(cmbPosition.SelectedValue)
                            && detail.Birthday == dateTimePickerBirthday.Value && detail.MembershipDate == dateTimePickerMemSince.Value
                            && detail.HouseAddress == txtAddress.Text.Trim() && detail.ImagePath == txtImagePath.Text.Trim()
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
                        detail.MembershipDate = dateTimePickerMemSince.Value;
                        detail.Username = detail.Username;
                        if (detail.Birthday == dateTimePickerBirthday.Value)
                        {
                            detail.Password = detail.Password;
                            detail.Birthday = detail.Birthday;
                        }
                        else if (detail.Birthday != dateTimePickerBirthday.Value)
                        {
                            int day, month, yearDigit;
                            string year;
                            day = dateTimePickerBirthday.Value.Day;
                            month = dateTimePickerBirthday.Value.Month;
                            yearDigit = dateTimePickerBirthday.Value.Year % 100;
                            if (yearDigit == 0 )
                            {
                                year = "0" + yearDigit;
                            }
                            else
                            {
                                year = (dateTimePickerBirthday.Value.Year % 100).ToString();
                            }
                            if (day < 10 && month < 10)
                            {
                                detail.Password = "0" + day + "0" + month + "" + year;
                            }
                            else if (day < 10 && month >= 10)
                            {
                                detail.Password = "0" + day + "" + month + "" + year;
                            }
                            else if (day >= 10 && month < 10)
                            {
                                detail.Password = "" + day + "0" + month + "" + year;
                            }
                            else if (day >= 10 && month >= 10)
                            {
                                detail.Password = "" + day + "" + month + "" + year;
                            }
                            detail.Birthday = dateTimePickerBirthday.Value;
                        }                        
                        detail.EmailAddress = txtEmail.Text;
                        if (detail.ImagePath != txtImagePath.Text.Trim())
                        {
                            if (File.Exists(@"images\\" + detail.ImagePath))
                            {
                                File.Delete(@"images\\" + detail.ImagePath);
                            }
                            File.Copy(txtImagePath.Text, @"images\\" + fileName);
                            detail.ImagePath = fileName;
                        }
                        else if (detail.ImagePath == txtImagePath.Text.Trim())
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
