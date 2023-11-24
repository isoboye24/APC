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

namespace APC.AllForms
{
    public partial class FormViewChild : Form
    {
        public FormViewChild()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public ChildDetailDTO detail = new ChildDetailDTO();        
        private void FormViewChild_Load(object sender, EventArgs e)
        {
            string imagePath = Application.StartupPath + "\\images\\" + detail.ImagePath;
            picChild.ImageLocation = imagePath;
            txtName.Text = detail.Name;
            txtSurname.Text = detail.Surname;
            txtGender.Text = detail.GenderName;
            txtNationality.Text = detail.NationalityName;
            txtBirthday.Text = detail.Birthday.ToString();
            string fatherImagePath = Application.StartupPath + "\\images\\" + detail.FatherImagePath;
            picFather.ImageLocation = fatherImagePath;
            txtFathersName.Text = detail.FathersName;
            txtFathersSurname.Text = detail.FathersSurname;
            txtFathersNationality.Text = detail.FatherNationalityName;
            string motherImagePath = Application.StartupPath + "\\images\\" + detail.MotherImagePath;
            picMother.ImageLocation = motherImagePath;
            txtMothersName.Text = detail.MothersName;
            txtMothersSurname.Text = detail.MothersSurname;
            txtMothersNationality.Text = detail.MotherNationalityName;
            labelTitle.Text = detail.Surname +" "+ detail.Name;
        }
    }
}
