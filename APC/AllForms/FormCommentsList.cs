using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APC.BLL;
using APC.DAL.DTO;

namespace APC.AllForms
{
    public partial class FormCommentsList : Form
    {
        public FormCommentsList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormComments open = new FormComments();
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
            dto = bll.Select();
            dataGridView1.DataSource = dto.Comments;
        }
        CommentDetailDTO detail = new CommentDetailDTO();
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (detail.CommentID==0)
            {
                MessageBox.Show("Please choose a comment from the table.");
            }
            else
            {
                FormComments open = new FormComments();
                open.detail = detail;
                open.isUpdate = true;
                this.Hide();
                open.ShowDialog();
                this.Visible = true;
                bll = new CommentBLL();
                dto = bll.Select();
                dataGridView1.DataSource = dto.Comments;
            }            
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            FormViewComment open = new FormViewComment();
            open.detail = detail;
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
            dto = bll.Select();
            dataGridView1.DataSource = dto.Comments;
        }
        CommentDTO dto = new CommentDTO();
        CommentBLL bll = new CommentBLL();
        private void FormCommentsList_Load(object sender, EventArgs e)
        {
            dto = bll.Select();
            cmbGender.DataSource = dto.Genders;
            General.ComboBoxProps(cmbGender, "GenderName", "GenderID");
            cmbMonth.DataSource = dto.Months;
            General.ComboBoxProps(cmbMonth, "MonthName", "MonthID");

            dataGridView1.DataSource = dto.Comments;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Comment";
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].HeaderText = "Surname";
            dataGridView1.Columns[4].HeaderText = "Name";
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].HeaderText = "Gender";
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].HeaderText = "Month";
            dataGridView1.Columns[11].HeaderText = "Year";
            dataGridView1.Columns[12].Visible = false;
            if (LoginInfo.AccessLevel != 4)
            {
                btnDelete.Hide();
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            List<CommentDetailDTO> list = dto.Comments;
            list = list.Where(x => x.Name.Contains(txtName.Text)).ToList();
            dataGridView1.DataSource = list;
        }

        private void txtComment_TextChanged(object sender, EventArgs e)
        {
            List<CommentDetailDTO> list = dto.Comments;
            list = list.Where(x => x.CommentName.Contains(txtComment.Text)).ToList();
            dataGridView1.DataSource = list;
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            List<CommentDetailDTO> list = dto.Comments;
            list = list.Where(x => x.Surname.Contains(txtSurname.Text)).ToList();
            dataGridView1.DataSource = list;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<CommentDetailDTO> list = dto.Comments;
            if (cmbGender.SelectedIndex != -1)
            {
                list = list.Where(x => x.GenderID == Convert.ToInt32(cmbGender.SelectedValue)).ToList();
            }
            if (cmbMonth.SelectedIndex != -1)
            {
                list = list.Where(x => x.MonthID == Convert.ToInt32(cmbMonth.SelectedValue)).ToList();
            }
            dataGridView1.DataSource = list;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFilters();
        }

        private void ClearFilters()
        {
            txtName.Clear();
            txtComment.Clear();
            txtSurname.Clear();
            txtYear.Clear();
            cmbGender.SelectedIndex = -1;
            cmbMonth.SelectedIndex = -1;
            dto = bll.Select();
            dataGridView1.DataSource = dto.Comments;
        }
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail = new CommentDetailDTO();
            detail.CommentID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            detail.CommentName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            detail.MemberID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            detail.Surname = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            detail.Name = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            detail.ImagePath = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            detail.GenderID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[6].Value);
            detail.GenderName = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            detail.Day = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[8].Value);
            detail.MonthID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[9].Value);
            detail.MonthName = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            detail.Year = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            detail.isMemberDeleted = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[12].Value);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (detail.CommentID == 0)
            {
                MessageBox.Show("Please choose a comment from the table");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure?","Warning!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (bll.Delete(detail))
                    {
                        MessageBox.Show("Comment was deleted");
                        bll = new CommentBLL();
                        dto = bll.Select();
                        dataGridView1.DataSource = dto.Comments;
                        ClearFilters();
                    }
                }
            }
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            List<CommentDetailDTO> list = dto.Comments;
            list = list.Where(x => x.Year.Contains(txtYear.Text)).ToList();
            dataGridView1.DataSource = list;
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }
    }
}
