using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtensionMethod
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
         
        private void OnExample1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vineet".DoWelcome());
        }

        private void OnExample2_Click(object sender, EventArgs e)
        {
            Manager obj = new Manager();
            MessageBox.Show(obj.GetEmployeeById(1).Name);
        }
    }
}
