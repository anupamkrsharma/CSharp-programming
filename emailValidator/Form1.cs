using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
/**/
namespace emailValidator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            string pattern = @"\S+[@]+\S+[.]+\S";

            Regex regex = new Regex(pattern);
            if (regex.IsMatch(textBox1.Text))
            {
                label3.Text = "Perfect!";
            }
            else
            {
                label3.Text = "Invalid Email";
            }
        }
    }
}
