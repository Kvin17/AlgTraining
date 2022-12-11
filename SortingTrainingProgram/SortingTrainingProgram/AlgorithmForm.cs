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
    public partial class  AlgorithmForm : Form
    {
        public Tile[] TileArray { get; } = new Tile[10];

        public bool expectation;
        private Label[] _codeView;
        public IAlgorithm algorithm { get; set; } = new BubbleSort();
        public AlgorithmForm()
        {
            InitializeComponent();


        }
        
    private void AlgorithmForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < TileArray.Length; i++)
            {
                TileArray[i] = new Tile(25 + i * Tile.Size + i * 3, 185);

            }
            for (int i = 0; i < TileArray.Length; i++)
            {

                TileArray[i]._Label.ForeColor = Color.Bisque;
                TileArray[i]._Label.Text = $"{i}";
                TileArray[i]._Label.BackColor = Tile._default;
                TileArray[i]._Label.Font = new Font(TileArray[i]._Label.Font.FontFamily, TileArray[i]._Label.Font.Size * 2.2f);
                TileArray[i]._Label.TextAlign = ContentAlignment.MiddleCenter;
                TileArray[i]._Label.Anchor = AnchorStyles.None;
                TileArray[i]._textBox = new TextBox()
                {
                    Multiline = true,

                    Size = new Size(Tile.Size, 65),
                    Location = new Point(TileArray[i]._x, 50)
                };
                TileArray[i]._textBox.Font = new Font(TileArray[i]._textBox.Font.FontFamily, TileArray[i]._textBox.Font.Size * 2.2f);
                TileArray[i]._textBox.TextAlign = HorizontalAlignment.Center;
                TileArray[i]._textBox.Anchor = AnchorStyles.None;
                TileArray[i]._textBox.BorderStyle = BorderStyle.FixedSingle;
                TileArray[i]._textBox.BackColor = Color.FromArgb(255, 191, 191);
                TileArray[i]._textBox.KeyPress += (s, o) =>
                {
                    char number = o.KeyChar;
                    if (!Char.IsDigit(number) && number != 8)
                        o.Handled = true;
                };
                Controls.Add(TileArray[i]._Label);
                Controls.Add(TileArray[i]._textBox);
            }
            btnNext.MouseEnter += (s, o) =>
            {
                btnNext.FlatAppearance.BorderSize = 1;
                btnNext.FlatAppearance.BorderSize = 0;
            };
            btnLast.MouseEnter += (s, o) =>
            {
                btnLast.FlatAppearance.BorderSize = 1;
                btnLast.FlatAppearance.BorderSize = 0;
            };
            _codeView = new Label[algorithm._codeArray.Length];
            for(int i = 0; i < algorithm._codeArray.Length;i++)
            {
                _codeView[i] = new Label() {
                    Text = algorithm._codeArray[i],
                    Location = new Point(0, i * 20),
                    Size = new Size(810, 20),
                    ForeColor = Color.White,
                    Font = new Font(FontFamily.GenericMonospace, 14)            
                };
                codePanel.Controls.Add(_codeView[i]);
            }
           
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {

            if (!algorithm.InAlgorithm)
            {
                algorithm.InAlgorithm = true;
                algorithm.NextStep(_codeView, TileArray, this);


                await Task.Delay(1000);

            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (!algorithm.InAlgorithm)
            {
                algorithm.InAlgorithm = true;
                algorithm.LastStep(TileArray);
            }

        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            _codeView[0].ForeColor = Color.Red;
            for (int j = 0; j < TileArray.Length; j++)
            {
                if (TileArray[j]._textBox.Text == "")
                {
                    return;
                }

            }
            for (int i = 0; i < TileArray.Length; i++)
            {
                TileArray[i]._Label.Text = TileArray[i]._textBox.Text;
            }
            algorithm.setArray(TileArray);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            foreach (var t in TileArray)
            {
                t._textBox.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
