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

        public static void ComboBoxProps(ComboBox cmb, string name, string ID)
        {
            cmb.DisplayMember = name;
            cmb.ValueMember = ID;
            cmb.SelectedIndex = -1;
        }
    }
}
