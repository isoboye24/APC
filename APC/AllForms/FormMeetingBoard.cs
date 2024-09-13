using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using APC.AllForms;
using APC.BLL;
using APC.DAL.DTO;

namespace APC.AllForms
{
    public partial class FormMeetingBoard : Form
    {
        public FormMeetingBoard()
        {
            InitializeComponent();
        }
        GeneralAttendanceBLL bll = new GeneralAttendanceBLL();
        GeneralAttendanceDTO dto = new GeneralAttendanceDTO();
        GeneralAttendanceDetailDTO detail = new GeneralAttendanceDetailDTO();
        CommentDTO commentDTO = new CommentDTO();
        CommentBLL commentBLL = new CommentBLL();
        CommentDetailDTO commentDetail = new CommentDetailDTO();
        private void FormMeetingBoard_Load(object sender, EventArgs e)
        {
            #region
            label1.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            label2.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            label3.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            label4.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            labelTotalMeetings.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            rbEqualAttend.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            rbEqualMonDues.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            rbLessAttend.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            rbLessMonDues.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            rbMoreAttend.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            rbMoreMonDues.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            txtMonthlyDues.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            txtNoOfAttend.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            txtYear.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            cmbMonth.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            btnUpdate.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnView.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnAdd.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnAbsentees.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnDelete.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnSearch.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnClear.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            label5.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            label6.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            label7.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            label8.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            label9.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            label10.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            labelTotalComments.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            txtYearComments.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            txtNameComments.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            txtComment.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            txtSurnameComments.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            cmbGenderComments.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            cmbMonthComments.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            btnAddComments.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnDeleteComments.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnUpdateComments.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnViewComments.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnSearchComments.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnClearComments.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            #endregion

            dto = bll.Select();
            cmbMonth.DataSource = dto.Months;
            General.ComboBoxProps(cmbMonth, "MonthName", "MonthID");

            commentDTO = commentBLL.Select();
            cmbGenderComments.DataSource = commentDTO.Genders;
            General.ComboBoxProps(cmbGenderComments, "GenderName", "GenderID");
            cmbMonthComments.DataSource = commentDTO.Months;
            General.ComboBoxProps(cmbMonthComments, "MonthName", "MonthID");

            #region
            dataGridView1.DataSource = dto.GeneralAttendance;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].HeaderText = "Month";
            dataGridView1.Columns[4].HeaderText = "Year";
            dataGridView1.Columns[5].HeaderText = "Members Present";
            dataGridView1.Columns[6].HeaderText = "Members Absent";
            dataGridView1.Columns[7].HeaderText = "Dues Paid";
            dataGridView1.Columns[8].HeaderText = "Dues Expected";
            dataGridView1.Columns[9].HeaderText = "Balance";
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.HeaderCell.Style.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            }
            if (LoginInfo.AccessLevel != 4)
            {
                btnDelete.Hide();
                btnDeleteComments.Hide();
            }            
            dataGridViewComments.DataSource = commentDTO.Comments;
            dataGridViewComments.Columns[0].Visible = false;
            dataGridViewComments.Columns[1].HeaderText = "Comment";
            dataGridViewComments.Columns[2].Visible = false;
            dataGridViewComments.Columns[3].HeaderText = "Surname";
            dataGridViewComments.Columns[4].HeaderText = "Name";
            dataGridViewComments.Columns[5].Visible = false;
            dataGridViewComments.Columns[6].Visible = false;
            dataGridViewComments.Columns[7].HeaderText = "Gender";
            dataGridViewComments.Columns[8].Visible = false;
            dataGridViewComments.Columns[9].Visible = false;
            dataGridViewComments.Columns[10].HeaderText = "Month";
            dataGridViewComments.Columns[11].HeaderText = "Year";
            dataGridViewComments.Columns[12].Visible = false;
            foreach (DataGridViewColumn columnComments in dataGridViewComments.Columns)
            {
                columnComments.HeaderCell.Style.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            }
            #endregion
            RefreshCounts();
        }
        private void RefreshCounts()
        {
            labelTotalMeetings.Text = "Total: " + dataGridView1.RowCount.ToString();
            labelTotalComments.Text = "Total: " + dataGridViewComments.RowCount.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormGeneralAttendance open = new FormGeneralAttendance();
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
            ClearFilters();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (detail.GeneralAttendanceID == 0)
            {
                MessageBox.Show("Please choose an attendance from the table");
            }
            else
            {
                FormViewGeneralAttendance open = new FormViewGeneralAttendance();
                open.detail = detail;
                this.Hide();
                open.ShowDialog();
                this.Visible = true;
                ClearFilters();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (detail.GeneralAttendanceID == 0)
            {
                MessageBox.Show("Please choose an attendance from the table");
            }
            else
            {
                FormGeneralAttendance open = new FormGeneralAttendance();
                open.isUpdate = true;
                open.detail = detail;
                this.Hide();
                open.ShowDialog();
                this.Visible = true;
                ClearFilters();
            }
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void txtNoOfAttend_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void txtMonthlyDues_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }
        private void FillDateGrid()
        {
            bll = new GeneralAttendanceBLL();
            dto = bll.Select();
            dataGridView1.DataSource = dto.GeneralAttendance;
        }
        
        private void FillDateGridComments()
        {
            commentBLL = new CommentBLL();
            commentDTO = commentBLL.Select();
            dataGridViewComments.DataSource = commentDTO.Comments;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<GeneralAttendanceDetailDTO> list = dto.GeneralAttendance;
            if (txtMonthlyDues.Text.Trim() != "")
            {
                if (rbEqualMonDues.Checked)
                {
                    list = list.Where(x => x.TotalDuesPaid == Convert.ToInt32(txtMonthlyDues.Text)).ToList();
                }
                else if (rbLessMonDues.Checked)
                {
                    list = list.Where(x => x.TotalDuesPaid < Convert.ToInt32(txtMonthlyDues.Text)).ToList();
                }
                else if (rbMoreMonDues.Checked)
                {
                    list = list.Where(x => x.TotalDuesPaid > Convert.ToInt32(txtMonthlyDues.Text)).ToList();
                }
                else
                {
                    MessageBox.Show("Please select a criterion from the monthly dues group");
                }
            }
            if (txtNoOfAttend.Text.Trim() != "")
            {
                if (rbEqualAttend.Checked)
                {
                    list = list.Where(x => x.TotalMembersPresent == Convert.ToInt32(txtNoOfAttend.Text)).ToList();
                }
                else if (rbLessAttend.Checked)
                {
                    list = list.Where(x => x.TotalMembersPresent < Convert.ToInt32(txtNoOfAttend.Text)).ToList();
                }
                else if (rbMoreAttend.Checked)
                {
                    list = list.Where(x => x.TotalMembersPresent > Convert.ToInt32(txtNoOfAttend.Text)).ToList();
                }
                else
                {
                    MessageBox.Show("Please select a criterion from the total number of attendance group");
                }
            }
            if (cmbMonth.SelectedIndex != -1)
            {
                list = list.Where(x => x.MonthID == Convert.ToInt32((cmbMonth.SelectedValue))).ToList();
            }
            dataGridView1.DataSource = list;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFilters();
        }
        private void ClearFilters()
        {
            txtYear.Clear();
            txtNoOfAttend.Clear();
            txtMonthlyDues.Clear();
            rbEqualMonDues.Checked = false;
            rbLessMonDues.Checked = false;
            rbMoreMonDues.Checked = false;
            rbEqualAttend.Checked = false;
            rbLessAttend.Checked = false;
            rbMoreAttend.Checked = false;
            cmbMonth.SelectedIndex = -1;
            FillDateGrid();

            txtNameComments.Clear();
            txtComment.Clear();
            txtSurnameComments.Clear();
            txtYearComments.Clear();
            cmbGenderComments.SelectedIndex = -1;
            cmbMonthComments.SelectedIndex = -1;
            FillDateGridComments();
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            List<GeneralAttendanceDetailDTO> list = dto.GeneralAttendance;
            list = list.Where(x => x.Year.Contains(txtYear.Text.ToString())).ToList();
            dataGridView1.DataSource = list;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail = new GeneralAttendanceDetailDTO();
            detail.GeneralAttendanceID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            detail.Day = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            detail.MonthID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            detail.Month = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            detail.Year = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            detail.TotalMembersPresent = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
            detail.TotalMembersAbsent = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[6].Value);
            detail.TotalDuesPaid = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[7].Value);
            detail.TotalDuesExpected = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[8].Value);
            detail.TotalDuesBalance = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[9].Value);
            detail.Summary = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            detail.AttendanceDate = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[11].Value);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (detail.GeneralAttendanceID == 0)
            {
                MessageBox.Show("Please choose an attendance from the table");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Warning!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (bll.Delete(detail))
                    {
                        MessageBox.Show("Attendance was deleted");
                        ClearFilters();
                    }
                }
            }
        }

        private void btnAbsentees_Click(object sender, EventArgs e)
        {
            FormNotifications open = new FormNotifications();
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
        }

        private void btnAddComments_Click(object sender, EventArgs e)
        {
            FormComments open = new FormComments();
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
            ClearFilters();
        }

        private void btnUpdateComments_Click(object sender, EventArgs e)
        {
            if (commentDetail.CommentID == 0)
            {
                MessageBox.Show("Please choose a comment from the table.");
            }
            else
            {
                FormComments open = new FormComments();
                open.detail = commentDetail;
                open.isUpdate = true;
                this.Hide();
                open.ShowDialog();
                this.Visible = true;
                ClearFilters();
            }
        }

        private void dataGridViewComments_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            commentDetail = new CommentDetailDTO();
            commentDetail.CommentID = Convert.ToInt32(dataGridViewComments.Rows[e.RowIndex].Cells[0].Value);
            commentDetail.CommentName = dataGridViewComments.Rows[e.RowIndex].Cells[1].Value.ToString();
            commentDetail.MemberID = Convert.ToInt32(dataGridViewComments.Rows[e.RowIndex].Cells[2].Value);
            commentDetail.Surname = dataGridViewComments.Rows[e.RowIndex].Cells[3].Value.ToString();
            commentDetail.Name = dataGridViewComments.Rows[e.RowIndex].Cells[4].Value.ToString();
            commentDetail.ImagePath = dataGridViewComments.Rows[e.RowIndex].Cells[5].Value.ToString();
            commentDetail.GenderID = Convert.ToInt32(dataGridViewComments.Rows[e.RowIndex].Cells[6].Value);
            commentDetail.GenderName = dataGridViewComments.Rows[e.RowIndex].Cells[7].Value.ToString();
            commentDetail.Day = Convert.ToInt32(dataGridViewComments.Rows[e.RowIndex].Cells[8].Value);
            commentDetail.MonthID = Convert.ToInt32(dataGridViewComments.Rows[e.RowIndex].Cells[9].Value);
            commentDetail.MonthName = dataGridViewComments.Rows[e.RowIndex].Cells[10].Value.ToString();
            commentDetail.Year = dataGridViewComments.Rows[e.RowIndex].Cells[11].Value.ToString();
            commentDetail.isMemberDeleted = Convert.ToBoolean(dataGridViewComments.Rows[e.RowIndex].Cells[12].Value);
        }

        private void btnViewComments_Click(object sender, EventArgs e)
        {
            if (commentDetail.CommentID == 0)
            {
                MessageBox.Show("Please choose a comment from the table.");
            }
            else
            {
                FormViewComment open = new FormViewComment();
                open.detail = commentDetail;
                this.Hide();
                open.ShowDialog();
                this.Visible = true;
                ClearFilters();
            }
        }

        private void txtSurnameComments_TextChanged(object sender, EventArgs e)
        {
            List<CommentDetailDTO> list = commentDTO.Comments;
            list = list.Where(x => x.Surname.Contains(txtSurnameComments.Text)).ToList();
            dataGridViewComments.DataSource = list;
        }

        private void txtNameComments_TextChanged(object sender, EventArgs e)
        {
            List<CommentDetailDTO> list = commentDTO.Comments;
            list = list.Where(x => x.Name.Contains(txtNameComments.Text)).ToList();
            dataGridViewComments.DataSource = list;
        }

        private void txtYearComments_TextChanged(object sender, EventArgs e)
        {
            List<CommentDetailDTO> list = commentDTO.Comments;
            list = list.Where(x => x.Year.Contains(txtYearComments.Text.ToString())).ToList();
            dataGridViewComments.DataSource = list;            
        }

        private void txtComment_TextChanged(object sender, EventArgs e)
        {
            List<CommentDetailDTO> list = commentDTO.Comments;
            list = list.Where(x => x.CommentName.Contains(txtComment.Text)).ToList();
            dataGridViewComments.DataSource = list;
        }

        private void btnSearchComments_Click(object sender, EventArgs e)
        {
            List<CommentDetailDTO> list = commentDTO.Comments;
            if (cmbGenderComments.SelectedIndex != -1)
            {
                list = list.Where(x => x.GenderID == Convert.ToInt32(cmbGenderComments.SelectedValue)).ToList();
            }
            if (cmbMonthComments.SelectedIndex != -1)
            {
                list = list.Where(x => x.MonthID == Convert.ToInt32(cmbMonthComments.SelectedValue)).ToList();
            }
            dataGridViewComments.DataSource = list;
        }

        private void btnClearComments_Click(object sender, EventArgs e)
        {
            ClearFilters();
        }
    }
}
