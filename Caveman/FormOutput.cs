using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caveman
{
    public partial class FormOutput : Form
    {
        public FormOutput()
        {
            InitializeComponent();
        }

        public FormOutput(string text)
        {
            InitializeComponent();
            richTextBoxCode.Text = text;
        }
    }
}
