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
    public partial class FormEvenImages : Form
    {
        public FormEvenImages()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormEventSingleImage open = new FormEventSingleImage();
            open.eventID = detail.EventID;
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
            FillDataGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (imageDetail.EventImageID == 0)
            {
                MessageBox.Show("Please choose an image from the table");
            }
            else
            {
                FormEventSingleImage open = new FormEventSingleImage();
                open.detail = imageDetail;
                open.isUdate = true;
                this.Hide();
                open.ShowDialog();
                this.Visible = true;
                FillDataGrid();
            }            
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (imageDetail.EventImageID == 0)
            {
                MessageBox.Show("Please choose an image from the table");
            }
            else
            {
                FormEventSingleImage open = new FormEventSingleImage();
                open.detail = imageDetail;
                open.isView = true;
                this.Hide();
                open.ShowDialog();
                this.Visible = true;
                FillDataGrid();
            }            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public EventsDetailDTO detail = new EventsDetailDTO();
        public bool isView = false;
        EventImageBLL bll = new EventImageBLL();
        EventImageDTO dto = new EventImageDTO();
        private void FormEvenImages_Load(object sender, EventArgs e)
        {
            dto = bll.Select();

            dataGridView1.DataSource = dto.EventImages;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].HeaderText = "No.";
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[7].HeaderText = "Picture Caption";

        }
        private void FillDataGrid()
        {
            bll = new EventImageBLL();
            dto = bll.Select();
            dataGridView1.DataSource = dto.EventImages;
            txtImageCaption.Clear();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        EventImageDetailDTO imageDetail = new EventImageDetailDTO();
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            imageDetail = new EventImageDetailDTO();
            imageDetail.EventImageID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            imageDetail.EventID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            imageDetail.EventTitle = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            imageDetail.EventYear = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            imageDetail.Summary = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            imageDetail.ImagePath = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            imageDetail.Counter = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[6].Value);
            imageDetail.ImageCaption = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            string imagePath = Application.StartupPath + "\\images\\" + imageDetail.ImagePath;
            picImage.ImageLocation = imagePath;
        }

        private void txtImageCaption_TextChanged(object sender, EventArgs e)
        {
            List<EventImageDetailDTO> list = dto.EventImages;
            list = list.Where(x => x.ImageCaption.Contains(txtImageCaption.Text)).ToList();
            dataGridView1.DataSource = list;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (imageDetail.EventImageID == 0)
            {
                MessageBox.Show("Please choose an image from the table");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Warning!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (bll.Delete(imageDetail))
                    {
                        MessageBox.Show("The picture was deleted");
                        FillDataGrid();
                    }
                }
            }
        }
    }
}
