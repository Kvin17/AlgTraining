using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingTrainingProgram
{
    public partial class Form1 : Form
    {
        AlgorithmForm algorithmForm = new AlgorithmForm() { Dock = DockStyle.Fill, 
                                                            TopLevel = false, 
                                                            TopMost = true };
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
           
            algorithmForm.FormBorderStyle = FormBorderStyle.None;

            AlgPanel1.Controls.Clear();
            AlgPanel1.Controls.Add(algorithmForm);
            algorithmForm.Show();
            algName.Text = algorithmForm.algorithm._name;
        }
        private void btnBubble_Click(object sender, EventArgs e)
        {
            algorithmForm.algorithm = new BubbleSort();
            algName.Text = algorithmForm.algorithm._name;
        }

        private void btnShaker_Click(object sender, EventArgs e)
        {
            algorithmForm.algorithm = new ShakerSort();
            algName.Text = algorithmForm.algorithm._name;
            Form1_Load(sender, e);
        }

        private void btn_gnome_sort_Click(object sender, EventArgs e)
        {

        }

    
    }
}
