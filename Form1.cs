using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_3___Chapter_Problem
{
    public partial class BasicInput : Form
    {
        string name;
        int age;
        double height;
        public BasicInput()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
             name = txtName.Text;
             age = Convert.ToInt32(txtAge.Text);
             height = Convert.ToDouble(txtHeight.Text);

            lblResultName.Text = "Greetings, " + name;
            lblResultAge.Text = $"You'll probably die in {82 - age} years.";
            lblResultHeight.Text = $"The tallest living person in the world is {Math.Round(2.52 - height,2)}m taller than you.";
        }
    }
}
