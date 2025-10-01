using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Structures_and_Algorithms
{
    public partial class Form8_PrintFrm : Form
    {
        public Form8_PrintFrm()
        {
            InitializeComponent();

            DisplayListbox.Items.AddRange(DisplayListbox.Items);
        }

        private void Form8_PrintFrm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
