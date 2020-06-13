using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace OOPLV6
{
    public partial class Form1 : Form
    {

        ScriptEngine pyEngine = null;
        ScriptScope pyScope = null;

        double A = 0;
        double B = 0;

        public Form1()
        {
            InitializeComponent();

            pyEngine = Python.CreateEngine();
            pyScope = pyEngine.CreateScope();

            //tbResult.ReadOnly = true;
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //openFileDialog1.ShowDialog();
            ScriptSource script = null;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                script = pyEngine.CreateScriptSourceFromFile(openFileDialog1.FileName);
            }
            else
            {
                string message = "Error Message Incomming";
                string caption = "No file found";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
            }
            script.Execute(pyScope);
            Console.WriteLine(openFileDialog1.FileName);
            dynamic AddFunction = pyScope.GetVariable("AddFunction");
            AddFunction(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A = Convert.ToDouble(tbA.Text);
            B = Convert.ToDouble(tbB.Text);
            tbResult.Text = Convert.ToString(A + B);
        }

        private void subToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A = Convert.ToDouble(tbA.Text);
            B = Convert.ToDouble(tbB.Text);
            tbResult.Text = Convert.ToString(A - B);
        }

        private void mulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A = Convert.ToDouble(tbA.Text);
            B = Convert.ToDouble(tbB.Text);
            tbResult.Text = Convert.ToString(A * B);
        }

        private void divToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A = Convert.ToDouble(tbA.Text);
            B = Convert.ToDouble(tbB.Text);
            tbResult.Text = Convert.ToString(A / B);
        }
    }
}
