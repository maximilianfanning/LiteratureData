using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiteratureWorkDataCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateAll_Click(object sender, EventArgs e)
        {
            characterCount(textInput.Text);
        }
        public void characterCount(string input)
        {
            string output = "";
            StatFinder sf = new StatFinder(input);
            int[] fullCount = sf.characterCount();
            for (int i = 0; i < fullCount.Length; i++)
            {
                char placeHolder = (char)i;
                output += (char)i + ": " + fullCount[i] + "\n";
            }
            output += "Full count: " + StatFinder.arrayAdd(fullCount);
            characterCountOutput.Text = output;
        }
    }
}
