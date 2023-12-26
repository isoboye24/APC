using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APC
{
    public class General
    {
        public static bool isNumber(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void ValueCount(Label property, int value, int horizontalPoint, int verticalPoint)
        {
            if (value.ToString().Length < 2)
            {
                property.Text = value.ToString();
                property.Location = new Point(horizontalPoint, verticalPoint);
            }
            else if (value.ToString().Length > 1 && value.ToString().Length < 3)
            {
                property.Text = value.ToString();
                property.Location = new Point(horizontalPoint - 10, verticalPoint);
            }
            else if (value.ToString().Length > 2 && value.ToString().Length < 4)
            {
                property.Text = value.ToString();
                property.Location = new Point(horizontalPoint - 30, verticalPoint);
            }
            else if (value.ToString().Length > 3 && value.ToString().Length < 5)
            {
                property.Text = value.ToString();
                property.Location = new Point(horizontalPoint - 50, verticalPoint);
            }
            else if (value.ToString().Length > 4 && value.ToString().Length < 6)
            {
                property.Text = value.ToString();
                property.Location = new Point(horizontalPoint - 70, verticalPoint);
            }
            else if (value.ToString().Length > 5 && value.ToString().Length < 7)
            {
                property.Text = value.ToString();
                property.Location = new Point(horizontalPoint - 90, verticalPoint);
            }
            else if (value.ToString().Length > 6 && value.ToString().Length < 8)
            {
                property.Text = value.ToString();
                property.Location = new Point(horizontalPoint - 110, verticalPoint);
            }
            else
            {
                MessageBox.Show("The digit of "+ property.Name +" is too big. The panel needs adjustment.");
                property.Text = "########";
                property.Location = new Point(horizontalPoint - 140, verticalPoint);
            }
        }

        public static void ValueCount(Label property, string value, int horizontalPoint, int verticalPoint)
        {
            if (value.Length < 2)
            {
                property.Text = value;
                property.Location = new Point(horizontalPoint, verticalPoint);
            }
            else if (value.Length > 1 && value.Length < 3)
            {
                property.Text = value;
                property.Location = new Point(horizontalPoint - 10, verticalPoint);
            }
            else if (value.Length > 2 && value.Length < 4)
            {
                property.Text = value;
                property.Location = new Point(horizontalPoint - 30, verticalPoint);
            }
            else if (value.Length > 3 && value.Length < 5)
            {
                property.Text = value;
                property.Location = new Point(horizontalPoint - 50, verticalPoint);
            }
            else if (value.Length > 4 && value.Length < 6)
            {
                property.Text = value;
                property.Location = new Point(horizontalPoint - 70, verticalPoint);
            }
            else if (value.Length > 5 && value.Length < 7)
            {
                property.Text = value;
                property.Location = new Point(horizontalPoint - 90, verticalPoint);
            }
            else if (value.Length > 6 && value.Length < 8)
            {
                property.Text = value.ToString();
                property.Location = new Point(horizontalPoint - 110, verticalPoint);
            }
            else
            {
                MessageBox.Show("The digit of " + property.Name + " is too big. The panel needs adjustment.");
                property.Text = "########";
                property.Location = new Point(horizontalPoint - 140, verticalPoint);
            }
        }

        public static void ValueCountInDecimal(Label property, decimal value, int horizontalPoint, int verticalPoint)
        {
            if (value.ToString("0.00").Length < 5)
            {
                property.Text = value.ToString("0.00");
                property.Location = new Point(horizontalPoint, verticalPoint + 40);
            }
            else if (value.ToString("0.00").Length > 4 && value.ToString("0.00").Length < 6)
            {
                property.Text = value.ToString("0.00");
                property.Location = new Point(horizontalPoint - 20, verticalPoint);
            }
            else if (value.ToString("0.00").Length > 5 && value.ToString("0.00").Length < 7)
            {
                property.Text = value.ToString("0.00");
                property.Location = new Point(horizontalPoint - 40, verticalPoint);
            }
            else if (value.ToString("0.00").Length > 6 && value.ToString("0.00").Length < 8)
            {
                property.Text = value.ToString("0.00");
                property.Location = new Point(horizontalPoint - 60, verticalPoint);
            }
            else if (value.ToString("0.00").Length > 7 && value.ToString("0.00").Length < 9)
            {
                property.Text = value.ToString("0.00");
                property.Location = new Point(horizontalPoint - 80, verticalPoint);
            }
            else if (value.ToString("0.00").Length > 8 && value.ToString("0.00").Length < 10)
            {
                property.Text = value.ToString("0.00");
                property.Location = new Point(horizontalPoint - 100, verticalPoint);
            }
            else if (value.ToString("0.00").Length > 9 && value.ToString("0.00").Length < 11)
            {
                property.Text = value.ToString("0.00");
                property.Location = new Point(horizontalPoint - 120, verticalPoint);
            }
            else if (value.ToString("0.00").Length > 10 && value.ToString("0.00").Length < 12)
            {
                property.Text = value.ToString("0.00");
                property.Location = new Point(horizontalPoint - 140, verticalPoint);
            }
            else if (value.ToString("0.00").Length > 11 && value.ToString("0.00").Length < 13)
            {
                property.Text = value.ToString("0.00");
                property.Location = new Point(horizontalPoint - 160, verticalPoint);
            }            
            else if (value.ToString("0.00").Length > 12)
            {
                MessageBox.Show("The digit of " + property.Name + " is too big. The panel needs adjustment.");
                property.Text = "###########";
                property.Location = new Point(horizontalPoint - 180, verticalPoint);
            }
        }

        public static void ComboBoxProps(ComboBox cmb, string name, string ID)
        {
            cmb.DisplayMember = name;
            cmb.ValueMember = ID;
            cmb.SelectedIndex = -1;
        }

        public static string GetDocumentType(string fileExtension)
        {
            if (fileExtension.ToLower() == ".txt")
            {
                return "Text Document";
            }
            else if (fileExtension.ToLower() == ".docx" || fileExtension.ToLower() == ".doc")
            {
                return "Word Document";
            }
            else if (fileExtension.ToLower() == ".pdf")
            {
                return "PDF Document";
            }
            else if (fileExtension.ToLower() == ".html")
            {
                return "HTML Document";
            }
            else if (fileExtension.ToLower() == ".xlsx")
            {
                return "Excel Document";
            }
            else if (fileExtension.ToLower() == ".ppt")
            {
                return "PowerPoint Document";
            }
            else
            {
                return "Unknown Document";
            }
        }
    }
}
