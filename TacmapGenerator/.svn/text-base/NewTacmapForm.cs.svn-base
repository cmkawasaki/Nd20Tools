using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TacmapGenerator
{
    public partial class NewTacmapForm : Form
    {
        public MainForm myParentForm;

        public NewTacmapForm()
        {
            InitializeComponent();
        }

        private void generateTacmapButton_Click(object sender, EventArgs e)
        {
            int test;
            if (!int.TryParse(widthTB.Text, out test) || !int.TryParse(lengthTB.Text, out test))
            {
                MessageBox.Show("Invalid input in the number fields!  Please correct and try again!");
                return;
            }
            else
            {
                int width, length;
                width = int.Parse(widthTB.Text);
                length = int.Parse(lengthTB.Text);

                if (width > 50 || length > 50)
                {
                    MessageBox.Show("Numbers cannot be greater than 50!  Please Correct and Try again!");
                    return;
                }
                else
                {
                    myParentForm.RedrawTacmap(width, length);
                    this.Close();
                }
            }
        }
    }
}
