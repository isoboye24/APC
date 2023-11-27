using APC.BLL;
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
        ChildBLL bll = new ChildBLL();
        ChildDTO dto = new ChildDTO();
        public int memberID;
        public bool isParent = false;
        private void FormViewChild_Load(object sender, EventArgs e)
        {
            

            if (isParent)
            {
                dto = bll.SelectViewParentChild(memberID);
                List<ChildDetailDTO> list = dto.Children;
                foreach (var item in list)
                {
                    string imagePath = Application.StartupPath + "\\images\\" + item.ImagePath;
                    picChild.ImageLocation = imagePath;
                    txtName.Text = item.Name;
                    txtSurname.Text = item.Surname;
                    txtGender.Text = item.GenderName;
                    txtNationality.Text = item.NationalityName;
                    txtBirthday.Text = item.Birthday.ToString();
                    string fatherImagePath = Application.StartupPath + "\\images\\" + item.FatherImagePath;
                    picFather.ImageLocation = fatherImagePath;
                    txtFathersName.Text = item.FathersName;
                    txtFathersSurname.Text = item.FathersSurname;
                    txtFathersNationality.Text = item.FatherNationalityName;
                    string motherImagePath = Application.StartupPath + "\\images\\" + item.MotherImagePath;
                    picMother.ImageLocation = motherImagePath;
                    txtMothersName.Text = item.MothersName;
                    txtMothersSurname.Text = item.MothersSurname;
                    txtMothersNationality.Text = item.MotherNationalityName;
                    labelTitle.Text = item.Surname + " " + item.Name;
                } 
            }
            else
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
                labelTitle.Text = detail.Surname + " " + detail.Name;
            }
        }
    }
}
