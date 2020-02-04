using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management.Automation;

namespace Blackboard_Test_Maker__from_HTML_
{
    public partial class Form1 : Form
    {
        public string TestFormTextBoxText
        {
            get { return TestFormAddressTextBox.Text; }
            set { TestFormAddressTextBox.Text = value; }
        }
        private string TestFormFilePath;
        public Form1()
        {
            InitializeComponent();
        }

        private void ChooseFormButton_Click(object sender, EventArgs e)
        {
            chooseTestForm();
        }
        public void chooseTestForm()
        {
            OpenFileDialog ChooseTestFormWindow = new OpenFileDialog();
            ChooseTestFormWindow.Filter = "Word files (*.docx)|*.docx";
            if (ChooseTestFormWindow.ShowDialog() == DialogResult.OK)
            {
                TestFormFilePath = ChooseTestFormWindow.FileName;
                SetLabelText(TestFormAddressTextBox, TestFormFilePath);
            }
        }
        private void SetLabelText(TextBox textBox, string Address)
        {
            textBox.Text = Address;
        }
    }
}
